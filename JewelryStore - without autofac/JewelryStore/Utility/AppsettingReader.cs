using System.Configuration;

namespace JewelryStore
{
    static class AppsettingReader
    {
        internal static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                return  appSettings[key] ?? Messages.ReadErrorInAppsettings;
            }
            catch (ConfigurationErrorsException)
            {
                return Messages.ReadErrorInAppsettings;
            }
        }
    }
}
