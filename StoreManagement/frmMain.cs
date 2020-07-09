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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void لیستکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();
            var f = new frmListKala();
            f.MdiParent = this;
            f.Show();
        }

        private void ثبتکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();
            var f = new frmSaveKala(false,0);
            f.MdiParent = this;
            f.Show();
        }

        private void لیستانبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();
            var f = new frmListStore();
            f.MdiParent = this;
            f.Show();
        }

        private void ثبتانبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();
            var f = new frmSaveStore(false,0);
            f.MdiParent = this;
            f.Show();
         
        }

        private void ورودیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();
            var f = new frmDocument(false,false,0);
            f.MdiParent = this;
            f.Show();
        }

        private void خروجیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();
            var f = new frmDocument(true, false, 0);
            f.MdiParent = this;
            f.Show();
        }

        private void لیستاسنادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();
            var f = new frmListDocument();
            f.MdiParent = this;
            f.Show();
        }

        void closeForms()
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
        }
    }
}
