namespace _14ForLoop
{
    partial class Form3
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
            this.btnYanYanaX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAltAltaX = new System.Windows.Forms.Button();
            this.btnKare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYanYanaX
            // 
            this.btnYanYanaX.Location = new System.Drawing.Point(12, 12);
            this.btnYanYanaX.Name = "btnYanYanaX";
            this.btnYanYanaX.Size = new System.Drawing.Size(195, 38);
            this.btnYanYanaX.TabIndex = 0;
            this.btnYanYanaX.Text = "YAN YANA X";
            this.btnYanYanaX.UseVisualStyleBackColor = true;
            this.btnYanYanaX.Click += new System.EventHandler(this.btnYanYanaX_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 180);
            this.label1.TabIndex = 1;
            // 
            // btnAltAltaX
            // 
            this.btnAltAltaX.Location = new System.Drawing.Point(12, 56);
            this.btnAltAltaX.Name = "btnAltAltaX";
            this.btnAltAltaX.Size = new System.Drawing.Size(195, 38);
            this.btnAltAltaX.TabIndex = 2;
            this.btnAltAltaX.Text = "ALT ALTA X";
            this.btnAltAltaX.UseVisualStyleBackColor = true;
            this.btnAltAltaX.Click += new System.EventHandler(this.btnAltAltaX_Click);
            // 
            // btnKare
            // 
            this.btnKare.Location = new System.Drawing.Point(12, 100);
            this.btnKare.Name = "btnKare";
            this.btnKare.Size = new System.Drawing.Size(195, 38);
            this.btnKare.TabIndex = 3;
            this.btnKare.Text = "KARE ÇİZ";
            this.btnKare.UseVisualStyleBackColor = true;
            this.btnKare.Click += new System.EventHandler(this.btnKare_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 388);
            this.Controls.Add(this.btnKare);
            this.Controls.Add(this.btnAltAltaX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYanYanaX);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYanYanaX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltAltaX;
        private System.Windows.Forms.Button btnKare;
    }
}