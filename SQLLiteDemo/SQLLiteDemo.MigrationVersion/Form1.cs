using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLLiteDemo.MigrationVersion
{
    public partial class Form1 : Form
    {
        private TestContext TestRepo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestRepo = new TestContext();
            LoadGridView();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var data = new TestTable()
            {
                Id = Guid.NewGuid(),
                Content = new Random().Next(0, 100).ToString(),
            };

            using (var db = new TestContext())
            {
                db.TestTables.Add(data);
                var count = db.SaveChanges();
            }

            LoadGridView();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            using (var db = new TestContext())
            {
                var allDatas = db.TestTables.ToList();
                db.TestTables.RemoveRange(allDatas);
                db.SaveChanges();
            }

            LoadGridView();
        }


        public void LoadGridView()
        {
            var datas = TestRepo.TestTables.ToList();

            var dt = new DataTable();
            dt.Columns.Add(nameof(TestTable.Id), typeof(string));
            dt.Columns.Add(nameof(TestTable.Content), typeof(string));

            foreach (var data in datas)
                dt.Rows.Add(data.Id, data.Content);

            DataGridView_Info.DataSource = dt;
        }

    }


}

