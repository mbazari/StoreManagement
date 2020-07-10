namespace StoreManagement
{
    partial class frmListKala
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KalaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditKala = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteKala = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KalaId,
            this.KalaName,
            this.StoreName,
            this.EditKala,
            this.DeleteKala});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 386);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KalaId
            // 
            this.KalaId.DataPropertyName = "KalaId";
            this.KalaId.HeaderText = "کد کالا";
            this.KalaId.Name = "KalaId";
            this.KalaId.ReadOnly = true;
            // 
            // KalaName
            // 
            this.KalaName.DataPropertyName = "KalaName";
            this.KalaName.HeaderText = "نام کالا";
            this.KalaName.Name = "KalaName";
            this.KalaName.ReadOnly = true;
            this.KalaName.Width = 200;
            // 
            // StoreName
            // 
            this.StoreName.DataPropertyName = "StoreName";
            this.StoreName.HeaderText = "نام انبار";
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            // 
            // EditKala
            // 
            this.EditKala.HeaderText = "";
            this.EditKala.Name = "EditKala";
            this.EditKala.ReadOnly = true;
            this.EditKala.Text = "ویرایش";
            // 
            // DeleteKala
            // 
            this.DeleteKala.HeaderText = "";
            this.DeleteKala.Name = "DeleteKala";
            this.DeleteKala.ReadOnly = true;
            this.DeleteKala.Text = "حذف";
            // 
            // frmListKala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 386);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmListKala";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ListKala";
            this.Load += new System.EventHandler(this.ListKala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewButtonColumn EditKala;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteKala;
    }
}