using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace DummyTestUnit.SpintWait
{
    public class ThreadSleepPolling
    {

        private int _interval = 1000;
        public int Interval
        {
            get { return _interval; }
            set { _interval = value; }
        }
        public bool IsRunning { get; internal set; }

        public void Start(Action action)
        {
            if (this.IsRunning)
            {
                return;
            }

            this.IsRunning = true;

            Task.Factory.StartNew(() =>
            {
                Stopwatch watch = new Stopwatch();
                while (this.IsRunning)
                {
                    watch.Restart();
                    action.Invoke();

                    while (watch.ElapsedMilliseconds < this.Interval)
                    {
                        Thread.Sleep(1);
                    }
                }
            });
        }

        public void Stop()
        {
            if (!this.IsRunning)
            {
                return;
            }
            this.IsRunning = false;
        }

    }
}
