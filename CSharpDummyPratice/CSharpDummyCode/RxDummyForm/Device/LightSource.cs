using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RxDummyForm.Device
{
    public class LightSource
    {

        public IObservable<bool> ScanLightSource(int searchTime)
        {
            var ob = Observable.Create<bool>((obs) =>
            {
                var task = SearchLightSourceDevice(searchTime);

                try
                {
                    obs.OnNext(task.Result);
                    obs.OnCompleted();
                }
                catch (Exception e)
                {
                    obs.OnError(e);
                }

                return task;
            });

            return ob;
        }

        public async Task<bool> SearchLightSourceDevice(int searchTime)
        {
            var task = Task.Run(() =>
            {
                SpinWait.SpinUntil(() => false, searchTime);
            });
            if (await Task.WhenAny(task, Task.Delay(5000)) == task)
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
