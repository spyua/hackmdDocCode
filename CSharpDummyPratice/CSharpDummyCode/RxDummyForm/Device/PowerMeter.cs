using System;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RxDummyForm.Device
{
    public class PowerMeter
    {


        public IObservable<string> ScanMeterSource(int searchTime)
        {
            var ob = Observable.Create<string>((obs) =>
            {
                var task = SearchMeterDevice(searchTime);

                try
                {              
                    obs.OnNext(task.Result);
                    obs.OnCompleted();     
                }
                catch(Exception e)
                {
                    obs.OnError(e);
                }

                return task;
            });

            return ob;
        }
        public async Task<string> SearchMeterDevice(int searchTime)
        {
            // 硬體操作實作，這邊以Delay先取代行為
            var task = Task.Run(() =>
            {
                SpinWait.SpinUntil(() => false, searchTime);
            });
            if(await Task.WhenAny(task, Task.Delay(5000)) == task)
            {
                return "Scan Meter OK";
            }
            else
            {
                throw new Exception("Search Time Out");
            }
        } 


    }
}
