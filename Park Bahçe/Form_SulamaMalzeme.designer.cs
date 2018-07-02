namespace Park_Bahçe
{
    partial class Form_SulamaMalzeme
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_bilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_no = new System.Windows.Forms.Label();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_cap = new System.Windows.Forms.TextBox();
            this.textBox_uzunluk = new System.Windows.Forms.TextBox();
            this.textBox_adet = new System.Windows.Forms.TextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_malzemeler = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_malzemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_bilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 302);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(665, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_bilgi
            // 
            this.toolStripStatusLabel_bilgi.Name = "toolStripStatusLabel_bilgi";
            this.toolStripStatusLabel_bilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_no);
            this.panel1.Controls.Add(this.button_guncelle);
            this.panel1.Controls.Add(this.button_sil);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_cap);
            this.panel1.Controls.Add(this.textBox_uzunluk);
            this.panel1.Controls.Add(this.textBox_adet);
            this.panel1.Controls.Add(this.textBox_ad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(443, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 196);
            this.panel1.TabIndex = 2;
            // 
            // label_no
            // 
            this.label_no.AutoSize = true;
            this.label_no.Location = new System.Drawing.Point(52, 18);
            this.label_no.Name = "label_no";
            this.label_no.Size = new System.Drawing.Size(0, 13);
            this.label_no.TabIndex = 14;
            // 
            // button_guncelle
            // 
            this.button_guncelle.Location = new System.Drawing.Point(39, 142);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(75, 23);
            this.button_guncelle.TabIndex = 13;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(120, 142);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(75, 23);
            this.button_sil.TabIndex = 12;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Çap";
            // 
            // textBox_cap
            // 
            this.textBox_cap.Location = new System.Drawing.Point(55, 116);
            this.textBox_cap.Name = "textBox_cap";
            this.textBox_cap.Size = new System.Drawing.Size(140, 20);
            this.textBox_cap.TabIndex = 9;
            // 
            // textBox_uzunluk
            // 
            this.textBox_uzunluk.Location = new System.Drawing.Point(55, 90);
            this.textBox_uzunluk.Name = "textBox_uzunluk";
            this.textBox_uzunluk.Size = new System.Drawing.Size(140, 20);
            this.textBox_uzunluk.TabIndex = 8;
            // 
            // textBox_adet
            // 
            this.textBox_adet.Enabled = false;
            this.textBox_adet.Location = new System.Drawing.Point(55, 64);
            this.textBox_adet.Name = "textBox_adet";
            this.textBox_adet.Size = new System.Drawing.Size(140, 20);
            this.textBox_adet.TabIndex = 7;
            // 
            // textBox_ad
            // 
            this.textBox_ad.Enabled = false;
            this.textBox_ad.Location = new System.Drawing.Point(55, 38);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(140, 20);
            this.textBox_ad.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Uzunluk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No:";
            // 
            // dataGridView_malzemeler
            // 
            this.dataGridView_malzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_malzemeler.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_malzemeler.Name = "dataGridView_malzemeler";
            this.dataGridView_malzemeler.ReadOnly = true;
            this.dataGridView_malzemeler.Size = new System.Drawing.Size(425, 274);
            this.dataGridView_malzemeler.TabIndex = 3;
            this.dataGridView_malzemeler.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_malzemeler_CellMouseClick);
            // 
            // Form_SulamaMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 324);
            this.Controls.Add(this.dataGridView_malzemeler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form_SulamaMalzeme";
            this.Text = "Sulama Malzeme İşlemleri";
            this.Load += new System.EventHandler(this.Form_SulamaMalzeme_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_malzemeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_bilgi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_cap;
        private System.Windows.Forms.TextBox textBox_uzunluk;
        private System.Windows.Forms.TextBox textBox_adet;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_no;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_malzemeler;
    }
}