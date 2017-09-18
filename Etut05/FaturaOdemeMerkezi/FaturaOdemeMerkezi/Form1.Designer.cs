namespace FaturaOdemeMerkezi
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
            this.cboxVezneSayisi = new System.Windows.Forms.ComboBox();
            this.gboxAcilis = new System.Windows.Forms.GroupBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.lblBaslikMesaj = new System.Windows.Forms.Label();
            this.gboxVeznedar = new System.Windows.Forms.GroupBox();
            this.txtVeznedarNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVeznedarSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVeznedarAd = new System.Windows.Forms.TextBox();
            this.btnVeznedarKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxFatura = new System.Windows.Forms.GroupBox();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.txtFaturaTutari = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyAd = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.dtpSonOdeme = new System.Windows.Forms.DateTimePicker();
            this.cboxOdemeTip = new System.Windows.Forms.ComboBox();
            this.dtpIslem = new System.Windows.Forms.DateTimePicker();
            this.btnFaturaEkle = new System.Windows.Forms.Button();
            this.gboxAcilis.SuspendLayout();
            this.gboxVeznedar.SuspendLayout();
            this.gboxFatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaç Adet Vezne Oluşturulsun?";
            // 
            // cboxVezneSayisi
            // 
            this.cboxVezneSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxVezneSayisi.FormattingEnabled = true;
            this.cboxVezneSayisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboxVezneSayisi.Location = new System.Drawing.Point(15, 55);
            this.cboxVezneSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.cboxVezneSayisi.Name = "cboxVezneSayisi";
            this.cboxVezneSayisi.Size = new System.Drawing.Size(185, 24);
            this.cboxVezneSayisi.TabIndex = 0;
            this.cboxVezneSayisi.SelectedIndexChanged += new System.EventHandler(this.cboxVezneSayisi_SelectedIndexChanged);
            // 
            // gboxAcilis
            // 
            this.gboxAcilis.Controls.Add(this.btnOlustur);
            this.gboxAcilis.Controls.Add(this.label1);
            this.gboxAcilis.Controls.Add(this.cboxVezneSayisi);
            this.gboxAcilis.Location = new System.Drawing.Point(12, 12);
            this.gboxAcilis.Name = "gboxAcilis";
            this.gboxAcilis.Size = new System.Drawing.Size(406, 96);
            this.gboxAcilis.TabIndex = 2;
            this.gboxAcilis.TabStop = false;
            this.gboxAcilis.Text = "Açılış";
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOlustur.ForeColor = System.Drawing.SystemColors.Info;
            this.btnOlustur.Location = new System.Drawing.Point(217, 21);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(141, 58);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // lblBaslikMesaj
            // 
            this.lblBaslikMesaj.AutoSize = true;
            this.lblBaslikMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslikMesaj.Location = new System.Drawing.Point(40, 133);
            this.lblBaslikMesaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslikMesaj.Name = "lblBaslikMesaj";
            this.lblBaslikMesaj.Size = new System.Drawing.Size(315, 29);
            this.lblBaslikMesaj.TabIndex = 3;
            this.lblBaslikMesaj.Text = "0 Adet Vezne Hizmete Hazır.";
            // 
            // gboxVeznedar
            // 
            this.gboxVeznedar.Controls.Add(this.txtVeznedarNo);
            this.gboxVeznedar.Controls.Add(this.label4);
            this.gboxVeznedar.Controls.Add(this.txtVeznedarSoyad);
            this.gboxVeznedar.Controls.Add(this.label3);
            this.gboxVeznedar.Controls.Add(this.txtVeznedarAd);
            this.gboxVeznedar.Controls.Add(this.btnVeznedarKaydet);
            this.gboxVeznedar.Controls.Add(this.label2);
            this.gboxVeznedar.Enabled = false;
            this.gboxVeznedar.Location = new System.Drawing.Point(433, 12);
            this.gboxVeznedar.Name = "gboxVeznedar";
            this.gboxVeznedar.Size = new System.Drawing.Size(176, 150);
            this.gboxVeznedar.TabIndex = 0;
            this.gboxVeznedar.TabStop = false;
            this.gboxVeznedar.Text = "Veznedar Bilgileri";
            // 
            // txtVeznedarNo
            // 
            this.txtVeznedarNo.Location = new System.Drawing.Point(64, 29);
            this.txtVeznedarNo.Name = "txtVeznedarNo";
            this.txtVeznedarNo.Size = new System.Drawing.Size(100, 22);
            this.txtVeznedarNo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "No:";
            // 
            // txtVeznedarSoyad
            // 
            this.txtVeznedarSoyad.Location = new System.Drawing.Point(64, 85);
            this.txtVeznedarSoyad.Name = "txtVeznedarSoyad";
            this.txtVeznedarSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtVeznedarSoyad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // txtVeznedarAd
            // 
            this.txtVeznedarAd.Location = new System.Drawing.Point(64, 57);
            this.txtVeznedarAd.Name = "txtVeznedarAd";
            this.txtVeznedarAd.Size = new System.Drawing.Size(100, 22);
            this.txtVeznedarAd.TabIndex = 3;
            // 
            // btnVeznedarKaydet
            // 
            this.btnVeznedarKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVeznedarKaydet.ForeColor = System.Drawing.SystemColors.Info;
            this.btnVeznedarKaydet.Location = new System.Drawing.Point(64, 113);
            this.btnVeznedarKaydet.Name = "btnVeznedarKaydet";
            this.btnVeznedarKaydet.Size = new System.Drawing.Size(100, 29);
            this.btnVeznedarKaydet.TabIndex = 5;
            this.btnVeznedarKaydet.Text = "Kaydet";
            this.btnVeznedarKaydet.UseVisualStyleBackColor = false;
            this.btnVeznedarKaydet.Click += new System.EventHandler(this.btnVeznedarKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // gboxFatura
            // 
            this.gboxFatura.Controls.Add(this.btnFaturaEkle);
            this.gboxFatura.Controls.Add(this.cboxOdemeTip);
            this.gboxFatura.Controls.Add(this.dtpIslem);
            this.gboxFatura.Controls.Add(this.dtpSonOdeme);
            this.gboxFatura.Controls.Add(this.txtMusteriSoyAd);
            this.gboxFatura.Controls.Add(this.txtMusteriAd);
            this.gboxFatura.Controls.Add(this.txtFaturaTutari);
            this.gboxFatura.Controls.Add(this.txtFaturaNo);
            this.gboxFatura.Location = new System.Drawing.Point(12, 291);
            this.gboxFatura.Name = "gboxFatura";
            this.gboxFatura.Size = new System.Drawing.Size(128, 269);
            this.gboxFatura.TabIndex = 4;
            this.gboxFatura.TabStop = false;
            this.gboxFatura.Text = "Fatura Bilgileri";
            this.gboxFatura.Enter += new System.EventHandler(this.gboxFatura_Enter);
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(6, 33);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(100, 22);
            this.txtFaturaNo.TabIndex = 1;
            // 
            // txtFaturaTutari
            // 
            this.txtFaturaTutari.Location = new System.Drawing.Point(6, 61);
            this.txtFaturaTutari.Name = "txtFaturaTutari";
            this.txtFaturaTutari.Size = new System.Drawing.Size(100, 22);
            this.txtFaturaTutari.TabIndex = 2;
            // 
            // txtMusteriSoyAd
            // 
            this.txtMusteriSoyAd.Location = new System.Drawing.Point(6, 204);
            this.txtMusteriSoyAd.Name = "txtMusteriSoyAd";
            this.txtMusteriSoyAd.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriSoyAd.TabIndex = 4;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(6, 176);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriAd.TabIndex = 3;
            // 
            // dtpSonOdeme
            // 
            this.dtpSonOdeme.Location = new System.Drawing.Point(6, 90);
            this.dtpSonOdeme.Name = "dtpSonOdeme";
            this.dtpSonOdeme.Size = new System.Drawing.Size(100, 22);
            this.dtpSonOdeme.TabIndex = 5;
            // 
            // cboxOdemeTip
            // 
            this.cboxOdemeTip.FormattingEnabled = true;
            this.cboxOdemeTip.Items.AddRange(new object[] {
            "KrediKarti",
            "Nakit"});
            this.cboxOdemeTip.Location = new System.Drawing.Point(6, 146);
            this.cboxOdemeTip.Name = "cboxOdemeTip";
            this.cboxOdemeTip.Size = new System.Drawing.Size(100, 24);
            this.cboxOdemeTip.TabIndex = 6;
            // 
            // dtpIslem
            // 
            this.dtpIslem.Location = new System.Drawing.Point(6, 118);
            this.dtpIslem.Name = "dtpIslem";
            this.dtpIslem.Size = new System.Drawing.Size(100, 22);
            this.dtpIslem.TabIndex = 5;
            // 
            // btnFaturaEkle
            // 
            this.btnFaturaEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFaturaEkle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnFaturaEkle.Location = new System.Drawing.Point(6, 234);
            this.btnFaturaEkle.Name = "btnFaturaEkle";
            this.btnFaturaEkle.Size = new System.Drawing.Size(100, 29);
            this.btnFaturaEkle.TabIndex = 7;
            this.btnFaturaEkle.Text = "Ekle";
            this.btnFaturaEkle.UseVisualStyleBackColor = false;
            this.btnFaturaEkle.Click += new System.EventHandler(this.btnFaturaEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 572);
            this.Controls.Add(this.gboxFatura);
            this.Controls.Add(this.gboxVeznedar);
            this.Controls.Add(this.lblBaslikMesaj);
            this.Controls.Add(this.gboxAcilis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxAcilis.ResumeLayout(false);
            this.gboxAcilis.PerformLayout();
            this.gboxVeznedar.ResumeLayout(false);
            this.gboxVeznedar.PerformLayout();
            this.gboxFatura.ResumeLayout(false);
            this.gboxFatura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxVezneSayisi;
        private System.Windows.Forms.GroupBox gboxAcilis;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label lblBaslikMesaj;
        private System.Windows.Forms.GroupBox gboxVeznedar;
        private System.Windows.Forms.Button btnVeznedarKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVeznedarNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVeznedarSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVeznedarAd;
        private System.Windows.Forms.GroupBox gboxFatura;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.TextBox txtMusteriSoyAd;
        private System.Windows.Forms.TextBox txtFaturaTutari;
        private System.Windows.Forms.ComboBox cboxOdemeTip;
        private System.Windows.Forms.DateTimePicker dtpSonOdeme;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Button btnFaturaEkle;
        private System.Windows.Forms.DateTimePicker dtpIslem;
    }
}

