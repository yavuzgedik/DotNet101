namespace _29OOP2
{
    partial class Form1
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
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxBolumler = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No:";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(136, 12);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(278, 26);
            this.txtOgrNo.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(136, 142);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(278, 26);
            this.dateTimePicker.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(136, 174);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(278, 31);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(136, 44);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(278, 26);
            this.txtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(136, 76);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(278, 26);
            this.txtSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bölüm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // cboxBolumler
            // 
            this.cboxBolumler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBolumler.FormattingEnabled = true;
            this.cboxBolumler.Location = new System.Drawing.Point(136, 108);
            this.cboxBolumler.Name = "cboxBolumler";
            this.cboxBolumler.Size = new System.Drawing.Size(278, 28);
            this.cboxBolumler.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(420, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(778, 184);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 214);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cboxBolumler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtOgrNo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxBolumler;
        private System.Windows.Forms.ListBox listBox1;
    }
}

