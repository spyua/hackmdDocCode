using System;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RxDummyForm.Device
{
    public class PowerMeter
    {


        public IObservable<bool> ScanMeterSource(int searchTime)
        {
            var ob = Observable.Create<bool>((obs) =>
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
        public async Task<bool> SearchMeterDevice(int searchTime)
        {
            var task = Task.Run(() =>
            {
                SpinWait.SpinUntil(() => false, searchTime);
            });
            if(await Task.WhenAny(task, Task.Delay(5000)) == task)
            {
                return true;
            }
            else
            {
                throw new Exception("Search Time Out");
            }
        } 


    }
}
