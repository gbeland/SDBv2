using SDB.Classes.User;

namespace SDB.Interfaces
{
    public interface ISettingsService
    {
        ClassUser LoggedOnUser { get; set; }
        void SaveSettings();
        void LoadSettings();
    }
}
