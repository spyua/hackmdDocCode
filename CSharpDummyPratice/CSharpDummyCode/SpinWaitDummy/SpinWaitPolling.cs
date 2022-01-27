using System;
using System.Threading;
using System.Threading.Tasks;

namespace SpinWaitDummy
{
    public class SpinWaitPolling
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
                while (this.IsRunning)
                {
                    action.Invoke();
                    SpinWait.SpinUntil(() => !this.IsRunning, this.Interval);
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
