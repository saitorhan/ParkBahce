namespace Park_Bahçe
{
    partial class Form_MalzemeCikis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_malzeme = new System.Windows.Forms.ComboBox();
            this.numericUpDown_miktar = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_tarih = new System.Windows.Forms.DateTimePicker();
            this.comboBox_personel = new System.Windows.Forms.ComboBox();
            this.button_Kaydet = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_miktar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çıkış Yapılacak Malzeme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miktar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personel";
            // 
            // comboBox_malzeme
            // 
            this.comboBox_malzeme.FormattingEnabled = true;
            this.comboBox_malzeme.Location = new System.Drawing.Point(142, 6);
            this.comboBox_malzeme.Name = "comboBox_malzeme";
            this.comboBox_malzeme.Size = new System.Drawing.Size(179, 21);
            this.comboBox_malzeme.TabIndex = 4;
            this.comboBox_malzeme.SelectedIndexChanged += new System.EventHandler(this.comboBox_malzeme_SelectedIndexChanged);
            // 
            // numericUpDown_miktar
            // 
            this.numericUpDown_miktar.Location = new System.Drawing.Point(142, 33);
            this.numericUpDown_miktar.Name = "numericUpDown_miktar";
            this.numericUpDown_miktar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_miktar.TabIndex = 5;
            // 
            // dateTimePicker_tarih
            // 
            this.dateTimePicker_tarih.Location = new System.Drawing.Point(142, 59);
            this.dateTimePicker_tarih.Name = "dateTimePicker_tarih";
            this.dateTimePicker_tarih.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker_tarih.TabIndex = 6;
            // 
            // comboBox_personel
            // 
            this.comboBox_personel.FormattingEnabled = true;
            this.comboBox_personel.Location = new System.Drawing.Point(142, 85);
            this.comboBox_personel.Name = "comboBox_personel";
            this.comboBox_personel.Size = new System.Drawing.Size(179, 21);
            this.comboBox_personel.TabIndex = 7;
            // 
            // button_Kaydet
            // 
            this.button_Kaydet.Location = new System.Drawing.Point(246, 112);
            this.button_Kaydet.Name = "button_Kaydet";
            this.button_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.button_Kaydet.TabIndex = 8;
            this.button_Kaydet.Text = "Çıkış Ver";
            this.button_Kaydet.UseVisualStyleBackColor = true;
            this.button_Kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.Location = new System.Drawing.Point(165, 112);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(75, 23);
            this.button_iptal.TabIndex = 9;
            this.button_iptal.Text = "İptal";
            this.button_iptal.UseVisualStyleBackColor = true;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // Form_MalzemeCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 157);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_Kaydet);
            this.Controls.Add(this.comboBox_personel);
            this.Controls.Add(this.dateTimePicker_tarih);
            this.Controls.Add(this.numericUpDown_miktar);
            this.Controls.Add(this.comboBox_malzeme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_MalzemeCikis";
            this.Text = "Malzeme Çıkış";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_MalzemeCikis_FormClosed);
            this.Load += new System.EventHandler(this.Form_MalzemeCikis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_miktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_malzeme;
        private System.Windows.Forms.NumericUpDown numericUpDown_miktar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tarih;
        private System.Windows.Forms.ComboBox comboBox_personel;
        private System.Windows.Forms.Button button_Kaydet;
        private System.Windows.Forms.Button button_iptal;
    }
}