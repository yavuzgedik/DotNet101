namespace _14ForLoop
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
            this.btn1den1000e = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn1000den1e = new System.Windows.Forms.Button();
            this.btnChar = new System.Windows.Forms.Button();
            this.btnToplam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1den1000e
            // 
            this.btn1den1000e.Location = new System.Drawing.Point(12, 12);
            this.btn1den1000e.Name = "btn1den1000e";
            this.btn1den1000e.Size = new System.Drawing.Size(133, 40);
            this.btn1den1000e.TabIndex = 0;
            this.btn1den1000e.Text = "1-1000";
            this.btn1den1000e.UseVisualStyleBackColor = true;
            this.btn1den1000e.Click += new System.EventHandler(this.btn1den1000e_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(151, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 340);
            this.listBox1.TabIndex = 1;
            // 
            // btn1000den1e
            // 
            this.btn1000den1e.Location = new System.Drawing.Point(12, 58);
            this.btn1000den1e.Name = "btn1000den1e";
            this.btn1000den1e.Size = new System.Drawing.Size(133, 40);
            this.btn1000den1e.TabIndex = 2;
            this.btn1000den1e.Text = "1000-1";
            this.btn1000den1e.UseVisualStyleBackColor = true;
            this.btn1000den1e.Click += new System.EventHandler(this.btn1000den1e_Click);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(12, 104);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(133, 40);
            this.btnChar.TabIndex = 3;
            this.btnChar.Text = "A dan Z ye";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnToplam
            // 
            this.btnToplam.Location = new System.Drawing.Point(12, 150);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(133, 40);
            this.btnToplam.TabIndex = 4;
            this.btnToplam.Text = "1-100";
            this.btnToplam.UseVisualStyleBackColor = true;
            this.btnToplam.Click += new System.EventHandler(this.btnToplam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 368);
            this.Controls.Add(this.btnToplam);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.btn1000den1e);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn1den1000e);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1den1000e;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn1000den1e;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.Button btnToplam;
    }
}

