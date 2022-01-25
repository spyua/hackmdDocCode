using DesignPattern.Strategy;
using FluentAssertions;
using NUnit.Framework;
using static DesignPattern.Strategy.ComFacotry;

namespace DesignPattern
{
    public class StaegyTest
    {
        private string Action;
        private string GpibWriteDone;
        private string UsbWriteDone;

        [SetUp]
        public void Setup()
        {
            Action = "SetPower";
            UsbWriteDone = "UsbWriteDone";
            GpibWriteDone = "GpibWriteDone";
        }

        [Test]
        public void when_instance_gpib_device_It_can_use_gpib_write_method()
        {
            //
            var gpibCom = new NormalBaseDevice(true);
            var cmd = gpibCom.Write(Action);
            
            cmd.Should().BeEquivalentTo(GpibWriteDone);
            gpibCom.Read().Should().Be(20);
        }

       
        [Test]
        public void when_instance_usb_device_It_can_use_gpib_write_method()
        {
            var usbCom = new NormalBaseDevice(false);
            var cmd = usbCom.Write(Action);
            cmd.Should().BeEquivalentTo(UsbWriteDone);
        }

        [Test]
        public void strategy_when_instance_gpib_device_It_can_use_gpib_write_method()
        {

            IStrategy gpibCom = new GpibCom();
            var cmd = gpibCom.Write(Action);
            cmd.Should().BeEquivalentTo(GpibWriteDone);
            gpibCom.Read().Should().Be(20);
        }

        [Test]
        public void strategy_when_instance_usb_device_It_can_use_gpib_write_method()
        {

            IStrategy usbCom = new UsbCom();
            var cmd = usbCom.Write(Action);
            cmd.Should().BeEquivalentTo(UsbWriteDone);
            usbCom.Read().Should().Be(20);
        }

        [Test]
        public void strategy_when_instance_usb_device_througt_factory_It_can_use_gpib_write_method()
        {

            var usbCom = ComFacotry.CreateCom(ComType.Usb);
            var cmd = usbCom.Write(Action);
            cmd.Should().BeEquivalentTo(UsbWriteDone);
            usbCom.Read().Should().Be(20);
        }

    }
}
