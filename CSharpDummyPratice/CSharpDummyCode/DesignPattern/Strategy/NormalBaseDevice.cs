using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class NormalBaseDevice
    {

        private bool IsGpib;

        MessageBasedSession GpibCom;

        Device UsbCom;

        public NormalBaseDevice(bool isGPIB)
        {

            IsGpib = isGPIB;

            if (isGPIB)
            {
                GpibCom = new MessageBasedSession();
            }
            else
            {
                UsbCom = new Device();
            }

        }

        public string Write(string cmd)
        {

            if (IsGpib)
            {
                return GpibCom.Write(cmd);
            }
            else
            {
                return UsbCom.Write(cmd);
            }

        }

        public int Read()
        {

            if (IsGpib)
            {
                return GpibCom.Read();
            }
            else
            {
                return UsbCom.Read();
            }

        }

    }
}
