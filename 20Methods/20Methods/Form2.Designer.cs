namespace _20Methods
{
    partial class Form2
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
            this.numBirinci = new System.Windows.Forms.NumericUpDown();
            this.btnTopla = new System.Windows.Forms.Button();
            this.numIkinci = new System.Windows.Forms.NumericUpDown();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnCiftTek = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.cboxColor = new System.Windows.Forms.ComboBox();
            this.btnRandomColor = new System.Windows.Forms.Button();
            this.btnWC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxMailDomain = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBirinci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIkinci)).BeginInit();
            this.SuspendLayout();
            // 
            // numBirinci
            // 
            this.numBirinci.Location = new System.Drawing.Point(12, 12);
            this.numBirinci.Name = "numBirinci";
            this.numBirinci.Size = new System.Drawing.Size(120, 20);
            this.numBirinci.TabIndex = 0;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(12, 38);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(249, 30);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "TOPLA";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // numIkinci
            // 
            this.numIkinci.Location = new System.Drawing.Point(141, 12);
            this.numIkinci.Name = "numIkinci";
            this.numIkinci.Size = new System.Drawing.Size(120, 20);
            this.numIkinci.TabIndex = 1;
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(12, 74);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(104, 20);
            this.txtSayi.TabIndex = 3;
            // 
            // btnCiftTek
            // 
            this.btnCiftTek.Location = new System.Drawing.Point(122, 74);
            this.btnCiftTek.Name = "btnCiftTek";
            this.btnCiftTek.Size = new System.Drawing.Size(139, 20);
            this.btnCiftTek.TabIndex = 4;
            this.btnCiftTek.Text = "Ç T";
            this.btnCiftTek.UseVisualStyleBackColor = true;
            this.btnCiftTek.Click += new System.EventHandler(this.btnCiftTek_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(12, 100);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(249, 44);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "Random Game";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // cboxColor
            // 
            this.cboxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxColor.FormattingEnabled = true;
            this.cboxColor.Items.AddRange(new object[] {
            "Blue",
            "Black",
            "Yellow",
            "Red",
            "Green",
            "Gray",
            "White",
            "Purple",
            "Orange"});
            this.cboxColor.Location = new System.Drawing.Point(12, 150);
            this.cboxColor.Name = "cboxColor";
            this.cboxColor.Size = new System.Drawing.Size(249, 21);
            this.cboxColor.TabIndex = 6;
            this.cboxColor.SelectedIndexChanged += new System.EventHandler(this.cboxColor_SelectedIndexChanged);
            // 
            // btnRandomColor
            // 
            this.btnRandomColor.Location = new System.Drawing.Point(12, 177);
            this.btnRandomColor.Name = "btnRandomColor";
            this.btnRandomColor.Size = new System.Drawing.Size(249, 29);
            this.btnRandomColor.TabIndex = 7;
            this.btnRandomColor.Text = "Random Color";
            this.btnRandomColor.UseVisualStyleBackColor = true;
            this.btnRandomColor.Click += new System.EventHandler(this.btnRandomColor_Click);
            // 
            // btnWC
            // 
            this.btnWC.Location = new System.Drawing.Point(12, 212);
            this.btnWC.Name = "btnWC";
            this.btnWC.Size = new System.Drawing.Size(249, 29);
            this.btnWC.TabIndex = 8;
            this.btnWC.Text = "What Color?";
            this.btnWC.UseVisualStyleBackColor = true;
            this.btnWC.Click += new System.EventHandler(this.btnWC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(54, 250);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 10;
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.DarkGreen;
            this.btnOlustur.ForeColor = System.Drawing.Color.White;
            this.btnOlustur.Location = new System.Drawing.Point(160, 250);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(101, 73);
            this.btnOlustur.TabIndex = 11;
            this.btnOlustur.Text = "OLUŞTUR";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(54, 276);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyad";
            // 
            // cboxMailDomain
            // 
            this.cboxMailDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMailDomain.FormattingEnabled = true;
            this.cboxMailDomain.Items.AddRange(new object[] {
            "@yavuzgedik.com",
            "@gmail.com",
            "@hotmail.com",
            "@msn.com",
            "@yahoo.com",
            "@mynet.com",
            "@outlook.com",
            "@windowslive.com"});
            this.cboxMailDomain.Location = new System.Drawing.Point(16, 302);
            this.cboxMailDomain.Name = "cboxMailDomain";
            this.cboxMailDomain.Size = new System.Drawing.Size(138, 21);
            this.cboxMailDomain.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 330);
            this.Controls.Add(this.cboxMailDomain);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWC);
            this.Controls.Add(this.btnRandomColor);
            this.Controls.Add(this.cboxColor);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnCiftTek);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.numIkinci);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.numBirinci);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numBirinci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIkinci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numBirinci;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.NumericUpDown numIkinci;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnCiftTek;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ComboBox cboxColor;
        private System.Windows.Forms.Button btnRandomColor;
        private System.Windows.Forms.Button btnWC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxMailDomain;
    }
}