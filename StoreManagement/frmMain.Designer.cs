namespace StoreManagement
{
    partial class frmMain
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
            this.کالاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستکالاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتکالاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستانبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتانبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتسندToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ورودیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // کالاToolStripMenuItem
            // 
            this.کالاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.لیستکالاToolStripMenuItem,
            this.ثبتکالاToolStripMenuItem});
            this.کالاToolStripMenuItem.Name = "کالاToolStripMenuItem";
            this.کالاToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.کالاToolStripMenuItem.Text = "کالا";
            // 
            // لیستکالاToolStripMenuItem
            // 
            this.لیستکالاToolStripMenuItem.Name = "لیستکالاToolStripMenuItem";
            this.لیستکالاToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.لیستکالاToolStripMenuItem.Text = "لیست کالا";
            // 
            // ثبتکالاToolStripMenuItem
            // 
            this.ثبتکالاToolStripMenuItem.Name = "ثبتکالاToolStripMenuItem";
            this.ثبتکالاToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ثبتکالاToolStripMenuItem.Text = "ثبت کالا";
            // 
            // انبارToolStripMenuItem
            // 
            this.انبارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.لیستانبارToolStripMenuItem,
            this.ثبتانبارToolStripMenuItem});
            this.انبارToolStripMenuItem.Name = "انبارToolStripMenuItem";
            this.انبارToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.انبارToolStripMenuItem.Text = "انبار";
            // 
            // لیستانبارToolStripMenuItem
            // 
            this.لیستانبارToolStripMenuItem.Name = "لیستانبارToolStripMenuItem";
            this.لیستانبارToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.لیستانبارToolStripMenuItem.Text = "لیست انبار";
            // 
            // ثبتانبارToolStripMenuItem
            // 
            this.ثبتانبارToolStripMenuItem.Name = "ثبتانبارToolStripMenuItem";
            this.ثبتانبارToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.ثبتانبارToolStripMenuItem.Text = "ثبت انبار";
            // 
            // ثبتسندToolStripMenuItem
            // 
            this.ثبتسندToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ورودیToolStripMenuItem,
            this.خروجیToolStripMenuItem});
            this.ثبتسندToolStripMenuItem.Name = "ثبتسندToolStripMenuItem";
            this.ثبتسندToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ثبتسندToolStripMenuItem.Text = "ثبت سند";
            // 
            // ورودیToolStripMenuItem
            // 
            this.ورودیToolStripMenuItem.Name = "ورودیToolStripMenuItem";
            this.ورودیToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ورودیToolStripMenuItem.Text = "ورودی";
            // 
            // خروجیToolStripMenuItem
            // 
            this.خروجیToolStripMenuItem.Name = "خروجیToolStripMenuItem";
            this.خروجیToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.خروجیToolStripMenuItem.Text = "خروجی";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کالاToolStripMenuItem,
            this.انبارToolStripMenuItem,
            this.ثبتسندToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت انبار";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem کالاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستکالاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتکالاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستانبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتانبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتسندToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ورودیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجیToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

