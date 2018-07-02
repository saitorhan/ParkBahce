namespace Park_Bahçe
{
    partial class Form_EkipRaporlar
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
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_raporlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_raporlar
            // 
            this.listView_raporlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_raporlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_raporlar.FullRowSelect = true;
            this.listView_raporlar.GridLines = true;
            this.listView_raporlar.Location = new System.Drawing.Point(0, 0);
            this.listView_raporlar.Name = "listView_raporlar";
            this.listView_raporlar.Size = new System.Drawing.Size(846, 496);
            this.listView_raporlar.TabIndex = 0;
            this.listView_raporlar.UseCompatibleStateImageBehavior = false;
            this.listView_raporlar.View = System.Windows.Forms.View.Details;
            this.listView_raporlar.SelectedIndexChanged += new System.EventHandler(this.listView_raporlar_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "R. No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ekip";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rapor";
            this.columnHeader4.Width = 490;
            // 
            // Form_EkipRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 496);
            this.Controls.Add(this.listView_raporlar);
            this.Name = "Form_EkipRaporlar";
            this.Text = "Raporlar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_EkipRaporlar_FormClosed);
            this.Load += new System.EventHandler(this.Form_EkipRaporlar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_raporlar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}