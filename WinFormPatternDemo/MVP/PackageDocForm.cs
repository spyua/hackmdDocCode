using MVP.Helper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MVP
{
    public partial class PackageDocForm : Form,IView
    {

        public string Product
        {
            get { return TextBox_Product.Text; }
            set { TextBox_Product.Text = value; }
        }
        public string DocNo
        {
            get { return TextBox_DocNo.Text; }
            set { TextBox_DocNo.Text = value; }
        }
        public int Yield
        {
            get { return int.Parse(TextBox_Yield.Text); }
            set { TextBox_Yield.Text = value.ToString(); }
        }
        public int NGYield {
            get { return int.Parse(TextBox_NGYield.Text); }
            set { TextBox_NGYield.Text = value.ToString(); }
        }
        public IList<string> PackageDocList
        {
            get { return (IList<string>)ListBox_PackDoc.DataSource; }
            set { ListBox_PackDoc.DataSource = value; }
        }

        public int SelectedPackageDoc
        {
            get { return this.ListBox_PackDoc.SelectedIndex; }
            set { this.ListBox_PackDoc.SelectedIndex = value; }
        }
        public IPresenter Presenter { private get; set; }

        public PackageDocForm()
        {
            InitializeComponent();
        }

        private void ListBox_PackDoc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            TryFlow(() =>
            {
                var docNo = ListBox_PackDoc.GetItemText(ListBox_PackDoc.SelectedItem);
                Presenter.UpdatePackageDocView(docNo);
            });
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            TryFlow(() =>
            {
                Presenter.SavePackageDoc();
            });
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            TryFlow(() =>
            {
                Presenter.DeletePackageDoc();
            });
        }

        private void TextBox_Yield_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.InVaildKeyNumber())
                e.Handled = true;
        }

        private void TextBox_NGYield_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.InVaildKeyNumber())
                e.Handled = true;
        }

        private void TryFlow(Action action)
        {
            try
            {
                action.Invoke();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

 
    }
}
