namespace Park_Bahçe
{
    partial class Form_Hatirlatmalar
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
            this.listView_gorev = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.butunGorevlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapilmamisGorevlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapilmisGorevlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniGorevEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_gorev
            // 
            this.listView_gorev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_gorev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_gorev.FullRowSelect = true;
            this.listView_gorev.GridLines = true;
            this.listView_gorev.Location = new System.Drawing.Point(0, 24);
            this.listView_gorev.Name = "listView_gorev";
            this.listView_gorev.Size = new System.Drawing.Size(825, 465);
            this.listView_gorev.TabIndex = 0;
            this.listView_gorev.UseCompatibleStateImageBehavior = false;
            this.listView_gorev.View = System.Windows.Forms.View.Details;
            this.listView_gorev.SelectedIndexChanged += new System.EventHandler(this.listView_gorev_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tarih";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Görev";
            this.columnHeader2.Width = 570;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Durum";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "S. No";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butunGorevlerToolStripMenuItem,
            this.yapilmamisGorevlerToolStripMenuItem,
            this.yapilmisGorevlerToolStripMenuItem,
            this.yeniGorevEkleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // butunGorevlerToolStripMenuItem
            // 
            this.butunGorevlerToolStripMenuItem.Name = "butunGorevlerToolStripMenuItem";
            this.butunGorevlerToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.butunGorevlerToolStripMenuItem.Text = "Bütün Görevler";
            this.butunGorevlerToolStripMenuItem.Click += new System.EventHandler(this.butunGorevlerToolStripMenuItem_Click);
            // 
            // yapilmamisGorevlerToolStripMenuItem
            // 
            this.yapilmamisGorevlerToolStripMenuItem.Name = "yapilmamisGorevlerToolStripMenuItem";
            this.yapilmamisGorevlerToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.yapilmamisGorevlerToolStripMenuItem.Text = "Yapılmamış Görevler";
            this.yapilmamisGorevlerToolStripMenuItem.Click += new System.EventHandler(this.yapilmamisGorevlerToolStripMenuItem_Click);
            // 
            // yapilmisGorevlerToolStripMenuItem
            // 
            this.yapilmisGorevlerToolStripMenuItem.Name = "yapilmisGorevlerToolStripMenuItem";
            this.yapilmisGorevlerToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.yapilmisGorevlerToolStripMenuItem.Text = "Yapılmış Görevler";
            this.yapilmisGorevlerToolStripMenuItem.Click += new System.EventHandler(this.yapilmisGorevlerToolStripMenuItem_Click);
            // 
            // yeniGorevEkleToolStripMenuItem
            // 
            this.yeniGorevEkleToolStripMenuItem.Name = "yeniGorevEkleToolStripMenuItem";
            this.yeniGorevEkleToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.yeniGorevEkleToolStripMenuItem.Text = "Yeni Görev Ekle";
            this.yeniGorevEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniGorevEkleToolStripMenuItem_Click);
            // 
            // Form_Hatirlatmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 489);
            this.Controls.Add(this.listView_gorev);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Hatirlatmalar";
            this.Text = "Hatırlatmalar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Hatirlatmalar_FormClosed);
            this.Load += new System.EventHandler(this.Form_Hatirlatmalar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_gorev;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem butunGorevlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapilmamisGorevlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapilmisGorevlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniGorevEkleToolStripMenuItem;

    }
}