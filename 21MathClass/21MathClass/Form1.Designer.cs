namespace _21MathClass
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
            this.btnPi = new System.Windows.Forms.Button();
            this.btnMutlak = new System.Windows.Forms.Button();
            this.btnFloor = new System.Windows.Forms.Button();
            this.btnCeiling = new System.Windows.Forms.Button();
            this.btnRound = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaban = new System.Windows.Forms.TextBox();
            this.txtUs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(12, 12);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(237, 28);
            this.btnPi.TabIndex = 0;
            this.btnPi.Text = "Pi Sayisi";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnMutlak
            // 
            this.btnMutlak.Location = new System.Drawing.Point(12, 46);
            this.btnMutlak.Name = "btnMutlak";
            this.btnMutlak.Size = new System.Drawing.Size(237, 28);
            this.btnMutlak.TabIndex = 1;
            this.btnMutlak.Text = "Mutlak Değer";
            this.btnMutlak.UseVisualStyleBackColor = true;
            this.btnMutlak.Click += new System.EventHandler(this.btnMutlak_Click);
            // 
            // btnFloor
            // 
            this.btnFloor.Location = new System.Drawing.Point(12, 80);
            this.btnFloor.Name = "btnFloor";
            this.btnFloor.Size = new System.Drawing.Size(237, 28);
            this.btnFloor.TabIndex = 2;
            this.btnFloor.Text = "FLOOR";
            this.btnFloor.UseVisualStyleBackColor = true;
            this.btnFloor.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // btnCeiling
            // 
            this.btnCeiling.Location = new System.Drawing.Point(12, 114);
            this.btnCeiling.Name = "btnCeiling";
            this.btnCeiling.Size = new System.Drawing.Size(237, 28);
            this.btnCeiling.TabIndex = 3;
            this.btnCeiling.Text = "CEILING";
            this.btnCeiling.UseVisualStyleBackColor = true;
            this.btnCeiling.Click += new System.EventHandler(this.btnCeiling_Click);
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(12, 148);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(237, 28);
            this.btnRound.TabIndex = 4;
            this.btnRound.Text = "ROUND";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(12, 182);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(237, 28);
            this.btnMax.TabIndex = 5;
            this.btnMax.Text = "MAX";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(12, 216);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(237, 28);
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "MIN";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Taban";
            // 
            // txtTaban
            // 
            this.txtTaban.Location = new System.Drawing.Point(53, 250);
            this.txtTaban.Name = "txtTaban";
            this.txtTaban.Size = new System.Drawing.Size(100, 20);
            this.txtTaban.TabIndex = 8;
            // 
            // txtUs
            // 
            this.txtUs.Location = new System.Drawing.Point(53, 276);
            this.txtUs.Name = "txtUs";
            this.txtUs.Size = new System.Drawing.Size(100, 20);
            this.txtUs.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Us";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(159, 250);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(90, 46);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 379);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtUs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaban);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.btnCeiling);
            this.Controls.Add(this.btnFloor);
            this.Controls.Add(this.btnMutlak);
            this.Controls.Add(this.btnPi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnMutlak;
        private System.Windows.Forms.Button btnFloor;
        private System.Windows.Forms.Button btnCeiling;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaban;
        private System.Windows.Forms.TextBox txtUs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
    }
}

