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
    public partial class frmMojodi : Form
    {
        public frmMojodi()
        {
            InitializeComponent();
        }

        private void frmMojodi_Load(object sender, EventArgs e)
        {
            var a = new StoreDBEntities();
            var store = a.Stores.ToList();
            comboBox1.DataSource = store;

            Search(null);
        }

        private void Search(int? storeId)
        {
            var db = new Data.StoreDBEntities();

            var items = db.DocumentItems.AsQueryable();

            if (storeId.HasValue)
            {
                items = items.Where(a => a.Document.StoreId == storeId.Value);
            }
            var x = items.Select(a => new MojodiInfo
            {
                KalaName = a.Kala.Name,
                StoreName = a.Document.Store.Name,
                Mojodi = a.Document.IsOutput ? -a.Amount : a.Amount
            }).ToList();

            
            var y = from a in x
                    group new { a.StoreName, a.KalaName, a.Mojodi } by a into grp
                    from b in grp
                    select new MojodiInfo
                    {
                        KalaName = grp.Key.KalaName,
                        StoreName = grp.Key.StoreName,
                        Mojodi = grp.Sum(a => a.Mojodi)
                    };

            dataGridView1.DataSource = y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = comboBox1.SelectedValue;
            Search((int)x);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    class MojodiInfo
    {
        public string KalaName { get; set; }
        public string StoreName { get; set; }
        public int Mojodi { get; set; }
    }
}
