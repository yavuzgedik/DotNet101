namespace _06OperatorlerIslemler2
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
            this.txtBirinci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIkinci = new System.Windows.Forms.TextBox();
            this.btnBirinci = new System.Windows.Forms.Button();
            this.btnIkinci = new System.Windows.Forms.Button();
            this.btnUcuncu = new System.Windows.Forms.Button();
            this.btnDort = new System.Windows.Forms.Button();
            this.btnBes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBirinci
            // 
            this.txtBirinci.Location = new System.Drawing.Point(100, 19);
            this.txtBirinci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBirinci.Name = "txtBirinci";
            this.txtBirinci.Size = new System.Drawing.Size(148, 26);
            this.txtBirinci.TabIndex = 0;
            this.txtBirinci.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birinci Sayi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "İkinci Sayi";
            // 
            // txtIkinci
            // 
            this.txtIkinci.Location = new System.Drawing.Point(100, 55);
            this.txtIkinci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIkinci.Name = "txtIkinci";
            this.txtIkinci.Size = new System.Drawing.Size(148, 26);
            this.txtIkinci.TabIndex = 2;
            this.txtIkinci.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBirinci
            // 
            this.btnBirinci.Location = new System.Drawing.Point(17, 89);
            this.btnBirinci.Name = "btnBirinci";
            this.btnBirinci.Size = new System.Drawing.Size(231, 41);
            this.btnBirinci.TabIndex = 4;
            this.btnBirinci.Text = "Birinci Alıştırma";
            this.btnBirinci.UseVisualStyleBackColor = true;
            this.btnBirinci.Click += new System.EventHandler(this.btnBirinci_Click);
            // 
            // btnIkinci
            // 
            this.btnIkinci.Location = new System.Drawing.Point(17, 136);
            this.btnIkinci.Name = "btnIkinci";
            this.btnIkinci.Size = new System.Drawing.Size(231, 41);
            this.btnIkinci.TabIndex = 5;
            this.btnIkinci.Text = "İkinci Alıştırma";
            this.btnIkinci.UseVisualStyleBackColor = true;
            this.btnIkinci.Click += new System.EventHandler(this.btnIkinci_Click);
            // 
            // btnUcuncu
            // 
            this.btnUcuncu.Location = new System.Drawing.Point(17, 183);
            this.btnUcuncu.Name = "btnUcuncu";
            this.btnUcuncu.Size = new System.Drawing.Size(231, 41);
            this.btnUcuncu.TabIndex = 6;
            this.btnUcuncu.Text = "Üçüncü Alıştırma";
            this.btnUcuncu.UseVisualStyleBackColor = true;
            this.btnUcuncu.Click += new System.EventHandler(this.btnUcuncu_Click);
            // 
            // btnDort
            // 
            this.btnDort.Location = new System.Drawing.Point(17, 230);
            this.btnDort.Name = "btnDort";
            this.btnDort.Size = new System.Drawing.Size(231, 41);
            this.btnDort.TabIndex = 7;
            this.btnDort.Text = "Dördüncü Alıştırma";
            this.btnDort.UseVisualStyleBackColor = true;
            this.btnDort.Click += new System.EventHandler(this.btnDort_Click);
            // 
            // btnBes
            // 
            this.btnBes.Location = new System.Drawing.Point(17, 277);
            this.btnBes.Name = "btnBes";
            this.btnBes.Size = new System.Drawing.Size(231, 41);
            this.btnBes.TabIndex = 8;
            this.btnBes.Text = "Beşinci Alıştırma";
            this.btnBes.UseVisualStyleBackColor = true;
            this.btnBes.Click += new System.EventHandler(this.btnBes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 336);
            this.Controls.Add(this.btnBes);
            this.Controls.Add(this.btnDort);
            this.Controls.Add(this.btnUcuncu);
            this.Controls.Add(this.btnIkinci);
            this.Controls.Add(this.btnBirinci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIkinci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBirinci);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirinci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIkinci;
        private System.Windows.Forms.Button btnBirinci;
        private System.Windows.Forms.Button btnIkinci;
        private System.Windows.Forms.Button btnUcuncu;
        private System.Windows.Forms.Button btnDort;
        private System.Windows.Forms.Button btnBes;
    }
}

