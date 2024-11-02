namespace Unbrdn.Core.Api.Models
{
    public class AccountSettingsDto
    {
        public bool EnableEmailNotifications { get; set; }
        public string? LanguagePreference { get; set; }  // e.g., "en-US", "fr-FR"
        public bool DarkModeEnabled { get; set; }
    }
}
