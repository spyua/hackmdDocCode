using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class ComFacotry
    {
        public enum ComType { Gpib, Usb}

        public static IStrategy CreateCom(ComType type)
        {
            IStrategy com;

            switch (type)
            {
                case ComType.Gpib:
                    com = new GpibCom();
                    break;
                
                default:
                    com = new UsbCom();
                    break;

            }

            return com;
        }
    }
}
