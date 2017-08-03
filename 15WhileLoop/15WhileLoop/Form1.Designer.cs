namespace _15WhileLoop
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTabanDonusumu = new System.Windows.Forms.Button();
            this.btnOyun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "1-100";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(24, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 244);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // 
            // btnTabanDonusumu
            // 
            this.btnTabanDonusumu.Location = new System.Drawing.Point(130, 12);
            this.btnTabanDonusumu.Name = "btnTabanDonusumu";
            this.btnTabanDonusumu.Size = new System.Drawing.Size(284, 26);
            this.btnTabanDonusumu.TabIndex = 3;
            this.btnTabanDonusumu.Text = "10 dan 2 ye";
            this.btnTabanDonusumu.UseVisualStyleBackColor = true;
            this.btnTabanDonusumu.Click += new System.EventHandler(this.btnTabanDonusumu_Click);
            // 
            // btnOyun
            // 
            this.btnOyun.Location = new System.Drawing.Point(24, 90);
            this.btnOyun.Name = "btnOyun";
            this.btnOyun.Size = new System.Drawing.Size(390, 39);
            this.btnOyun.TabIndex = 4;
            this.btnOyun.Text = "OYUN";
            this.btnOyun.UseVisualStyleBackColor = true;
            this.btnOyun.Click += new System.EventHandler(this.btnOyun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.btnOyun);
            this.Controls.Add(this.btnTabanDonusumu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTabanDonusumu;
        private System.Windows.Forms.Button btnOyun;
    }
}

