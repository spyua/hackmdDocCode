namespace DesignPattern.Strategy
{

    public class Device
    {
        private int Value;
        public Device()
        {
            Value = -1;
        }

        public string Write(string cmd)
        {
            if(cmd.Equals("SetPower"))
                Value = 20;

            return "UsbWriteDone";
        }

        public int Read()
        {
            return Value;
        }
    }
}
