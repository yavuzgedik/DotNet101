namespace _09TryCatch
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnKontrolluOnay = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(39, 12);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(360, 29);
            this.txtDeger.TabIndex = 0;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(39, 47);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(360, 50);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnKontrolluOnay
            // 
            this.btnKontrolluOnay.Location = new System.Drawing.Point(39, 103);
            this.btnKontrolluOnay.Name = "btnKontrolluOnay";
            this.btnKontrolluOnay.Size = new System.Drawing.Size(360, 50);
            this.btnKontrolluOnay.TabIndex = 2;
            this.btnKontrolluOnay.Text = "Kontrollü Onay";
            this.btnKontrolluOnay.UseVisualStyleBackColor = true;
            this.btnKontrolluOnay.Click += new System.EventHandler(this.btnKontrolluOnay_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(39, 159);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(360, 50);
            this.btnFinal.TabIndex = 3;
            this.btnFinal.Text = "Final Kontrollü Onay";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 365);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnKontrolluOnay);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtDeger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnKontrolluOnay;
        private System.Windows.Forms.Button btnFinal;
    }
}

