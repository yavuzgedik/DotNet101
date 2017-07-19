namespace _05OperatorlerIslemler
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
            this.btnToplama = new System.Windows.Forms.Button();
            this.btnCikarma = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnArtAzalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(12, 12);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(258, 44);
            this.btnToplama.TabIndex = 0;
            this.btnToplama.Text = "TOPLAMA";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // btnCikarma
            // 
            this.btnCikarma.Location = new System.Drawing.Point(12, 62);
            this.btnCikarma.Name = "btnCikarma";
            this.btnCikarma.Size = new System.Drawing.Size(258, 44);
            this.btnCikarma.TabIndex = 1;
            this.btnCikarma.Text = "ÇIKARMA";
            this.btnCikarma.UseVisualStyleBackColor = true;
            this.btnCikarma.Click += new System.EventHandler(this.btnCikarma_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(12, 112);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(258, 44);
            this.btnCarpma.TabIndex = 2;
            this.btnCarpma.Text = "ÇARPMA";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(12, 162);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(258, 44);
            this.btnBolme.TabIndex = 3;
            this.btnBolme.Text = "BÖLME";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(12, 212);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(258, 44);
            this.btnMod.TabIndex = 4;
            this.btnMod.Text = "MOD";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnArtAzalt
            // 
            this.btnArtAzalt.Location = new System.Drawing.Point(12, 262);
            this.btnArtAzalt.Name = "btnArtAzalt";
            this.btnArtAzalt.Size = new System.Drawing.Size(258, 44);
            this.btnArtAzalt.TabIndex = 5;
            this.btnArtAzalt.Text = "+1 -1";
            this.btnArtAzalt.UseVisualStyleBackColor = true;
            this.btnArtAzalt.Click += new System.EventHandler(this.btnArtAzalt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 320);
            this.Controls.Add(this.btnArtAzalt);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnCikarma);
            this.Controls.Add(this.btnToplama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btnCikarma;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnBolme;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnArtAzalt;
    }
}

