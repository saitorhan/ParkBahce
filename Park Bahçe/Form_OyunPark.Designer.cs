namespace Park_Bahçe
{
    partial class Form_OyunPark
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
            if( disposing && ( components != null ) )
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
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_alan = new System.Windows.Forms.TextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_sil_malzeme = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_bilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(85, 12);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(153, 20);
            this.textBox_ad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Park Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alan (m2)";
            // 
            // textBox_alan
            // 
            this.textBox_alan.Location = new System.Drawing.Point(85, 38);
            this.textBox_alan.Name = "textBox_alan";
            this.textBox_alan.Size = new System.Drawing.Size(100, 20);
            this.textBox_alan.TabIndex = 3;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(178, 75);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(75, 23);
            this.button_kaydet.TabIndex = 4;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_sil_malzeme
            // 
            this.button_sil_malzeme.Enabled = false;
            this.button_sil_malzeme.Location = new System.Drawing.Point(82, 75);
            this.button_sil_malzeme.Name = "button_sil_malzeme";
            this.button_sil_malzeme.Size = new System.Drawing.Size(90, 23);
            this.button_sil_malzeme.TabIndex = 5;
            this.button_sil_malzeme.Text = "Malzeme Ekle";
            this.button_sil_malzeme.UseVisualStyleBackColor = true;
            this.button_sil_malzeme.Click += new System.EventHandler(this.button_sil_malzeme_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.Location = new System.Drawing.Point(1, 75);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(75, 23);
            this.button_iptal.TabIndex = 6;
            this.button_iptal.Text = "İptal";
            this.button_iptal.UseVisualStyleBackColor = true;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_bilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 119);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(265, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_bilgi
            // 
            this.toolStripStatusLabel_bilgi.Name = "toolStripStatusLabel_bilgi";
            this.toolStripStatusLabel_bilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // Form_OyunPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 141);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_sil_malzeme);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.textBox_alan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ad);
            this.Name = "Form_OyunPark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun Parkı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_OyunPark_FormClosed);
            this.Load += new System.EventHandler(this.Form_OyunPark_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_alan;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_sil_malzeme;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_bilgi;
    }
}