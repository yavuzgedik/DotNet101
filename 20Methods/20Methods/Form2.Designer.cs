namespace _20Methods
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
            this.numBirinci = new System.Windows.Forms.NumericUpDown();
            this.btnTopla = new System.Windows.Forms.Button();
            this.numIkinci = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBirinci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIkinci)).BeginInit();
            this.SuspendLayout();
            // 
            // numBirinci
            // 
            this.numBirinci.Location = new System.Drawing.Point(12, 12);
            this.numBirinci.Name = "numBirinci";
            this.numBirinci.Size = new System.Drawing.Size(120, 20);
            this.numBirinci.TabIndex = 0;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(12, 38);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(249, 30);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "TOPLA";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // numIkinci
            // 
            this.numIkinci.Location = new System.Drawing.Point(141, 12);
            this.numIkinci.Name = "numIkinci";
            this.numIkinci.Size = new System.Drawing.Size(120, 20);
            this.numIkinci.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 259);
            this.Controls.Add(this.numIkinci);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.numBirinci);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numBirinci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIkinci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numBirinci;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.NumericUpDown numIkinci;
    }
}