using System;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;

namespace RxNetDummy
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*
            Heater heater = new Heater();
            heater.BoilWater();
            */

            /*
            var observable = Enumerable.Range(1, 100).ToObservable(NewThreadScheduler.Default);//可觀察序列
            Subject<int> subject = new Subject<int>();//Subject
            subject.Subscribe((temperature) => Console.WriteLine($"當前溫度：{temperature}"));//訂閱Subject
            subject.Subscribe((temperature) => Console.WriteLine($"當前水溫：{temperature}"));//訂閱Subject
            observable.Subscribe(subject);//訂閱Onservable
            */

            /*
            IObservable<long> xs = Observable
                                    .Timer(DateTimeOffset.Now.AddSeconds(1.5), TimeSpan.FromSeconds(0.5))
                                    //.Take(5)
                                    .Where(x=>x%2==0);

            xs.Subscribe(x => Console.WriteLine(x));
            */

            var xs = Keystrokes().Where(char.IsUpper);

            xs.Subscribe(x => Console.WriteLine(x));

            await new TaskCompletionSource<object>().Task;
        }

        static IObservable<char> Keystrokes()
        {

            var keyStrokesObservable = Observable.Create<char>((obs, cancel) => {

                var task = Task.Run(() =>
                {
                    while (!cancel.IsCancellationRequested)
                    {
                        var c = Console.ReadKey().KeyChar;
                        obs.OnNext(c);
                    }
                });

                return task; 
            });

            return keyStrokesObservable;
        }

    }
}
