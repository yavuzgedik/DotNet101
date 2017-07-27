namespace _13Alistirma01
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboxIslem = new System.Windows.Forms.ComboBox();
            this.numBirinciSayi = new System.Windows.Forms.NumericUpDown();
            this.numIkinciSayi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBirinciSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIkinciSayi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Sayi";
            // 
            // cboxIslem
            // 
            this.cboxIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxIslem.FormattingEnabled = true;
            this.cboxIslem.Items.AddRange(new object[] {
            "Toplama",
            "Çıkarma",
            "Çarpma",
            "Bölme"});
            this.cboxIslem.Location = new System.Drawing.Point(114, 87);
            this.cboxIslem.Name = "cboxIslem";
            this.cboxIslem.Size = new System.Drawing.Size(210, 32);
            this.cboxIslem.TabIndex = 2;
            this.cboxIslem.SelectedIndexChanged += new System.EventHandler(this.cboxIslem_SelectedIndexChanged);
            // 
            // numBirinciSayi
            // 
            this.numBirinciSayi.DecimalPlaces = 2;
            this.numBirinciSayi.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numBirinciSayi.Location = new System.Drawing.Point(114, 12);
            this.numBirinciSayi.Name = "numBirinciSayi";
            this.numBirinciSayi.Size = new System.Drawing.Size(210, 29);
            this.numBirinciSayi.TabIndex = 5;
            this.numBirinciSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBirinciSayi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBirinciSayi.ValueChanged += new System.EventHandler(this.numIkinciSayi_ValueChanged);
            // 
            // numIkinciSayi
            // 
            this.numIkinciSayi.DecimalPlaces = 2;
            this.numIkinciSayi.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numIkinciSayi.Location = new System.Drawing.Point(114, 52);
            this.numIkinciSayi.Name = "numIkinciSayi";
            this.numIkinciSayi.Size = new System.Drawing.Size(210, 29);
            this.numIkinciSayi.TabIndex = 6;
            this.numIkinciSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numIkinciSayi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIkinciSayi.ValueChanged += new System.EventHandler(this.numIkinciSayi_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "2. Sayi";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(196, 139);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(20, 24);
            this.lblSonuc.TabIndex = 8;
            this.lblSonuc.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sonuç : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 179);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numIkinciSayi);
            this.Controls.Add(this.numBirinciSayi);
            this.Controls.Add(this.cboxIslem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numBirinciSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIkinciSayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxIslem;
        private System.Windows.Forms.NumericUpDown numBirinciSayi;
        private System.Windows.Forms.NumericUpDown numIkinciSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label4;
    }
}

