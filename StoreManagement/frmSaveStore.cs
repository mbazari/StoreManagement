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
    public partial class frmSaveStore : Form
    {
        bool edit;
        int id;
        public frmSaveStore(bool edit , int id)
        {
            InitializeComponent();
            this.edit = edit;
            this.id = id;
        }

        private void SaveStore_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                label3.Text = "ویرابش کالا";
            }
            else
            {
                label3.Text = "ثبت کالای جدید";
            }

            if (edit)
            {
                StoreDBEntities db = new StoreDBEntities();
               var store =  db.Stores.Find(id);
                textBox1.Text = store.Id.ToString();
                textBox2.Text = store.Name;
                richTextBox1.Text = store.Address;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("نام کالا را وارد نمایید.");
                return;
            }

            if (edit)
            {
                StoreDBEntities db = new StoreDBEntities();
                var store = db.Stores.Find(id);
                store.Name = textBox2.Text;
                store.Address = richTextBox1.Text;
                db.SaveChanges();
            }
            else
            {
                StoreDBEntities db = new StoreDBEntities();
                var store = new Store();
                store.Name = textBox2.Text;
                store.Address = richTextBox1.Text;
                db.Stores.Add(store);
                db.SaveChanges();
            }

            MessageBox.Show("تغییرات ثیت شده است.");

            this.Close();
        }
    }
}
