using System;
using System.Windows.Forms;

namespace MVP
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new PackageDocForm();
            IPresenter presenter = new PackageDocPresenter(form);
            Application.Run(form);
        }
    }
}
