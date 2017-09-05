namespace _28OOP1
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
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numFiyat = new System.Windows.Forms.NumericUpDown();
            this.cboxRenk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listAraclar = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxEkleGüncelle = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(77, 30);
            this.txtPlaka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(148, 26);
            this.txtPlaka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaka";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(77, 221);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(148, 35);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(77, 73);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(148, 26);
            this.txtMarka.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fiyat";
            // 
            // numFiyat
            // 
            this.numFiyat.Location = new System.Drawing.Point(77, 116);
            this.numFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numFiyat.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numFiyat.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numFiyat.Name = "numFiyat";
            this.numFiyat.Size = new System.Drawing.Size(148, 26);
            this.numFiyat.TabIndex = 2;
            this.numFiyat.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cboxRenk
            // 
            this.cboxRenk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRenk.FormattingEnabled = true;
            this.cboxRenk.Items.AddRange(new object[] {
            "Beyaz",
            "Siyah",
            "Mavi",
            "Kırmızı"});
            this.cboxRenk.Location = new System.Drawing.Point(77, 153);
            this.cboxRenk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxRenk.Name = "cboxRenk";
            this.cboxRenk.Size = new System.Drawing.Size(148, 28);
            this.cboxRenk.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Renk";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxEkleGüncelle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.cboxRenk);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.numFiyat);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 284);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // listAraclar
            // 
            this.listAraclar.FormattingEnabled = true;
            this.listAraclar.ItemHeight = 20;
            this.listAraclar.Location = new System.Drawing.Point(298, 32);
            this.listAraclar.Name = "listAraclar";
            this.listAraclar.Size = new System.Drawing.Size(497, 264);
            this.listAraclar.TabIndex = 13;
            this.listAraclar.Click += new System.EventHandler(this.listAraclar_Click);
            this.listAraclar.DoubleClick += new System.EventHandler(this.listAraclar_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Araç Silmek İçin Çift Tıklayınız!";
            // 
            // checkBoxEkleGüncelle
            // 
            this.checkBoxEkleGüncelle.AutoSize = true;
            this.checkBoxEkleGüncelle.Checked = true;
            this.checkBoxEkleGüncelle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkleGüncelle.Location = new System.Drawing.Point(77, 189);
            this.checkBoxEkleGüncelle.Name = "checkBoxEkleGüncelle";
            this.checkBoxEkleGüncelle.Size = new System.Drawing.Size(59, 24);
            this.checkBoxEkleGüncelle.TabIndex = 12;
            this.checkBoxEkleGüncelle.Text = "Ekle";
            this.checkBoxEkleGüncelle.UseVisualStyleBackColor = true;
            this.checkBoxEkleGüncelle.CheckedChanged += new System.EventHandler(this.checkBoxEkleGüncelle_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listAraclar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numFiyat;
        private System.Windows.Forms.ComboBox cboxRenk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listAraclar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxEkleGüncelle;
    }
}

