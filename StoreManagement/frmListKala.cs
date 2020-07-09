using StoreManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class frmListKala : Form
    {
        public frmListKala()
        {
            InitializeComponent();

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == dataGridView1.Columns["DeleteKala"].Index)
            {
                 var data = (KalaInfo)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                StoreDBEntities db = new StoreDBEntities();

                if (db.DocumentItems.Any(a => a.KalaId == data.KalaId))
                {
                    MessageBox.Show("انبار در سند استفاده شده است.");
                    return;
                }
                var t = db.Kalas.Find(data.KalaId);
                db.Kalas.Remove(t);
                db.SaveChanges();
                LoadKala();

            }
            else if(e.ColumnIndex == dataGridView1.Columns["EditKala"].Index)
            {
                var data = (KalaInfo)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                var form = new frmSaveKala(true, data.KalaId);
                form.MdiParent = this.MdiParent;
                form.Show();
            }

           
        }

        private void ListKala_Load(object sender, EventArgs e)
        {
            LoadKala();
        }

        void LoadKala()
        {
            StoreDBEntities db = new StoreDBEntities();

            dataGridView1.DataSource =db.Kalas.Select(a=> new KalaInfo { KalaId=a.Id,KalaName=a.Name, StoreName= a.Store.Name }).ToList();
            dataGridView1.Refresh();
        }
    }

    class KalaInfo
    {
        public int KalaId { get; set; }
        public string KalaName { get; set; }
        public string StoreName { get; set; }
    }
}
