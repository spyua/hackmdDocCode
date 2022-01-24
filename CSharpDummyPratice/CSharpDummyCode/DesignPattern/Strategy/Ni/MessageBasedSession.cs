using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class MessageBasedSession
    {
        private int Value;
        public MessageBasedSession()
        {
            Value = -1;
        }

        public string Write(string cmd)
        {
            if (cmd.Equals("SetPower"))
                Value = 20;


            return "GpibWriteDone";
        }

        public int Read()
        {
            return Value;
        }
    }
}
