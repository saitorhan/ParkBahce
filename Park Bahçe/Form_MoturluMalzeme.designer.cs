namespace Park_Bahçe
{
    partial class Form_MoturluMalzeme
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
            this.panel_bilgiler = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_güncelle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.dateTimePicker_tarih = new System.Windows.Forms.DateTimePicker();
            this.textBox_adet = new System.Windows.Forms.TextBox();
            this.textBox_ortVerim = new System.Windows.Forms.TextBox();
            this.label_NO = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_bilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_ = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView_malzemeler = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_silmeTarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_bilgiler.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_malzemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bilgiler
            // 
            this.panel_bilgiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_bilgiler.Controls.Add(this.dateTimePicker_silmeTarih);
            this.panel_bilgiler.Controls.Add(this.label6);
            this.panel_bilgiler.Controls.Add(this.button1);
            this.panel_bilgiler.Controls.Add(this.button_güncelle);
            this.panel_bilgiler.Controls.Add(this.button_sil);
            this.panel_bilgiler.Controls.Add(this.button_ekle);
            this.panel_bilgiler.Controls.Add(this.dateTimePicker_tarih);
            this.panel_bilgiler.Controls.Add(this.textBox_adet);
            this.panel_bilgiler.Controls.Add(this.textBox_ortVerim);
            this.panel_bilgiler.Controls.Add(this.label_NO);
            this.panel_bilgiler.Controls.Add(this.textBox_ad);
            this.panel_bilgiler.Controls.Add(this.label5);
            this.panel_bilgiler.Controls.Add(this.label4);
            this.panel_bilgiler.Controls.Add(this.label3);
            this.panel_bilgiler.Controls.Add(this.label2);
            this.panel_bilgiler.Controls.Add(this.label1);
            this.panel_bilgiler.Location = new System.Drawing.Point(71, 49);
            this.panel_bilgiler.Name = "panel_bilgiler";
            this.panel_bilgiler.Size = new System.Drawing.Size(245, 234);
            this.panel_bilgiler.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_güncelle
            // 
            this.button_güncelle.Location = new System.Drawing.Point(6, 164);
            this.button_güncelle.Name = "button_güncelle";
            this.button_güncelle.Size = new System.Drawing.Size(75, 23);
            this.button_güncelle.TabIndex = 12;
            this.button_güncelle.Text = "Güncelle";
            this.button_güncelle.UseVisualStyleBackColor = true;
            this.button_güncelle.Click += new System.EventHandler(this.button_güncelle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(85, 164);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(78, 23);
            this.button_sil.TabIndex = 11;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(6, 193);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(236, 23);
            this.button_ekle.TabIndex = 10;
            this.button_ekle.Text = "Yeni Malzeme Kaydı Al";
            this.button_ekle.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_tarih
            // 
            this.dateTimePicker_tarih.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_tarih.Location = new System.Drawing.Point(93, 81);
            this.dateTimePicker_tarih.Name = "dateTimePicker_tarih";
            this.dateTimePicker_tarih.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker_tarih.TabIndex = 9;
            // 
            // textBox_adet
            // 
            this.textBox_adet.Enabled = false;
            this.textBox_adet.Location = new System.Drawing.Point(93, 133);
            this.textBox_adet.Name = "textBox_adet";
            this.textBox_adet.Size = new System.Drawing.Size(134, 20);
            this.textBox_adet.TabIndex = 8;
            // 
            // textBox_ortVerim
            // 
            this.textBox_ortVerim.Location = new System.Drawing.Point(93, 55);
            this.textBox_ortVerim.Name = "textBox_ortVerim";
            this.textBox_ortVerim.Size = new System.Drawing.Size(134, 20);
            this.textBox_ortVerim.TabIndex = 7;
            // 
            // label_NO
            // 
            this.label_NO.AutoSize = true;
            this.label_NO.Location = new System.Drawing.Point(89, 9);
            this.label_NO.Name = "label_NO";
            this.label_NO.Size = new System.Drawing.Size(0, 13);
            this.label_NO.TabIndex = 6;
            // 
            // textBox_ad
            // 
            this.textBox_ad.Enabled = false;
            this.textBox_ad.Location = new System.Drawing.Point(93, 28);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(134, 20);
            this.textBox_ad.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Toplam Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Satın Alma Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ort Verim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_bilgi,
            this.toolStripStatusLabel_});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(418, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_bilgi
            // 
            this.toolStripStatusLabel_bilgi.Name = "toolStripStatusLabel_bilgi";
            this.toolStripStatusLabel_bilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel_
            // 
            this.toolStripStatusLabel_.Name = "toolStripStatusLabel_";
            this.toolStripStatusLabel_.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridView_malzemeler
            // 
            this.dataGridView_malzemeler.AllowUserToAddRows = false;
            this.dataGridView_malzemeler.AllowUserToDeleteRows = false;
            this.dataGridView_malzemeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_malzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_malzemeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_malzemeler.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_malzemeler.Name = "dataGridView_malzemeler";
            this.dataGridView_malzemeler.ReadOnly = true;
            this.dataGridView_malzemeler.Size = new System.Drawing.Size(418, 398);
            this.dataGridView_malzemeler.TabIndex = 3;
            this.dataGridView_malzemeler.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_malzemeler_CellMouseClick);
            // 
            // dateTimePicker_silmeTarih
            // 
            this.dateTimePicker_silmeTarih.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker_silmeTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_silmeTarih.Location = new System.Drawing.Point(93, 107);
            this.dateTimePicker_silmeTarih.Name = "dateTimePicker_silmeTarih";
            this.dateTimePicker_silmeTarih.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker_silmeTarih.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Silme Alma Tarih:";
            // 
            // Form_MoturluMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 420);
            this.Controls.Add(this.dataGridView_malzemeler);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel_bilgiler);
            this.Name = "Form_MoturluMalzeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motorlu Malzeme İşlemleri";
            this.Load += new System.EventHandler(this.Form_MoturluMalzeme_Load);
            this.panel_bilgiler.ResumeLayout(false);
            this.panel_bilgiler.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_malzemeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_bilgiler;
        private System.Windows.Forms.Button button_güncelle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tarih;
        private System.Windows.Forms.TextBox textBox_adet;
        private System.Windows.Forms.TextBox textBox_ortVerim;
        private System.Windows.Forms.Label label_NO;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_bilgi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_;
        private System.Windows.Forms.DataGridView dataGridView_malzemeler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_silmeTarih;
        private System.Windows.Forms.Label label6;
    }
}