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
            var f = new frmListKala();
            ShowForm(f);
        }

        private void ثبتکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmSaveKala(false,0);
            ShowForm(f);

        }

        private void لیستانبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmListStore();
            ShowForm(f);
        }

        private void ثبتانبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var f = new frmSaveStore(false,0);
            ShowForm(f);
        }

        private void ورودیToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var f = new frmDocument(false,false,0);
            ShowForm(f);

        }

        private void خروجیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDocument(true, false, 0);
            ShowForm(f);
        }

        private void لیستاسنادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmListDocument();
            ShowForm(f);
           
        }

        void ShowForm(Form f)
        {
            
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
           
        }
    }
}
