namespace Park_Bahçe
{
    partial class Form_SatinAlma
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_MalzemeTip = new System.Windows.Forms.ComboBox();
            this.textBox_miktar = new System.Windows.Forms.TextBox();
            this.textBox_birimFiyat = new System.Windows.Forms.TextBox();
            this.textBox_toplamFiyat = new System.Windows.Forms.TextBox();
            this.dateTimePicker_tarih = new System.Windows.Forms.DateTimePicker();
            this.comboBox_personel = new System.Windows.Forms.ComboBox();
            this.button_satinAl = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satın Alınacak Malzeme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miktar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birim Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toplam Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Satın Alma Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "İşlemi Yapan Personel:";
            // 
            // comboBox_MalzemeTip
            // 
            this.comboBox_MalzemeTip.FormattingEnabled = true;
            this.comboBox_MalzemeTip.Location = new System.Drawing.Point(141, 12);
            this.comboBox_MalzemeTip.Name = "comboBox_MalzemeTip";
            this.comboBox_MalzemeTip.Size = new System.Drawing.Size(187, 21);
            this.comboBox_MalzemeTip.TabIndex = 6;
            // 
            // textBox_miktar
            // 
            this.textBox_miktar.Location = new System.Drawing.Point(141, 39);
            this.textBox_miktar.Name = "textBox_miktar";
            this.textBox_miktar.Size = new System.Drawing.Size(100, 20);
            this.textBox_miktar.TabIndex = 7;
            this.textBox_miktar.TextChanged += new System.EventHandler(this.textBox_miktar_TextChanged);
            // 
            // textBox_birimFiyat
            // 
            this.textBox_birimFiyat.Location = new System.Drawing.Point(141, 65);
            this.textBox_birimFiyat.Name = "textBox_birimFiyat";
            this.textBox_birimFiyat.Size = new System.Drawing.Size(100, 20);
            this.textBox_birimFiyat.TabIndex = 8;
            this.textBox_birimFiyat.TextChanged += new System.EventHandler(this.textBox_birimFiyat_TextChanged);
            // 
            // textBox_toplamFiyat
            // 
            this.textBox_toplamFiyat.Location = new System.Drawing.Point(141, 91);
            this.textBox_toplamFiyat.Name = "textBox_toplamFiyat";
            this.textBox_toplamFiyat.ReadOnly = true;
            this.textBox_toplamFiyat.Size = new System.Drawing.Size(100, 20);
            this.textBox_toplamFiyat.TabIndex = 9;
            // 
            // dateTimePicker_tarih
            // 
            this.dateTimePicker_tarih.CustomFormat = "dd MMMM yyyy ";
            this.dateTimePicker_tarih.Location = new System.Drawing.Point(141, 117);
            this.dateTimePicker_tarih.Name = "dateTimePicker_tarih";
            this.dateTimePicker_tarih.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker_tarih.TabIndex = 10;
            // 
            // comboBox_personel
            // 
            this.comboBox_personel.FormattingEnabled = true;
            this.comboBox_personel.Location = new System.Drawing.Point(141, 143);
            this.comboBox_personel.Name = "comboBox_personel";
            this.comboBox_personel.Size = new System.Drawing.Size(187, 21);
            this.comboBox_personel.TabIndex = 11;
            // 
            // button_satinAl
            // 
            this.button_satinAl.Location = new System.Drawing.Point(253, 170);
            this.button_satinAl.Name = "button_satinAl";
            this.button_satinAl.Size = new System.Drawing.Size(75, 23);
            this.button_satinAl.TabIndex = 12;
            this.button_satinAl.Text = "Satın Al";
            this.button_satinAl.UseVisualStyleBackColor = true;
            this.button_satinAl.Click += new System.EventHandler(this.button_satinAl_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.Location = new System.Drawing.Point(172, 170);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(75, 23);
            this.button_iptal.TabIndex = 13;
            this.button_iptal.Text = "İptal";
            this.button_iptal.UseVisualStyleBackColor = true;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // Form_SatinAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 207);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_satinAl);
            this.Controls.Add(this.comboBox_personel);
            this.Controls.Add(this.dateTimePicker_tarih);
            this.Controls.Add(this.textBox_toplamFiyat);
            this.Controls.Add(this.textBox_birimFiyat);
            this.Controls.Add(this.textBox_miktar);
            this.Controls.Add(this.comboBox_MalzemeTip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_SatinAlma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satın Alma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_SatinAlma_FormClosed);
            this.Load += new System.EventHandler(this.Form_SatinAlma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_MalzemeTip;
        private System.Windows.Forms.TextBox textBox_miktar;
        private System.Windows.Forms.TextBox textBox_birimFiyat;
        private System.Windows.Forms.TextBox textBox_toplamFiyat;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tarih;
        private System.Windows.Forms.ComboBox comboBox_personel;
        private System.Windows.Forms.Button button_satinAl;
        private System.Windows.Forms.Button button_iptal;
    }
}