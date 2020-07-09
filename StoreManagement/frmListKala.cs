﻿using StoreManagement.Data;
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
                 var data = (Kala)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                StoreDBEntities db = new StoreDBEntities();

                if (db.DocumentItems.Any(a => a.KalaId == data.Id))
                {
                    MessageBox.Show("انبار در سند استفاده شده است.");
                    return;
                }

                db.Kalas.Remove(data);
                db.SaveChanges();
                LoadKala();

            }
            else if(e.ColumnIndex == dataGridView1.Columns["EditKala"].Index)
            {
                var data = (Kala)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                var form = new frmSaveKala(true, data.Id);
                form.MdiParent = this.MdiParent;
            }

           
        }

        private void ListKala_Load(object sender, EventArgs e)
        {
            LoadKala();
        }

        void LoadKala()
        {
            StoreDBEntities db = new StoreDBEntities();

            dataGridView1.DataSource =db.Kalas.Select(a=> new {KalaId=a.Id,KalaName=a.Name, StoreName= a.Store.Name }).ToList();
            dataGridView1.Refresh();
        }
    }
}