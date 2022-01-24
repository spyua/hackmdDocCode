using System.Configuration;

namespace DesignPattern.Singleton
{
    public class SingletonAppSetting : ISetting
    {
        private static class SingletonHolder
        {
            static SingletonHolder() { }
            internal static readonly SingletonAppSetting INSTANCE = new SingletonAppSetting();
        }
        public static SingletonAppSetting Instance { get { return SingletonHolder.INSTANCE; } }

        public readonly string AppName;


        protected SingletonAppSetting()
        {
            AppName = GetConfigValue("AppName");

        }

        public string GetConfigValue(string value)
        {
            return ConfigurationManager.AppSettings[value];
        }
    }
}
