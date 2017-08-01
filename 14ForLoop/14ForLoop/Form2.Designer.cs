namespace _14ForLoop
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTakimlar = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGez = new System.Windows.Forms.Button();
            this.btnSayilar = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnRastgeleCiftTek = new System.Windows.Forms.Button();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.btnSon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(13, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 316);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // btnTakimlar
            // 
            this.btnTakimlar.Location = new System.Drawing.Point(170, 43);
            this.btnTakimlar.Name = "btnTakimlar";
            this.btnTakimlar.Size = new System.Drawing.Size(214, 43);
            this.btnTakimlar.TabIndex = 1;
            this.btnTakimlar.Text = "Takımları Ekle";
            this.btnTakimlar.UseVisualStyleBackColor = true;
            this.btnTakimlar.Click += new System.EventHandler(this.btnTakimlar_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Red;
            this.btnTemizle.ForeColor = System.Drawing.Color.Yellow;
            this.btnTemizle.Location = new System.Drawing.Point(13, 13);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(151, 43);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGez
            // 
            this.btnGez.Location = new System.Drawing.Point(169, 92);
            this.btnGez.Name = "btnGez";
            this.btnGez.Size = new System.Drawing.Size(214, 43);
            this.btnGez.TabIndex = 3;
            this.btnGez.Text = "Gez";
            this.btnGez.UseVisualStyleBackColor = true;
            this.btnGez.Click += new System.EventHandler(this.btnGez_Click);
            // 
            // btnSayilar
            // 
            this.btnSayilar.Location = new System.Drawing.Point(170, 141);
            this.btnSayilar.Name = "btnSayilar";
            this.btnSayilar.Size = new System.Drawing.Size(214, 43);
            this.btnSayilar.TabIndex = 4;
            this.btnSayilar.Text = "Sayilar";
            this.btnSayilar.UseVisualStyleBackColor = true;
            this.btnSayilar.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(170, 190);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(214, 43);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "Rastgele";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnRastgeleCiftTek
            // 
            this.btnRastgeleCiftTek.Location = new System.Drawing.Point(169, 239);
            this.btnRastgeleCiftTek.Name = "btnRastgeleCiftTek";
            this.btnRastgeleCiftTek.Size = new System.Drawing.Size(214, 43);
            this.btnRastgeleCiftTek.TabIndex = 6;
            this.btnRastgeleCiftTek.Text = "Rastgele Cift Tek";
            this.btnRastgeleCiftTek.UseVisualStyleBackColor = true;
            this.btnRastgeleCiftTek.Click += new System.EventHandler(this.btnRastgeleCiftTek_Click);
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Location = new System.Drawing.Point(169, 288);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(214, 43);
            this.btnRenkDegistir.TabIndex = 7;
            this.btnRenkDegistir.Text = "Renk Değiştir";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(170, 13);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(213, 29);
            this.txtMetin.TabIndex = 8;
            // 
            // btnSon
            // 
            this.btnSon.Location = new System.Drawing.Point(170, 337);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(214, 43);
            this.btnSon.TabIndex = 9;
            this.btnSon.Text = "Son İşlem";
            this.btnSon.UseVisualStyleBackColor = true;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 392);
            this.Controls.Add(this.btnSon);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.btnRenkDegistir);
            this.Controls.Add(this.btnRastgeleCiftTek);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnSayilar);
            this.Controls.Add(this.btnGez);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnTakimlar);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTakimlar;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGez;
        private System.Windows.Forms.Button btnSayilar;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnRastgeleCiftTek;
        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button btnSon;
    }
}