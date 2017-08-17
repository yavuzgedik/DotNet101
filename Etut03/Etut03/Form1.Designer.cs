namespace Etut03
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
            this.cboxUrunler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listUrunler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numKilo = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listSepet = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKilo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxUrunler
            // 
            this.cboxUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUrunler.FormattingEnabled = true;
            this.cboxUrunler.Location = new System.Drawing.Point(23, 41);
            this.cboxUrunler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxUrunler.Name = "cboxUrunler";
            this.cboxUrunler.Size = new System.Drawing.Size(309, 28);
            this.cboxUrunler.TabIndex = 0;
            this.cboxUrunler.SelectedIndexChanged += new System.EventHandler(this.cboxUrunler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Grubu Seçiniz";
            // 
            // listUrunler
            // 
            this.listUrunler.FormattingEnabled = true;
            this.listUrunler.ItemHeight = 20;
            this.listUrunler.Location = new System.Drawing.Point(363, 41);
            this.listUrunler.Name = "listUrunler";
            this.listUrunler.Size = new System.Drawing.Size(218, 164);
            this.listUrunler.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meyve ve Sebzeler";
            // 
            // numKilo
            // 
            this.numKilo.DecimalPlaces = 1;
            this.numKilo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numKilo.Location = new System.Drawing.Point(407, 211);
            this.numKilo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numKilo.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numKilo.Name = "numKilo";
            this.numKilo.Size = new System.Drawing.Size(174, 26);
            this.numKilo.TabIndex = 4;
            this.numKilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numKilo.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(363, 243);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(218, 38);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listSepet
            // 
            this.listSepet.FormattingEnabled = true;
            this.listSepet.ItemHeight = 20;
            this.listSepet.Location = new System.Drawing.Point(23, 111);
            this.listSepet.Name = "listSepet";
            this.listSepet.Size = new System.Drawing.Size(309, 164);
            this.listSepet.TabIndex = 6;
            this.listSepet.DoubleClick += new System.EventHandler(this.listSepet_DoubleClick);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.DarkGreen;
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(23, 292);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(558, 38);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "ÖDEME HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kilo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sepet";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(23, 336);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(558, 38);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 387);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.listSepet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.numKilo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listUrunler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxUrunler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listUrunler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numKilo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listSepet;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTemizle;
    }
}

