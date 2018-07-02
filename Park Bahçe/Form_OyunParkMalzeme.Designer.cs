namespace Park_Bahçe
{
    partial class Form_OyunParkMalzeme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_malzeme = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_parkAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_malzeme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_adet = new System.Windows.Forms.TextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_malzeme);
            this.groupBox1.Location = new System.Drawing.Point(0, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parkteki Malzemeler";
            // 
            // listView_malzeme
            // 
            this.listView_malzeme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_malzeme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_malzeme.Location = new System.Drawing.Point(3, 16);
            this.listView_malzeme.Name = "listView_malzeme";
            this.listView_malzeme.Size = new System.Drawing.Size(314, 196);
            this.listView_malzeme.TabIndex = 0;
            this.listView_malzeme.UseCompatibleStateImageBehavior = false;
            this.listView_malzeme.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Malzeme Adı";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            // 
            // label_parkAd
            // 
            this.label_parkAd.AutoSize = true;
            this.label_parkAd.Location = new System.Drawing.Point(12, 9);
            this.label_parkAd.Name = "label_parkAd";
            this.label_parkAd.Size = new System.Drawing.Size(0, 13);
            this.label_parkAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eklenecek Malzeme";
            // 
            // comboBox_malzeme
            // 
            this.comboBox_malzeme.FormattingEnabled = true;
            this.comboBox_malzeme.Location = new System.Drawing.Point(121, 31);
            this.comboBox_malzeme.Name = "comboBox_malzeme";
            this.comboBox_malzeme.Size = new System.Drawing.Size(190, 21);
            this.comboBox_malzeme.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eklenecek Adet";
            // 
            // textBox_adet
            // 
            this.textBox_adet.Location = new System.Drawing.Point(121, 58);
            this.textBox_adet.Name = "textBox_adet";
            this.textBox_adet.Size = new System.Drawing.Size(100, 20);
            this.textBox_adet.TabIndex = 4;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(236, 56);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(75, 23);
            this.button_kaydet.TabIndex = 5;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // Form_OyunParkMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 326);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.textBox_adet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_malzeme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_parkAd);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_OyunParkMalzeme";
            this.Text = "Oyun Parkı Malzeme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_OyunParkMalzeme_FormClosed);
            this.Load += new System.EventHandler(this.Form_OyunParkMalzeme_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView_malzeme;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label_parkAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_malzeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_adet;
        private System.Windows.Forms.Button button_kaydet;
    }
}