namespace _22Collection
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
            this.btnListCreate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnYillariEkle = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListCreate
            // 
            this.btnListCreate.Location = new System.Drawing.Point(12, 12);
            this.btnListCreate.Name = "btnListCreate";
            this.btnListCreate.Size = new System.Drawing.Size(108, 42);
            this.btnListCreate.TabIndex = 0;
            this.btnListCreate.Text = "List Oluştur";
            this.btnListCreate.UseVisualStyleBackColor = true;
            this.btnListCreate.Click += new System.EventHandler(this.btnListCreate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(126, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 224);
            this.listBox1.TabIndex = 1;
            // 
            // btnYillariEkle
            // 
            this.btnYillariEkle.Location = new System.Drawing.Point(12, 60);
            this.btnYillariEkle.Name = "btnYillariEkle";
            this.btnYillariEkle.Size = new System.Drawing.Size(108, 42);
            this.btnYillariEkle.TabIndex = 2;
            this.btnYillariEkle.Text = "Yıllar";
            this.btnYillariEkle.UseVisualStyleBackColor = true;
            this.btnYillariEkle.Click += new System.EventHandler(this.btnYillariEkle_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(126, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(289, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 280);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnYillariEkle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnListCreate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListCreate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnYillariEkle;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

