namespace Park_Bahçe
{
    partial class Form_Izin
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
            this.textBox_kimlikNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_adSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_gorevYer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_ayrilmaTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_izinSayisi = new System.Windows.Forms.TextBox();
            this.dateTimePicker_donus = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_ucretliMi = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_izinNeden = new System.Windows.Forms.TextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_bilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_kimlikNo
            // 
            this.textBox_kimlikNo.Location = new System.Drawing.Point(131, 16);
            this.textBox_kimlikNo.MaxLength = 11;
            this.textBox_kimlikNo.Name = "textBox_kimlikNo";
            this.textBox_kimlikNo.Size = new System.Drawing.Size(185, 20);
            this.textBox_kimlikNo.TabIndex = 0;
            this.textBox_kimlikNo.TextChanged += new System.EventHandler(this.textBox_kimlikNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kimlik Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı Soyadı:";
            // 
            // label_adSoyad
            // 
            this.label_adSoyad.AutoSize = true;
            this.label_adSoyad.Location = new System.Drawing.Point(128, 61);
            this.label_adSoyad.Name = "label_adSoyad";
            this.label_adSoyad.Size = new System.Drawing.Size(0, 13);
            this.label_adSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Görev Yeri:";
            // 
            // label_gorevYer
            // 
            this.label_gorevYer.AutoSize = true;
            this.label_gorevYer.Location = new System.Drawing.Point(128, 84);
            this.label_gorevYer.Name = "label_gorevYer";
            this.label_gorevYer.Size = new System.Drawing.Size(0, 13);
            this.label_gorevYer.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "İzne Ayrılma Tarihi:";
            // 
            // dateTimePicker_ayrilmaTarih
            // 
            this.dateTimePicker_ayrilmaTarih.Location = new System.Drawing.Point(131, 104);
            this.dateTimePicker_ayrilmaTarih.Name = "dateTimePicker_ayrilmaTarih";
            this.dateTimePicker_ayrilmaTarih.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker_ayrilmaTarih.TabIndex = 7;
            this.dateTimePicker_ayrilmaTarih.ValueChanged += new System.EventHandler(this.dateTimePicker_ayrilmaTarih_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "İzin Gün Sayısı:";
            // 
            // textBox_izinSayisi
            // 
            this.textBox_izinSayisi.Location = new System.Drawing.Point(131, 135);
            this.textBox_izinSayisi.Name = "textBox_izinSayisi";
            this.textBox_izinSayisi.Size = new System.Drawing.Size(100, 20);
            this.textBox_izinSayisi.TabIndex = 9;
            this.textBox_izinSayisi.TextChanged += new System.EventHandler(this.textBox_izinSayisi_TextChanged);
            // 
            // dateTimePicker_donus
            // 
            this.dateTimePicker_donus.Location = new System.Drawing.Point(131, 161);
            this.dateTimePicker_donus.Name = "dateTimePicker_donus";
            this.dateTimePicker_donus.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker_donus.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "İzinden Dönme Tarihi:";
            // 
            // checkBox_ucretliMi
            // 
            this.checkBox_ucretliMi.AutoSize = true;
            this.checkBox_ucretliMi.Checked = true;
            this.checkBox_ucretliMi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ucretliMi.Location = new System.Drawing.Point(131, 187);
            this.checkBox_ucretliMi.Name = "checkBox_ucretliMi";
            this.checkBox_ucretliMi.Size = new System.Drawing.Size(75, 17);
            this.checkBox_ucretliMi.TabIndex = 12;
            this.checkBox_ucretliMi.Text = "Ücretli İzin";
            this.checkBox_ucretliMi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "İzne Ayrılma Nedeni:";
            // 
            // textBox_izinNeden
            // 
            this.textBox_izinNeden.Location = new System.Drawing.Point(131, 216);
            this.textBox_izinNeden.MaxLength = 199;
            this.textBox_izinNeden.Multiline = true;
            this.textBox_izinNeden.Name = "textBox_izinNeden";
            this.textBox_izinNeden.Size = new System.Drawing.Size(185, 109);
            this.textBox_izinNeden.TabIndex = 14;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(241, 331);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(75, 23);
            this.button_kaydet.TabIndex = 15;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.Location = new System.Drawing.Point(156, 331);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(75, 23);
            this.button_iptal.TabIndex = 16;
            this.button_iptal.Text = "İptal";
            this.button_iptal.UseVisualStyleBackColor = true;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_bilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(362, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_bilgi
            // 
            this.toolStripStatusLabel_bilgi.Name = "toolStripStatusLabel_bilgi";
            this.toolStripStatusLabel_bilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // Form_Izin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 448);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.textBox_izinNeden);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox_ucretliMi);
            this.Controls.Add(this.dateTimePicker_donus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_izinSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_ayrilmaTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_gorevYer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_adSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_kimlikNo);
            this.Name = "Form_Izin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Izin_FormClosed);
            this.Load += new System.EventHandler(this.Form_Izin_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_kimlikNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_adSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_gorevYer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ayrilmaTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_izinSayisi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_donus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_ucretliMi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_izinNeden;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_bilgi;
    }
}