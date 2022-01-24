namespace DesignPattern.Strategy
{
    public class UsbCom : IStrategy
    {
        private Device Device;

        public UsbCom()
        {
            Device = new Device();
        }

        public string Write(string cmd)
        {
            return Device.Write(cmd);
        }

        public int Read()
        {
            return Device.Read();
        }
    }
}
