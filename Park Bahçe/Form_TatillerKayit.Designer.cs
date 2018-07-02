namespace Park_Bahçe
{
    partial class Form_TatillerKayit
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
            this.dateTimePicker_ramazan = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_kurban = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView_tatiller = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ramazan Bayramı 1. Gün Tarihi";
            // 
            // dateTimePicker_ramazan
            // 
            this.dateTimePicker_ramazan.Location = new System.Drawing.Point(174, 12);
            this.dateTimePicker_ramazan.Name = "dateTimePicker_ramazan";
            this.dateTimePicker_ramazan.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_ramazan.TabIndex = 1;
            this.dateTimePicker_ramazan.ValueChanged += new System.EventHandler(this.dateTimePicker_ramazan_ValueChanged);
            // 
            // dateTimePicker_kurban
            // 
            this.dateTimePicker_kurban.Location = new System.Drawing.Point(174, 38);
            this.dateTimePicker_kurban.Name = "dateTimePicker_kurban";
            this.dateTimePicker_kurban.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_kurban.TabIndex = 3;
            this.dateTimePicker_kurban.ValueChanged += new System.EventHandler(this.dateTimePicker_ramazan_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kurban Bayramı 1. Gün Tarihi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tatilleri Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView_tatiller
            // 
            this.listView_tatiller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_tatiller.Location = new System.Drawing.Point(15, 105);
            this.listView_tatiller.Name = "listView_tatiller";
            this.listView_tatiller.Size = new System.Drawing.Size(359, 168);
            this.listView_tatiller.TabIndex = 5;
            this.listView_tatiller.UseCompatibleStateImageBehavior = false;
            this.listView_tatiller.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tarih";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tatil Adı";
            this.columnHeader2.Width = 250;
            // 
            // Form_TatillerKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 318);
            this.Controls.Add(this.listView_tatiller);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker_kurban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_ramazan);
            this.Controls.Add(this.label1);
            this.Name = "Form_TatillerKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tatiller Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ramazan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_kurban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView_tatiller;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}