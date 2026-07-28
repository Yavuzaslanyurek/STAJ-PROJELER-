namespace Adisyon
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.grpYeniSiparis = new System.Windows.Forms.GroupBox();
            this.lblUrunSec = new System.Windows.Forms.Label();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpAdisyonDetay = new System.Windows.Forms.GroupBox();
            this.lstAdisyon = new System.Windows.Forms.ListBox();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblAlinanPara = new System.Windows.Forms.Label();
            this.txtAlinanPara = new System.Windows.Forms.TextBox();
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpYeniSiparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            this.grpAdisyonDetay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(800, 60);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "LEZZET VADİSİ | Adisyon ve Hesap Ödeme Otomasyonu";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpYeniSiparis
            // 
            this.grpYeniSiparis.Controls.Add(this.lblUrunSec);
            this.grpYeniSiparis.Controls.Add(this.cmbUrunler);
            this.grpYeniSiparis.Controls.Add(this.lblAdet);
            this.grpYeniSiparis.Controls.Add(this.numAdet);
            this.grpYeniSiparis.Controls.Add(this.btnEkle);
            this.grpYeniSiparis.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpYeniSiparis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.grpYeniSiparis.Location = new System.Drawing.Point(20, 80);
            this.grpYeniSiparis.Name = "grpYeniSiparis";
            this.grpYeniSiparis.Size = new System.Drawing.Size(360, 460);
            this.grpYeniSiparis.TabIndex = 1;
            this.grpYeniSiparis.TabStop = false;
            this.grpYeniSiparis.Text = "Yeni Sipariş Girişi";
            // 
            // lblUrunSec
            // 
            this.lblUrunSec.AutoSize = true;
            this.lblUrunSec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunSec.Location = new System.Drawing.Point(20, 40);
            this.lblUrunSec.Name = "lblUrunSec";
            this.lblUrunSec.Size = new System.Drawing.Size(79, 19);
            this.lblUrunSec.TabIndex = 0;
            this.lblUrunSec.Text = "Ürün Seçin:";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(20, 65);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(320, 28);
            this.cmbUrunler.TabIndex = 1;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.Location = new System.Drawing.Point(20, 110);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(41, 19);
            this.lblAdet.TabIndex = 2;
            this.lblAdet.Text = "Adet:";
            // 
            // numAdet
            // 
            this.numAdet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numAdet.Location = new System.Drawing.Point(20, 135);
            this.numAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(320, 27);
            this.numAdet.TabIndex = 3;
            this.numAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(20, 190);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(320, 45);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Adisyona Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // grpAdisyonDetay
            // 
            this.grpAdisyonDetay.Controls.Add(this.lstAdisyon);
            this.grpAdisyonDetay.Controls.Add(this.btnUrunSil);
            this.grpAdisyonDetay.Controls.Add(this.lblToplam);
            this.grpAdisyonDetay.Controls.Add(this.lblAlinanPara);
            this.grpAdisyonDetay.Controls.Add(this.txtAlinanPara);
            this.grpAdisyonDetay.Controls.Add(this.btnHesapKapat);
            this.grpAdisyonDetay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAdisyonDetay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.grpAdisyonDetay.Location = new System.Drawing.Point(400, 80);
            this.grpAdisyonDetay.Name = "grpAdisyonDetay";
            this.grpAdisyonDetay.Size = new System.Drawing.Size(380, 460);
            this.grpAdisyonDetay.TabIndex = 2;
            this.grpAdisyonDetay.TabStop = false;
            this.grpAdisyonDetay.Text = "Adisyon Detayı & Ödeme";
            // 
            // lstAdisyon
            // 
            this.lstAdisyon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstAdisyon.FormattingEnabled = true;
            this.lstAdisyon.ItemHeight = 20;
            this.lstAdisyon.Location = new System.Drawing.Point(20, 35);
            this.lstAdisyon.Name = "lstAdisyon";
            this.lstAdisyon.Size = new System.Drawing.Size(340, 184);
            this.lstAdisyon.TabIndex = 0;
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnUrunSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunSil.FlatAppearance.BorderSize = 0;
            this.btnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.ForeColor = System.Drawing.Color.White;
            this.btnUrunSil.Location = new System.Drawing.Point(20, 230);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(340, 35);
            this.btnUrunSil.TabIndex = 1;
            this.btnUrunSil.Text = "Seçili Ürünü Sil";
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblToplam.Location = new System.Drawing.Point(20, 280);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(340, 30);
            this.lblToplam.TabIndex = 2;
            this.lblToplam.Text = "Toplam Tutar: 0.00 TL";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlinanPara
            // 
            this.lblAlinanPara.AutoSize = true;
            this.lblAlinanPara.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlinanPara.Location = new System.Drawing.Point(20, 320);
            this.lblAlinanPara.Name = "lblAlinanPara";
            this.lblAlinanPara.Size = new System.Drawing.Size(180, 19);
            this.lblAlinanPara.TabIndex = 3;
            this.lblAlinanPara.Text = "Müşteriden Alınan Para (TL):";
            // 
            // txtAlinanPara
            // 
            this.txtAlinanPara.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlinanPara.Location = new System.Drawing.Point(20, 345);
            this.txtAlinanPara.Name = "txtAlinanPara";
            this.txtAlinanPara.Size = new System.Drawing.Size(340, 27);
            this.txtAlinanPara.TabIndex = 4;
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.btnHesapKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapKapat.FlatAppearance.BorderSize = 0;
            this.btnHesapKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapKapat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapKapat.ForeColor = System.Drawing.Color.White;
            this.btnHesapKapat.Location = new System.Drawing.Point(20, 390);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(340, 45);
            this.btnHesapKapat.TabIndex = 5;
            this.btnHesapKapat.Text = "Hesabı Kapat / Ödeme Al";
            this.btnHesapKapat.UseVisualStyleBackColor = false;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.grpAdisyonDetay);
            this.Controls.Add(this.grpYeniSiparis);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adisyon ve Ödeme Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.grpYeniSiparis.ResumeLayout(false);
            this.grpYeniSiparis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            this.grpAdisyonDetay.ResumeLayout(false);
            this.grpAdisyonDetay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.GroupBox grpYeniSiparis;
        private System.Windows.Forms.Label lblUrunSec;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox grpAdisyonDetay;
        private System.Windows.Forms.ListBox lstAdisyon;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblAlinanPara;
        private System.Windows.Forms.TextBox txtAlinanPara;
        private System.Windows.Forms.Button btnHesapKapat;
    }
}
