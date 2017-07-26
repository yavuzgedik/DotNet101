namespace _12SwitchCase
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
            this.cboxMevsimler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboxMevsimler
            // 
            this.cboxMevsimler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMevsimler.FormattingEnabled = true;
            this.cboxMevsimler.Location = new System.Drawing.Point(12, 12);
            this.cboxMevsimler.Name = "cboxMevsimler";
            this.cboxMevsimler.Size = new System.Drawing.Size(408, 32);
            this.cboxMevsimler.TabIndex = 0;
            this.cboxMevsimler.SelectedIndexChanged += new System.EventHandler(this.cboxMevsimler_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 331);
            this.Controls.Add(this.cboxMevsimler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxMevsimler;
    }
}

