using DesignPattern.Singleton;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPattern
{
    public class SingletonTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void read_static_appsetting_I_can_get_config_value()
        {
            var appName = StaticAppSetting.AppName;
            appName.Should().BeEquivalentTo("DesignPattern");
        }

        [Test]
        public void read_singleton_appsetting_I_can_get_config_value()
        {
            var appName = SingletonAppSetting.Instance.AppName;
            appName.Should().BeEquivalentTo("DesignPattern");
        }

        [Test]
        public void read_internet_singleton_appsetting_I_can_get_config_value()
        {
            var localIp = SingletonInternetAppSetting.Instance.LocalIp;
            var localPort = SingletonInternetAppSetting.Instance.LocalPort;
            localIp.Should().BeEquivalentTo("127.0.0.1");
            localPort.Should().BeEquivalentTo("7788");
        }


        [Test]
        public void use_singleton_interface_method_I_can_read_config_file()
        {

            ISetting config = SingletonInternetAppSetting.Instance;
            var appName = config.GetConfigValue("AppName");
            appName.Should().BeEquivalentTo("DesignPattern");
        }
    }
}