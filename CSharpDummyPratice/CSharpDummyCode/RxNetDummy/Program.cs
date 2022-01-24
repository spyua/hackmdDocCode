using System;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace RxNetDummy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Heater heater = new Heater();
            heater.BoilWater();
            */

            var observable = Enumerable.Range(1, 100).ToObservable(NewThreadScheduler.Default);//可觀察序列
            Subject<int> subject = new Subject<int>();//Subject
            subject.Subscribe((temperature) => Console.WriteLine($"當前溫度：{temperature}"));//訂閱Subject
            subject.Subscribe((temperature) => Console.WriteLine($"當前水溫：{temperature}"));//訂閱Subject
            observable.Subscribe(subject);//訂閱Onservable
            Console.ReadKey();
        }
    }
}
