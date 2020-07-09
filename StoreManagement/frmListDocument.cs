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
using System.Data.Entity;

namespace StoreManagement
{
    public partial class frmListDocument : Form
    {
        public frmListDocument()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new StoreDBEntities();
            var s = db.DocumentItems.Include(a => a.Document.Store)
                .Include(a => a.Kala).ToList()
                .Select(a => new {
                    DocumentId = a.DocumentId,
                    KalaName = a.Kala.Name,
                    StoreName = a.Document.Store.Name,
                    Amount = a.Amount,
                    Description = a.Description,
                    IsOutput = a.Document.IsOutput,
                    IsOutputText = a.Document.IsOutput ? "خروجی" : "ورودی"
                });

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                s = s.Where(a => a.DocumentId.ToString() == textBox1.Text);
            }

            if (radioButton1.Checked)
            {
                s = s.Where(a => a.IsOutput == false);
            }
            else if (radioButton2.Checked)
            {
                s = s.Where(a => a.IsOutput == true);
            }

            dataGridView1.DataSource = s;
        }

        private void frmListDocument_Load(object sender, EventArgs e)
        {
            var db = new StoreDBEntities();
            var s = db.DocumentItems.Include(a => a.Document.Store)
                .Include(a => a.Kala).ToList()
                .Select(a => new DocumentInfo
                {
                    DocumentId = a.DocumentId,
                    KalaName = a.Kala.Name,
                    StoreName = a.Document.Store.Name,
                    Amount = a.Amount,
                    Description = a.Description,
                    IsOutput = a.Document.IsOutput,
                    IsOutputText = a.Document.IsOutput ? "خروجی" : "ورودی"
                });

            dataGridView1.DataSource = s;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["View"].Index)
            {
                var data = (DocumentInfo)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                var f = new frmDocument(data.IsOutput, true, data.DocumentId);
                f.MdiParent = this.MdiParent;
                f.Show();

            }
        }
    }

    class DocumentInfo
    {
        public int DocumentId { get; set; }
        public string KalaName { get; set; }
        public string StoreName { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public string IsOutputText { get; set; }
        public bool IsOutput { get; set; }
    }
}
