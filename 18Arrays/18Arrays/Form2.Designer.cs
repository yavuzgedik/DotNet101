namespace _18Arrays
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
            this.btnSonEleman = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRastgele = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEkleTopla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSonEleman
            // 
            this.btnSonEleman.Location = new System.Drawing.Point(13, 14);
            this.btnSonEleman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSonEleman.Name = "btnSonEleman";
            this.btnSonEleman.Size = new System.Drawing.Size(257, 49);
            this.btnSonEleman.TabIndex = 0;
            this.btnSonEleman.Text = "Son Elemanı Getir";
            this.btnSonEleman.UseVisualStyleBackColor = true;
            this.btnSonEleman.Click += new System.EventHandler(this.btnSonEleman_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(277, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRastgele
            // 
            this.btnRastgele.Location = new System.Drawing.Point(13, 73);
            this.btnRastgele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRastgele.Name = "btnRastgele";
            this.btnRastgele.Size = new System.Drawing.Size(257, 49);
            this.btnRastgele.TabIndex = 2;
            this.btnRastgele.Text = "Rastgele Eleman Getir";
            this.btnRastgele.UseVisualStyleBackColor = true;
            this.btnRastgele.Click += new System.EventHandler(this.btnRastgele_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(278, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 164);
            this.listBox1.TabIndex = 3;
            // 
            // btnEkleTopla
            // 
            this.btnEkleTopla.Location = new System.Drawing.Point(14, 132);
            this.btnEkleTopla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkleTopla.Name = "btnEkleTopla";
            this.btnEkleTopla.Size = new System.Drawing.Size(257, 49);
            this.btnEkleTopla.TabIndex = 4;
            this.btnEkleTopla.Text = "Eleman Ekle Topla";
            this.btnEkleTopla.UseVisualStyleBackColor = true;
            this.btnEkleTopla.Click += new System.EventHandler(this.btnEkleTopla_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 221);
            this.Controls.Add(this.btnEkleTopla);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRastgele);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSonEleman);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSonEleman;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRastgele;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEkleTopla;
    }
}