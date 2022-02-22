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
     
        }

        private void SearchMeterTimeOut_Click(object sender, EventArgs e)
        {
            var meter = new PowerMeter();

            meter.ScanMeterSource(3000)
                        .SubscribeOn(Scheduler.Default)
                        .ObserveOn(SynchronizationContext.Current)
                        .Subscribe(
                                nextMsg => {
                                    // Next
                                    MessageBox.Show(nextMsg);
                                },
                                ex =>
                                {
                                    // Expection
                                    MessageBox.Show(ex.InnerException.Message.ToString());
                                },
                                ()=>{
                                    // Finish
                                    MessageBox.Show("Scan Finish");
                                });
        }

        private void SearchLightSourceTimeOut_Click(object sender, EventArgs e)
        {
            var lightSource = new LightSource();

            lightSource.ScanLightSource(10000)
                        .SubscribeOn(Scheduler.Default)
                        .ObserveOn(SynchronizationContext.Current)
                        .Subscribe(
                                nextMsg => {
                                    MessageBox.Show(nextMsg);
                                },
                                ex =>
                                {
                                    MessageBox.Show(ex.InnerException.Message.ToString());
                                },
                                ()=> {

                                    // Finish
                                    MessageBox.Show("Scan Finish");
                                });
        }

        private void SearchBothDevice_Click(object sender, EventArgs e)
        {

            var meter = new PowerMeter();
            var lightSource = new LightSource();

            Observable.Merge(
              meter.ScanMeterSource(4000).SubscribeOn(Scheduler.Default),
              lightSource.ScanLightSource(4000).SubscribeOn(Scheduler.Default)
          )
          .ObserveOn(SynchronizationContext.Current)
          .Subscribe(
                 nextMsg => {
                     MessageBox.Show(nextMsg);
                 },
                 ex =>
                     {
                        MessageBox.Show(ex.InnerException.ToString());
                   },
                  ()=>{
                      // Finish
                      MessageBox.Show("Scan Finish");
                  });
            //.AddTo(Disposables);
        }

        private void SearchConcat_Click(object sender, EventArgs e)
        {
            var meter = new PowerMeter();
            var lightSource = new LightSource();

            meter.ScanMeterSource(3000)
                .Concat(lightSource.ScanLightSource(3000))
                .SubscribeOn(Scheduler.Default)
                .ObserveOn(SynchronizationContext.Current).Subscribe(
                    nextMsg => {
                        MessageBox.Show(nextMsg);
                    },
                    ex =>
                    {
                        MessageBox.Show(ex.InnerException.ToString());
                    },
                    ()=> {

                        // Finish
                        MessageBox.Show("Scan Finish");
                    });
                }
    }
}
