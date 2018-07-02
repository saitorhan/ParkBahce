namespace Park_Bahçe
{
    partial class Form_Park
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
            this.dateTimePicker_AcilisTarih = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_cesmeAdet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_bisiklet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_piknik = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_Mescid = new System.Windows.Forms.CheckBox();
            this.checkBox_WC = new System.Windows.Forms.CheckBox();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.textBox_cimAlan = new System.Windows.Forms.TextBox();
            this.textBox_igneAgac = new System.Windows.Forms.TextBox();
            this.textBox_genisAgac = new System.Windows.Forms.TextBox();
            this.textBox_yuruyus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_bilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_bilgiler.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bilgiler
            // 
            this.panel_bilgiler.Controls.Add(this.dateTimePicker_AcilisTarih);
            this.panel_bilgiler.Controls.Add(this.label9);
            this.panel_bilgiler.Controls.Add(this.textBox_cesmeAdet);
            this.panel_bilgiler.Controls.Add(this.label8);
            this.panel_bilgiler.Controls.Add(this.textBox_bisiklet);
            this.panel_bilgiler.Controls.Add(this.label7);
            this.panel_bilgiler.Controls.Add(this.textBox_piknik);
            this.panel_bilgiler.Controls.Add(this.label6);
            this.panel_bilgiler.Controls.Add(this.checkBox_Mescid);
            this.panel_bilgiler.Controls.Add(this.checkBox_WC);
            this.panel_bilgiler.Controls.Add(this.textBox_Ad);
            this.panel_bilgiler.Controls.Add(this.textBox_cimAlan);
            this.panel_bilgiler.Controls.Add(this.textBox_igneAgac);
            this.panel_bilgiler.Controls.Add(this.textBox_genisAgac);
            this.panel_bilgiler.Controls.Add(this.textBox_yuruyus);
            this.panel_bilgiler.Controls.Add(this.label5);
            this.panel_bilgiler.Controls.Add(this.label4);
            this.panel_bilgiler.Controls.Add(this.label3);
            this.panel_bilgiler.Controls.Add(this.label2);
            this.panel_bilgiler.Controls.Add(this.label1);
            this.panel_bilgiler.Location = new System.Drawing.Point(12, 12);
            this.panel_bilgiler.Name = "panel_bilgiler";
            this.panel_bilgiler.Size = new System.Drawing.Size(302, 305);
            this.panel_bilgiler.TabIndex = 0;
            // 
            // dateTimePicker_AcilisTarih
            // 
            this.dateTimePicker_AcilisTarih.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker_AcilisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_AcilisTarih.Location = new System.Drawing.Point(159, 267);
            this.dateTimePicker_AcilisTarih.Name = "dateTimePicker_AcilisTarih";
            this.dateTimePicker_AcilisTarih.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker_AcilisTarih.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Açılış Tarihi";
            // 
            // textBox_cesmeAdet
            // 
            this.textBox_cesmeAdet.Location = new System.Drawing.Point(159, 238);
            this.textBox_cesmeAdet.Name = "textBox_cesmeAdet";
            this.textBox_cesmeAdet.Size = new System.Drawing.Size(134, 20);
            this.textBox_cesmeAdet.TabIndex = 9;
            this.textBox_cesmeAdet.Text = "0";
            this.textBox_cesmeAdet.Enter += new System.EventHandler(this.textBox_cimAlan_Enter);
            this.textBox_cesmeAdet.Leave += new System.EventHandler(this.textBox_cimAlan_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Çeşme Adedi";
            // 
            // textBox_bisiklet
            // 
            this.textBox_bisiklet.Location = new System.Drawing.Point(159, 212);
            this.textBox_bisiklet.Name = "textBox_bisiklet";
            this.textBox_bisiklet.Size = new System.Drawing.Size(134, 20);
            this.textBox_bisiklet.TabIndex = 8;
            this.textBox_bisiklet.Text = "0";
            this.textBox_bisiklet.Enter += new System.EventHandler(this.textBox_cimAlan_Enter);
            this.textBox_bisiklet.Leave += new System.EventHandler(this.textBox_cimAlan_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bisiklet Parkuru Uzunluğu (m)";
            // 
            // textBox_piknik
            // 
            this.textBox_piknik.Location = new System.Drawing.Point(159, 186);
            this.textBox_piknik.Name = "textBox_piknik";
            this.textBox_piknik.Size = new System.Drawing.Size(134, 20);
            this.textBox_piknik.TabIndex = 7;
            this.textBox_piknik.Text = "0";
            this.textBox_piknik.Enter += new System.EventHandler(this.textBox_cimAlan_Enter);
            this.textBox_piknik.Leave += new System.EventHandler(this.textBox_cimAlan_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Piknik Alanı (m2)";
            // 
            // checkBox_Mescid
            // 
            this.checkBox_Mescid.AutoSize = true;
            this.checkBox_Mescid.Location = new System.Drawing.Point(159, 163);
            this.checkBox_Mescid.Name = "checkBox_Mescid";
            this.checkBox_Mescid.Size = new System.Drawing.Size(79, 17);
            this.checkBox_Mescid.TabIndex = 6;
            this.checkBox_Mescid.Text = "Mescid Var";
            this.checkBox_Mescid.UseVisualStyleBackColor = true;
            // 
            // checkBox_WC
            // 
            this.checkBox_WC.AutoSize = true;
            this.checkBox_WC.Location = new System.Drawing.Point(159, 140);
            this.checkBox_WC.Name = "checkBox_WC";
            this.checkBox_WC.Size = new System.Drawing.Size(63, 17);
            this.checkBox_WC.TabIndex = 5;
            this.checkBox_WC.Text = "WC Var";
            this.checkBox_WC.UseVisualStyleBackColor = true;
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Location = new System.Drawing.Point(159, 10);
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(134, 20);
            this.textBox_Ad.TabIndex = 0;
            this.textBox_Ad.Leave += new System.EventHandler(this.textBox_Ad_Leave);
            // 
            // textBox_cimAlan
            // 
            this.textBox_cimAlan.Location = new System.Drawing.Point(159, 36);
            this.textBox_cimAlan.Name = "textBox_cimAlan";
            this.textBox_cimAlan.Size = new System.Drawing.Size(134, 20);
            this.textBox_cimAlan.TabIndex = 1;
            this.textBox_cimAlan.Text = "0";
            this.textBox_cimAlan.Enter += new System.EventHandler(this.textBox_cimAlan_Enter);
            this.textBox_cimAlan.Leave += new System.EventHandler(this.textBox_cimAlan_Leave);
            // 
            // textBox_igneAgac
            // 
            this.textBox_igneAgac.Location = new System.Drawing.Point(159, 62);
            this.textBox_igneAgac.Name = "textBox_igneAgac";
            this.textBox_igneAgac.Size = new System.Drawing.Size(134, 20);
            this.textBox_igneAgac.TabIndex = 2;
            this.textBox_igneAgac.Text = "0";
            this.textBox_igneAgac.Enter += new System.EventHandler(this.textBox_cimAlan_Enter);
            this.textBox_igneAgac.Leave += new System.EventHandler(this.textBox_cimAlan_Leave);
            // 
            // textBox_genisAgac
            // 
            this.textBox_genisAgac.Location = new System.Drawing.Point(159, 88);
            this.textBox_genisAgac.Name = "textBox_genisAgac";
            this.textBox_genisAgac.Size = new System.Drawing.Size(134, 20);
            this.textBox_genisAgac.TabIndex = 3;
            this.textBox_genisAgac.Text = "0";
            this.textBox_genisAgac.Enter += new System.EventHandler(this.textBox_cimAlan_Enter);
            this.textBox_genisAgac.Leave += new System.EventHandler(this.textBox_cimAlan_Leave);
            // 
            // textBox_yuruyus
            // 
            this.textBox_yuruyus.Location = new System.Drawing.Point(159, 114);
            this.textBox_yuruyus.Name = "textBox_yuruyus";
            this.textBox_yuruyus.Size = new System.Drawing.Size(134, 20);
            this.textBox_yuruyus.TabIndex = 4;
            this.textBox_yuruyus.Text = "0";
            this.textBox_yuruyus.Enter += new System.EventHandler(this.textBox_cimAlan_Enter);
            this.textBox_yuruyus.Leave += new System.EventHandler(this.textBox_cimAlan_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Çim Alan Miktarı (m2)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "İğne Yapraklı Ağaç Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geniş Yapraklı Ağaç Adedi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yürüyüş Parkuru Uzunluğu (m)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Park Adı";
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(239, 323);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(75, 23);
            this.button_kaydet.TabIndex = 1;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.Location = new System.Drawing.Point(158, 323);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(75, 23);
            this.button_iptal.TabIndex = 2;
            this.button_iptal.Text = "İptal";
            this.button_iptal.UseVisualStyleBackColor = true;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_bilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 357);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(317, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_bilgi
            // 
            this.toolStripStatusLabel_bilgi.Name = "toolStripStatusLabel_bilgi";
            this.toolStripStatusLabel_bilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // Form_Park
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 379);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.panel_bilgiler);
            this.Name = "Form_Park";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Park İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Park_FormClosed);
            this.Load += new System.EventHandler(this.Form_Park_Load);
            this.panel_bilgiler.ResumeLayout(false);
            this.panel_bilgiler.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_bilgiler;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AcilisTarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_cesmeAdet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_bisiklet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_piknik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_Mescid;
        private System.Windows.Forms.CheckBox checkBox_WC;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.TextBox textBox_cimAlan;
        private System.Windows.Forms.TextBox textBox_igneAgac;
        private System.Windows.Forms.TextBox textBox_genisAgac;
        private System.Windows.Forms.TextBox textBox_yuruyus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_bilgi;
    }
}