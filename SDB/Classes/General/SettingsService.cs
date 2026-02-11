using SDB.Classes.General;
using SDB.Classes.User;
using SDB.Interfaces;

namespace SDB.Classes.General
{
    public class SettingsService : ISettingsService
    {
        // For now, we wrap the static GS to maintain compatibility during migration.
        // Eventually, GS should be removed and SettingsService should hold the state.
        
        public ClassUser LoggedOnUser
        {
            get => GS.Settings.LoggedOnUser;
            set => GS.Settings.LoggedOnUser = value;
        }

        public void SaveSettings()
        {
            GS.SaveSettings();
        }

        public void LoadSettings()
        {
            GS.LoadSettings();
        }
    }
}
