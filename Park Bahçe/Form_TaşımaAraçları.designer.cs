namespace Park_Bahçe
{
    partial class Form_TasimaAraclari
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
            this.dateTimePicker_tarih = new System.Windows.Forms.DateTimePicker();
            this.button_güncelle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_plaka = new System.Windows.Forms.TextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label_no = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_bilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView_malzemeler = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_personel = new System.Windows.Forms.ComboBox();
            this.panel_bilgiler.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_malzemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bilgiler
            // 
            this.panel_bilgiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_bilgiler.Controls.Add(this.comboBox_personel);
            this.panel_bilgiler.Controls.Add(this.button1);
            this.panel_bilgiler.Controls.Add(this.dateTimePicker_tarih);
            this.panel_bilgiler.Controls.Add(this.button_güncelle);
            this.panel_bilgiler.Controls.Add(this.button_sil);
            this.panel_bilgiler.Controls.Add(this.label6);
            this.panel_bilgiler.Controls.Add(this.textBox_plaka);
            this.panel_bilgiler.Controls.Add(this.textBox_ad);
            this.panel_bilgiler.Controls.Add(this.label_no);
            this.panel_bilgiler.Controls.Add(this.label4);
            this.panel_bilgiler.Controls.Add(this.label3);
            this.panel_bilgiler.Controls.Add(this.label2);
            this.panel_bilgiler.Controls.Add(this.label1);
            this.panel_bilgiler.Location = new System.Drawing.Point(184, 77);
            this.panel_bilgiler.Name = "panel_bilgiler";
            this.panel_bilgiler.Size = new System.Drawing.Size(310, 182);
            this.panel_bilgiler.TabIndex = 1;
            // 
            // dateTimePicker_tarih
            // 
            this.dateTimePicker_tarih.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_tarih.Location = new System.Drawing.Point(98, 73);
            this.dateTimePicker_tarih.Name = "dateTimePicker_tarih";
            this.dateTimePicker_tarih.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker_tarih.TabIndex = 13;
            // 
            // button_güncelle
            // 
            this.button_güncelle.Location = new System.Drawing.Point(152, 137);
            this.button_güncelle.Name = "button_güncelle";
            this.button_güncelle.Size = new System.Drawing.Size(75, 23);
            this.button_güncelle.TabIndex = 12;
            this.button_güncelle.Text = "Güncelle";
            this.button_güncelle.UseVisualStyleBackColor = true;
            this.button_güncelle.Click += new System.EventHandler(this.button_güncelle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(71, 137);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(75, 23);
            this.button_sil.TabIndex = 11;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Şuan Kimde:";
            // 
            // textBox_plaka
            // 
            this.textBox_plaka.Location = new System.Drawing.Point(98, 46);
            this.textBox_plaka.Name = "textBox_plaka";
            this.textBox_plaka.Size = new System.Drawing.Size(178, 20);
            this.textBox_plaka.TabIndex = 6;
            // 
            // textBox_ad
            // 
            this.textBox_ad.Enabled = false;
            this.textBox_ad.Location = new System.Drawing.Point(98, 22);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(178, 20);
            this.textBox_ad.TabIndex = 5;
            // 
            // label_no
            // 
            this.label_no.AutoSize = true;
            this.label_no.Location = new System.Drawing.Point(95, 6);
            this.label_no.Name = "label_no";
            this.label_no.Size = new System.Drawing.Size(16, 13);
            this.label_no.TabIndex = 4;
            this.label_no.Text = " ..";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Satın Alma Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_bilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(680, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_bilgi
            // 
            this.toolStripStatusLabel_bilgi.Name = "toolStripStatusLabel_bilgi";
            this.toolStripStatusLabel_bilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridView_malzemeler
            // 
            this.dataGridView_malzemeler.AllowUserToAddRows = false;
            this.dataGridView_malzemeler.AllowUserToDeleteRows = false;
            this.dataGridView_malzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_malzemeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_malzemeler.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_malzemeler.Name = "dataGridView_malzemeler";
            this.dataGridView_malzemeler.ReadOnly = true;
            this.dataGridView_malzemeler.Size = new System.Drawing.Size(680, 323);
            this.dataGridView_malzemeler.TabIndex = 3;
            this.dataGridView_malzemeler.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_malzemeler_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_personel
            // 
            this.comboBox_personel.FormattingEnabled = true;
            this.comboBox_personel.Location = new System.Drawing.Point(98, 102);
            this.comboBox_personel.Name = "comboBox_personel";
            this.comboBox_personel.Size = new System.Drawing.Size(178, 21);
            this.comboBox_personel.TabIndex = 15;
            // 
            // Form_TasimaAraclari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(680, 345);
            this.Controls.Add(this.dataGridView_malzemeler);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel_bilgiler);
            this.Name = "Form_TasimaAraclari";
            this.Text = "Taşıma Araç İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_TaşımaAraçları_FormClosed);
            this.Load += new System.EventHandler(this.Form_TaşımaAraçları_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_plaka;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_bilgi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tarih;
        private System.Windows.Forms.DataGridView dataGridView_malzemeler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_personel;
    }
}