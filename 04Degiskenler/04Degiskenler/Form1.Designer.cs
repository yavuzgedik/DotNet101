namespace _04Degiskenler
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.btnMerhaba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(89, 125);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(100, 20);
            this.txtMetin.TabIndex = 1;
            this.txtMetin.TextChanged += new System.EventHandler(this.txtMetin_TextChanged);
            // 
            // btnMerhaba
            // 
            this.btnMerhaba.Location = new System.Drawing.Point(89, 151);
            this.btnMerhaba.Name = "btnMerhaba";
            this.btnMerhaba.Size = new System.Drawing.Size(100, 23);
            this.btnMerhaba.TabIndex = 2;
            this.btnMerhaba.Text = "Merhaba";
            this.btnMerhaba.UseVisualStyleBackColor = true;
            this.btnMerhaba.Click += new System.EventHandler(this.btnMerhaba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMerhaba);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button btnMerhaba;
    }
}

