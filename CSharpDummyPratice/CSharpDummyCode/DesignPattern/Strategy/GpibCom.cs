namespace DesignPattern.Strategy
{
    public class GpibCom : IStrategy
    {
        private MessageBasedSession Device;

        public GpibCom()
        {
            Device = new MessageBasedSession();
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
