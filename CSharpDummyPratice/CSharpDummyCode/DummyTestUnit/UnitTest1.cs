using DummyTestUnit.SpintWait;
using NUnit.Framework;

namespace DummyTestUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void when_use_thread_sleep_I_will_see_the_cpu_use_rate_is_hight()
        {
            var polling = new ThreadSleepPolling();
            var counter = 0;
            polling.Interval = 1;

            polling.Start(() =>
            {
                counter++;
            });

        }


        [Test]
        public void when_use_spintWait_I_will_see_the_cpu_use_rate_is_hight()
        {
            var polling = new SpinWaitPolling();
            var counter = 0;
            polling.Interval = 1;

            polling.Start(() =>
            {
                counter++;
            });

        }
    }
}