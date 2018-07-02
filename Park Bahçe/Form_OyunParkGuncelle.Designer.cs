namespace Park_Bahçe
{
    partial class Form_OyunParkGuncelle
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_tamam = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güncellenecek Park";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_tamam
            // 
            this.button_tamam.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_tamam.Location = new System.Drawing.Point(261, 39);
            this.button_tamam.Name = "button_tamam";
            this.button_tamam.Size = new System.Drawing.Size(75, 23);
            this.button_tamam.TabIndex = 2;
            this.button_tamam.Text = "Tamam";
            this.button_tamam.UseVisualStyleBackColor = true;
            // 
            // button_iptal
            // 
            this.button_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_iptal.Location = new System.Drawing.Point(180, 39);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(75, 23);
            this.button_iptal.TabIndex = 3;
            this.button_iptal.Text = "İptal";
            this.button_iptal.UseVisualStyleBackColor = true;
            // 
            // Form_OyunParkGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 72);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_tamam);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_OyunParkGuncelle";
            this.Text = "Güncellenecek Park Seçin";
            this.Load += new System.EventHandler(this.Form_OyunParkGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_tamam;
        private System.Windows.Forms.Button button_iptal;
    }
}