namespace OutRefParams
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
            this.btnOut1 = new System.Windows.Forms.Button();
            this.btnOut2 = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOut1
            // 
            this.btnOut1.Location = new System.Drawing.Point(12, 12);
            this.btnOut1.Name = "btnOut1";
            this.btnOut1.Size = new System.Drawing.Size(260, 39);
            this.btnOut1.TabIndex = 0;
            this.btnOut1.Text = "OUT 1";
            this.btnOut1.UseVisualStyleBackColor = true;
            this.btnOut1.Click += new System.EventHandler(this.btnOut1_Click);
            // 
            // btnOut2
            // 
            this.btnOut2.Location = new System.Drawing.Point(12, 57);
            this.btnOut2.Name = "btnOut2";
            this.btnOut2.Size = new System.Drawing.Size(260, 39);
            this.btnOut2.TabIndex = 1;
            this.btnOut2.Text = "OUT 2";
            this.btnOut2.UseVisualStyleBackColor = true;
            this.btnOut2.Click += new System.EventHandler(this.btnOut2_Click);
            // 
            // btnParams
            // 
            this.btnParams.Location = new System.Drawing.Point(12, 102);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(260, 39);
            this.btnParams.TabIndex = 2;
            this.btnParams.Text = "PARAMS";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(12, 147);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(260, 39);
            this.btnRef.TabIndex = 3;
            this.btnRef.Text = "REF";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 199);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnOut2);
            this.Controls.Add(this.btnOut1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOut1;
        private System.Windows.Forms.Button btnOut2;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Button btnRef;
    }
}

