namespace Park_Bahçe
{
    partial class Form_MalzemeTipi
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
            this.label_ = new System.Windows.Forms.Label();
            this.comboBox_ad = new System.Windows.Forms.ComboBox();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_bilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBox_listelemeSecenegi = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_aktiflik = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Location = new System.Drawing.Point(12, 29);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(71, 13);
            this.label_.TabIndex = 0;
            this.label_.Text = "Malzeme Ad :";
            // 
            // comboBox_ad
            // 
            this.comboBox_ad.FormattingEnabled = true;
            this.comboBox_ad.Location = new System.Drawing.Point(104, 27);
            this.comboBox_ad.Name = "comboBox_ad";
            this.comboBox_ad.Size = new System.Drawing.Size(149, 21);
            this.comboBox_ad.TabIndex = 1;
            this.comboBox_ad.SelectedIndexChanged += new System.EventHandler(this.comboBox_ad_SelectedIndexChanged);
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(15, 133);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(154, 23);
            this.button_ekle.TabIndex = 2;
            this.button_ekle.Text = "Yeni Malzeme Tipi Ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seçilen Malzeme:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_bilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 165);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(304, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_bilgi
            // 
            this.toolStripStatusLabel_bilgi.Name = "toolStripStatusLabel_bilgi";
            this.toolStripStatusLabel_bilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // checkBox_listelemeSecenegi
            // 
            this.checkBox_listelemeSecenegi.AutoSize = true;
            this.checkBox_listelemeSecenegi.Location = new System.Drawing.Point(104, 54);
            this.checkBox_listelemeSecenegi.Name = "checkBox_listelemeSecenegi";
            this.checkBox_listelemeSecenegi.Size = new System.Drawing.Size(152, 17);
            this.checkBox_listelemeSecenegi.TabIndex = 8;
            this.checkBox_listelemeSecenegi.Text = "Kullanılmayanları da Göster";
            this.checkBox_listelemeSecenegi.UseVisualStyleBackColor = true;
            this.checkBox_listelemeSecenegi.CheckedChanged += new System.EventHandler(this.checkBox_listelemeSecenegi_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kullanma Durumu";
            // 
            // comboBox_aktiflik
            // 
            this.comboBox_aktiflik.FormattingEnabled = true;
            this.comboBox_aktiflik.Items.AddRange(new object[] {
            "Kullanılmıyor",
            "Kullanılıyor"});
            this.comboBox_aktiflik.Location = new System.Drawing.Point(104, 102);
            this.comboBox_aktiflik.Name = "comboBox_aktiflik";
            this.comboBox_aktiflik.Size = new System.Drawing.Size(152, 21);
            this.comboBox_aktiflik.TabIndex = 10;
            // 
            // Form_MalzemeTipi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 187);
            this.Controls.Add(this.comboBox_aktiflik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_listelemeSecenegi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.comboBox_ad);
            this.Controls.Add(this.label_);
            this.Name = "Form_MalzemeTipi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malzeme Tipi İşlemleri";
            this.Load += new System.EventHandler(this.Form_MalzemeTipi_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.ComboBox comboBox_ad;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_bilgi;
        private System.Windows.Forms.CheckBox checkBox_listelemeSecenegi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_aktiflik;
    }
}