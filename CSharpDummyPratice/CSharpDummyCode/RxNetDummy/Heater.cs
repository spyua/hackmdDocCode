using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxNetDummy
{
    class Heater
    {
        private delegate void TemperatureChanged(int temperature);
        private event TemperatureChanged TemperatureChangedEvent;
        public void BoilWater()
        {
            TemperatureChangedEvent += ShowTemperature;
            TemperatureChangedEvent += MakeAlerm;
            Task.Run(
                () =>
            Enumerable.Range(1, 100).ToList().ForEach((temperature) => TemperatureChangedEvent(temperature))
            );
        }
        private void ShowTemperature(int temperature)
        {
            Console.WriteLine($"當前溫度：{temperature}");
        }
        private void MakeAlerm(int temperature)
        {
            Console.WriteLine($"嘟嘟嘟，當前溫度{temperature}");
        }
    }
}
