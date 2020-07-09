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
    public partial class frmSaveKala : Form
    {
        bool edit;
        int id;
        public frmSaveKala(bool edit, int id)
        {
            InitializeComponent();
            this.edit = edit;
            this.id = id;

           
        }

        private void SaveKala_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                label3.Text = "ویرابش کالا";
            }
            else
            {
                label3.Text = "ثبت کالای جدید";
            }

            StoreDBEntities a = new StoreDBEntities();
            var store = a.Stores.ToList();
            comboBox1.DataSource = store;

            if (edit)
            {
                Kala kala = a.Kalas.Find(id);

                textBox1.Text = kala.Id.ToString();
                textBox2.Text = kala.Name;
                comboBox1.SelectedValue = kala.StoreId;
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("نام کالا را وارد نمایید.");
                return;
            }

            StoreDBEntities a = new StoreDBEntities();
            if (edit)
            {
                Kala kala = a.Kalas.Find(id);
                kala.Name = textBox2.Text;
                kala.StoreId = (int)comboBox1.SelectedValue;
                a.SaveChanges();

            }
            else
            {
                Kala kala = new Kala();
                kala.Name = textBox2.Text;
                kala.StoreId = (int)comboBox1.SelectedValue;
                a.Kalas.Add(kala);
                a.SaveChanges();
            }

            MessageBox.Show("تغییرات ثیت شده است.");

            this.Close();
        }
    }
}
