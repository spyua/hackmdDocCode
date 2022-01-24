namespace DesignPattern.Singleton
{
    public class SingletonInternetAppSetting : SingletonAppSetting
    {
        private static class SingletonHolder
        {
            static SingletonHolder() { }
            internal static readonly SingletonInternetAppSetting INSTANCE = new SingletonInternetAppSetting();
        }
        public static new SingletonInternetAppSetting Instance { get { return SingletonHolder.INSTANCE; } }

        public readonly string LocalIp;
        public readonly string LocalPort;

        protected SingletonInternetAppSetting()
        {
            LocalIp = GetConfigValue("LocalIp");
            LocalPort = GetConfigValue("LocalPort");
        }

    }
}
