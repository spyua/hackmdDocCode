using RxDummyForm.Device;
using System;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RxDummyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            /*
            var lightSource = new LightSource();
            lightSource.ScanLightSource(5000)
                        .SubscribeOn(Scheduler.Default)
                        .ObserveOn(SynchronizationContext.Current)
                        .Subscribe(
                                x => {
                                    MessageBox.Show(x.ToString()); 
                                },
                                ex =>
                                {
                                     MessageBox.Show(ex.Message.ToString());
                                });
            */

        }

        private void SearchMeterTimeOut_Click(object sender, EventArgs e)
        {
            var meter = new PowerMeter();

            meter.ScanMeterSource(5000)
                        .SubscribeOn(Scheduler.Default)
                        .ObserveOn(SynchronizationContext.Current)
                        .Subscribe(
                                x => {
                                    MessageBox.Show("Scan Meter-----"+x.ToString());
                                },
                                ex =>
                                {
                                    MessageBox.Show(ex.Message.ToString());
                                });
        }

        private void SearchLightSourceTimeOut_Click(object sender, EventArgs e)
        {
            var lightSource = new LightSource();

            lightSource.ScanLightSource(5000)
                        .SubscribeOn(Scheduler.Default)
                        .ObserveOn(SynchronizationContext.Current)
                        .Subscribe(
                                x => {
                                    MessageBox.Show("Scan LightSource-----" + x.ToString());
                                },
                                ex =>
                                {
                                    MessageBox.Show(ex.Message.ToString());
                                });
        }

        private void SearchBothDevice_Click(object sender, EventArgs e)
        {

            var meter = new PowerMeter();
            var lightSource = new LightSource();

            Observable.Merge(
              meter.ScanMeterSource(50000).SubscribeOn(Scheduler.Default),
              lightSource.ScanLightSource(5000).SubscribeOn(Scheduler.Default)
          )
          .ObserveOn(SynchronizationContext.Current)
          .Subscribe(
                x => {
                     MessageBox.Show("Scan OK" + x.ToString());
                 },
                 ex =>
                     {
                        MessageBox.Show(ex.InnerException.ToString());
                   });
            //.AddTo(Disposables);
        }

        private void SearchConcat_Click(object sender, EventArgs e)
        {
            var meter = new PowerMeter();
            var lightSource = new LightSource();

            meter.ScanMeterSource(5000)
                .Concat(lightSource.ScanLightSource(5000))
                .SubscribeOn(Scheduler.Default)
                .ObserveOn(SynchronizationContext.Current).Subscribe(
                    x => {
                        MessageBox.Show("Scan OK" + x.ToString());
                    },
                    ex =>
                    {
                        MessageBox.Show(ex.InnerException.ToString());
                    });
                }
    }
}
