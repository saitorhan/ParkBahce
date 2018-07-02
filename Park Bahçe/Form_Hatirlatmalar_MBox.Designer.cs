namespace Park_Bahçe
{
    partial class Form_Hatirlatmalar_MBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_tarih = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_saat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_gorev = new System.Windows.Forms.TextBox();
            this.checkBox_yapildi = new System.Windows.Forms.CheckBox();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih";
            // 
            // dateTimePicker_tarih
            // 
            this.dateTimePicker_tarih.Location = new System.Drawing.Point(49, 12);
            this.dateTimePicker_tarih.Name = "dateTimePicker_tarih";
            this.dateTimePicker_tarih.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker_tarih.TabIndex = 1;
            // 
            // dateTimePicker_saat
            // 
            this.dateTimePicker_saat.CustomFormat = "HH:mm";
            this.dateTimePicker_saat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_saat.Location = new System.Drawing.Point(248, 12);
            this.dateTimePicker_saat.Name = "dateTimePicker_saat";
            this.dateTimePicker_saat.Size = new System.Drawing.Size(71, 20);
            this.dateTimePicker_saat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Görev";
            // 
            // textBox_gorev
            // 
            this.textBox_gorev.Location = new System.Drawing.Point(15, 53);
            this.textBox_gorev.Multiline = true;
            this.textBox_gorev.Name = "textBox_gorev";
            this.textBox_gorev.Size = new System.Drawing.Size(304, 125);
            this.textBox_gorev.TabIndex = 4;
            // 
            // checkBox_yapildi
            // 
            this.checkBox_yapildi.AutoSize = true;
            this.checkBox_yapildi.Location = new System.Drawing.Point(15, 184);
            this.checkBox_yapildi.Name = "checkBox_yapildi";
            this.checkBox_yapildi.Size = new System.Drawing.Size(57, 17);
            this.checkBox_yapildi.TabIndex = 5;
            this.checkBox_yapildi.Text = "Yapıldı";
            this.checkBox_yapildi.UseVisualStyleBackColor = true;
            // 
            // button_guncelle
            // 
            this.button_guncelle.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button_guncelle.Location = new System.Drawing.Point(244, 201);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(75, 23);
            this.button_guncelle.TabIndex = 7;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // button_sil
            // 
            this.button_sil.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button_sil.Location = new System.Drawing.Point(163, 201);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(75, 23);
            this.button_sil.TabIndex = 8;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.Location = new System.Drawing.Point(77, 201);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(80, 23);
            this.button_iptal.TabIndex = 9;
            this.button_iptal.Text = "İptal";
            this.button_iptal.UseVisualStyleBackColor = true;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // Form_Hatirlatmalar_MBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 236);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.checkBox_yapildi);
            this.Controls.Add(this.textBox_gorev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_saat);
            this.Controls.Add(this.dateTimePicker_tarih);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Hatirlatmalar_MBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hatırlatma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Hatirlatmalar_MBox_FormClosed);
            this.Load += new System.EventHandler(this.Form_Hatirlatmalar_MBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tarih;
        private System.Windows.Forms.DateTimePicker dateTimePicker_saat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_gorev;
        private System.Windows.Forms.CheckBox checkBox_yapildi;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_iptal;
    }
}