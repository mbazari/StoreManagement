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
using System.Globalization;

namespace StoreManagement
{
    public partial class frmDocument : Form
    {
        bool isOutput;
        bool view;
        int documentId;
        public frmDocument(bool isOutput, bool view, int documentId)
        {
            InitializeComponent();
            this.isOutput = isOutput;
            this.view = view;
            this.documentId = documentId;
        }

        private void frmDocument_Load(object sender, EventArgs e)
        {
            var db = new StoreDBEntities();
            comboBox1.DataSource = db.Stores.ToList();

            if (isOutput)
            {
                label2.Text = "خروجی";
            }
            else
            {
                label2.Text = "ورودی";
            }

            if (view)
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

                button1.Visible = false;
                comboBox1.Enabled = false;

                var doc = db.Documents.Include(a=> a.DocumentItems).First(a => a.Id == documentId);

                comboBox1.SelectedValue = doc.StoreId;
                if (doc.IsOutput)
                {
                    label2.Text = "خروجی";
                }
                else
                {
                    label2.Text = "ورودی";
                }
                textBox1.Text = doc.Date;
                textBox2.Text = doc.Id.ToString();
                dataGridView1.DataSource = doc.DocumentItems.ToList();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                comboBox1.Enabled = true;
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                comboBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var db = new StoreDBEntities();
            var doc = new Document();
            doc.StoreId = (int)comboBox1.SelectedValue;

            var calender = new PersianCalendar();
            var d1 = DateTime.Now;
            doc.Date = calender.GetYear(d1).ToString() + calender.GetMonth(d1).ToString() + calender.GetDayOfMonth(d1).ToString();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var r = dataGridView1.Rows[i];
                var item = new DocumentItem();
                item.KalaId = (int)r.Cells["KalaName"].Value;
                item.Amount = (int)r.Cells["Amount"].Value;
                item.Description = (string)r.Cells["Description"].Value;

                db.DocumentItems.Add(item);
            }
            db.Documents.Add(doc);
            db.SaveChanges();

            MessageBox.Show("سند ثبت شده است");
            this.Close();
        }
    }
}
