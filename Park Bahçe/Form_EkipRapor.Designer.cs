namespace Park_Bahçe
{
    partial class Form_EkipRapor
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
            this.comboBox_ekip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_tarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_rapor = new System.Windows.Forms.TextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekip Adı";
            // 
            // comboBox_ekip
            // 
            this.comboBox_ekip.FormattingEnabled = true;
            this.comboBox_ekip.Location = new System.Drawing.Point(73, 12);
            this.comboBox_ekip.Name = "comboBox_ekip";
            this.comboBox_ekip.Size = new System.Drawing.Size(222, 21);
            this.comboBox_ekip.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih";
            // 
            // dateTimePicker_tarih
            // 
            this.dateTimePicker_tarih.CustomFormat = "dd MMMM yyyy  dddd   HH:mm";
            this.dateTimePicker_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_tarih.Location = new System.Drawing.Point(73, 39);
            this.dateTimePicker_tarih.Name = "dateTimePicker_tarih";
            this.dateTimePicker_tarih.Size = new System.Drawing.Size(222, 20);
            this.dateTimePicker_tarih.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rapor";
            // 
            // textBox_rapor
            // 
            this.textBox_rapor.Location = new System.Drawing.Point(73, 65);
            this.textBox_rapor.Multiline = true;
            this.textBox_rapor.Name = "textBox_rapor";
            this.textBox_rapor.Size = new System.Drawing.Size(222, 267);
            this.textBox_rapor.TabIndex = 5;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(220, 338);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(75, 23);
            this.button_kaydet.TabIndex = 6;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(139, 338);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(75, 23);
            this.button_sil.TabIndex = 7;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.Location = new System.Drawing.Point(58, 338);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(75, 23);
            this.button_iptal.TabIndex = 8;
            this.button_iptal.Text = "İptal";
            this.button_iptal.UseVisualStyleBackColor = true;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // Form_EkipRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 397);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.textBox_rapor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_tarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_ekip);
            this.Controls.Add(this.label1);
            this.Name = "Form_EkipRapor";
            this.Text = "Rapor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_EkipRapor_FormClosed);
            this.Load += new System.EventHandler(this.Form_EkipRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ekip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_rapor;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_iptal;
    }
}