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
    public partial class frmListStore : Form
    {
        public frmListStore()
        {
            InitializeComponent();
        }

        private void ListStore_Load(object sender, EventArgs e)
        {
            LoadStore();
        }

        void LoadStore()
        {
            var db = new StoreDBEntities();
            dataGridView1.DataSource = db.Stores.Select(a => new { StoreId = a.Id, StoreName = a.Name, StoreAddress = a.Address }).ToList();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["DeleteStore"].Index)
            {
                var data = (Store)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                StoreDBEntities db = new StoreDBEntities();
                if (db.Documents.Any(a => a.StoreId == data.Id))
                {
                    MessageBox.Show("انبار در سند استفاده شده است.");
                    return;
                }

                if (db.Kalas.Any(a => a.StoreId == data.Id))
                {
                    MessageBox.Show("انبار در کالا استفاده شده است.");
                    return;
                }

                db.Stores.Remove(data);
                db.SaveChanges();
                LoadStore();

            }
            else if (e.ColumnIndex == dataGridView1.Columns["EditStore"].Index)
            {
                var data = (Kala)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                var form = new frmSaveStore(true, data.Id);
                form.MdiParent = this.MdiParent;
            }
        }
    }
}
