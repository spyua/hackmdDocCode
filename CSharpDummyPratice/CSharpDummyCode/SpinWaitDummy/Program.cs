using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinWaitDummy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var polling = new SpinWaitPolling();
            var counter = 0;
            polling.Interval = 1;

            polling.Start(() =>
            {
                counter++;
                Console.WriteLine(counter);
            });
            */
            var polling = new ThreadSleepPolling();
            var counter = 0;
            polling.Interval = 1;

            polling.Start(() =>
            {
                counter++;
                Console.WriteLine(counter);
            });
            
            Console.ReadKey();
        }
    }
}
