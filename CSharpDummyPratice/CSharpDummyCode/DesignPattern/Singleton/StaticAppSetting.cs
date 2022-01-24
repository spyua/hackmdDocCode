using System.Configuration;

namespace DesignPattern.Singleton
{
    public class StaticAppSetting
    {
        public static readonly string AppName = GetConfigValue("AppName");

        public static readonly string LocalIp = GetConfigValue("LocalIp");

        public static readonly string LocalPort = GetConfigValue("LocalPort");

        private static string GetConfigValue(string value)
        {
            return ConfigurationManager.AppSettings[value];
        }

    }
}
