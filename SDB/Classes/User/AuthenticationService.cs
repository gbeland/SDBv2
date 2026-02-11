using System;
using MySql.Data.MySqlClient;
using SDB.Classes.General; // For logging/GS
using SDB.Classes.Admin;   // For ClassEventLog
using SDB.Interfaces;

namespace SDB.Classes.User
{
    public class AuthenticationService
    {
        private const int MAX_FAILED_LOGIN_ATTEMPTS = 3;
        private int _loginAttempts;
        private readonly ISettingsService _settingsService;

        public bool IsLockedOut => _loginAttempts >= MAX_FAILED_LOGIN_ATTEMPTS;

        public AuthenticationService(ISettingsService settingsService)
        {
            _settingsService = settingsService;
            _loginAttempts = 0;
        }

        public ClassUser AttemptLogin(int userId, string password, out string message)
        {
            message = string.Empty;

            if (IsLockedOut)
            {
                ClassLogFile.AppendToLog("Multiple login failures, locked out.");
                message = "Too many failed attempts.";
                return null;
            }

            var candidateUser = ClassUser.GetByID(userId);
            if (candidateUser == null)
            {
                message = "Login failed. Check your login and password and try again.";
                _loginAttempts++;
                return null;
            }

            if (candidateUser.LoginDisabled)
            {
                ClassLogFile.AppendToLog($"Login failed for disabled account {candidateUser.ID}");
                message = "Account disabled. Consult supervisor/administrator.";
                return null;
            }

            try
            {
                if (candidateUser.GetForceLogout())
                {
                    ClassLogFile.AppendToLog($"Login failed for forced logout user ID {candidateUser.ID}");
                    message = "Logins have been temporarily disabled. Consult supervisor/administrator.";
                    return null;
                }

                if (ClassUser.VerifyPassword(candidateUser.ID, password))
                {
                    GrantLogin(candidateUser);
                    return candidateUser;
                }

                if (ClassUser.VerifyTemporaryPassword(candidateUser.ID, password, TimeSpan.FromHours(ClassUser.TEMPORARY_PASSWORD_VALID_FOR_HOURS)))
                {
                    GrantLogin(candidateUser);
                    message = "Temporary password used.";
                    return candidateUser;
                }

                ClassLogFile.AppendToLog($"Login failed for user ID {candidateUser.ID}");
                message = "Login failed. Check your login and password and try again.";
                _loginAttempts++;
                return null;
            }
            catch (MySqlException exc)
            {
                ClassLogFile.AppendToLog("Error during login:", exc);
                message = string.Format("A database error has occurred. Ensure you are using the latest version.{0}{0}{1}", Environment.NewLine, exc.Message);
                return null;
            }
            catch (Exception exc)
            {
                ClassLogFile.AppendToLog("Exception during login: " + exc.Message);
                message = string.Format("An error occurred during login. The database may be unavailable, incompatible, or settings are incorrect.{0}{0}{1}", Environment.NewLine, exc.Message);
                return null;
            }
        }

        private void GrantLogin(ClassUser user)
        {
            if (user == null) return;

            _loginAttempts = 0;
            var now = ClassDatabase.GetCurrentTime();
            _settingsService.LoggedOnUser = user;
            _settingsService.LoggedOnUser.LoggedIn = now;
            _settingsService.LoggedOnUser.LastInteraction = now;
            ClassUser.SetLoggedIn(_settingsService.LoggedOnUser.ID);
            ClassLogFile.AppendToLog($"User {user.ID} logged on.");
        }

        public void Logout()
        {
            if (_settingsService.LoggedOnUser == null) return;

            ClassLogFile.AppendToLog($"User {_settingsService.LoggedOnUser.ID} logged off.");
            try
            {
                ClassEventLog.AddEntry(_settingsService.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.LogOff, ClassEventLog.ObjectTypeEnum.User, _settingsService.LoggedOnUser.ID, string.Empty);
                ClassUser.SetLoggedOut(_settingsService.LoggedOnUser.ID);
            }
            catch (Exception exc)
            {
                ClassLogFile.AppendToLog("Error logging out: " + exc.Message);
            }

            _settingsService.LoggedOnUser = null;
        }

        public void ResetLockout()
        {
            _loginAttempts = 0;
        }
    }
}
