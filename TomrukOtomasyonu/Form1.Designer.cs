using System;
using System.Drawing;
using System.Windows.Forms;

namespace TomrukOtomasyonu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogoTitle = new System.Windows.Forms.Label();
            this.lblLogoSubtitle = new System.Windows.Forms.Label();
            this.btnSayfaGiris = new System.Windows.Forms.Button();
            this.btnSayfaRaporlar = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlGirisSayfasi = new System.Windows.Forms.Panel();
            this.lblGirisBaslik = new System.Windows.Forms.Label();
            this.grpYeniTomruk = new System.Windows.Forms.GroupBox();
            this.lblAgacTuru = new System.Windows.Forms.Label();
            this.cmbAgacTuru = new System.Windows.Forms.ComboBox();
            this.lblBoy = new System.Windows.Forms.Label();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.lblCap = new System.Windows.Forms.Label();
            this.txtCap = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpMevcutList = new System.Windows.Forms.GroupBox();
            this.dgvMevcutList = new System.Windows.Forms.DataGridView();
            this.pnlMevcutListAlt = new System.Windows.Forms.Panel();
            this.lblToplamHacim = new System.Windows.Forms.Label();
            this.lblTomrukSayisi = new System.Windows.Forms.Label();
            this.btnSeciliSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydetVeAktar = new System.Windows.Forms.Button();
            this.pnlRaporlarSayfasi = new System.Windows.Forms.Panel();
            this.lblRaporlarBaslik = new System.Windows.Forms.Label();
            this.splitRaporlar = new System.Windows.Forms.SplitContainer();
            this.grpGecmisRaporlar = new System.Windows.Forms.GroupBox();
            this.lstGecmisRaporlar = new System.Windows.Forms.ListBox();
            this.btnRaporListesiYenile = new System.Windows.Forms.Button();
            this.grpRaporOnizleme = new System.Windows.Forms.GroupBox();
            this.txtRaporOnizleme = new System.Windows.Forms.TextBox();
            this.btnRaporuNotepadIleAc = new System.Windows.Forms.Button();
            this.btnRaporuSil = new System.Windows.Forms.Button();

            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlGirisSayfasi.SuspendLayout();
            this.grpYeniTomruk.SuspendLayout();
            this.grpMevcutList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutList)).BeginInit();
            this.pnlMevcutListAlt.SuspendLayout();
            this.pnlRaporlarSayfasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRaporlar)).BeginInit();
            this.splitRaporlar.Panel1.SuspendLayout();
            this.splitRaporlar.Panel2.SuspendLayout();
            this.splitRaporlar.SuspendLayout();
            this.grpGecmisRaporlar.SuspendLayout();
            this.grpRaporOnizleme.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            this.pnlSidebar.Controls.Add(this.btnSayfaRaporlar);
            this.pnlSidebar.Controls.Add(this.btnSayfaGiris);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 650);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.pnlLogo.Controls.Add(this.lblLogoSubtitle);
            this.pnlLogo.Controls.Add(this.lblLogoTitle);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(240, 80);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLogoTitle
            // 
            this.lblLogoTitle.AutoSize = true;
            this.lblLogoTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogoTitle.ForeColor = System.Drawing.Color.White;
            this.lblLogoTitle.Location = new System.Drawing.Point(16, 12);
            this.lblLogoTitle.Name = "lblLogoTitle";
            this.lblLogoTitle.Size = new System.Drawing.Size(110, 30);
            this.lblLogoTitle.TabIndex = 0;
            this.lblLogoTitle.Text = "TOMRUK";
            // 
            // lblLogoSubtitle
            // 
            this.lblLogoSubtitle.AutoSize = true;
            this.lblLogoSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblLogoSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            this.lblLogoSubtitle.Location = new System.Drawing.Point(18, 42);
            this.lblLogoSubtitle.Name = "lblLogoSubtitle";
            this.lblLogoSubtitle.Size = new System.Drawing.Size(130, 13);
            this.lblLogoSubtitle.TabIndex = 1;
            this.lblLogoSubtitle.Text = "METRAJ & OTOMASYON";
            // 
            // btnSayfaGiris
            // 
            this.btnSayfaGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(34)))));
            this.btnSayfaGiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSayfaGiris.FlatAppearance.BorderSize = 0;
            this.btnSayfaGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayfaGiris.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSayfaGiris.ForeColor = System.Drawing.Color.White;
            this.btnSayfaGiris.Location = new System.Drawing.Point(0, 80);
            this.btnSayfaGiris.Name = "btnSayfaGiris";
            this.btnSayfaGiris.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSayfaGiris.Size = new System.Drawing.Size(240, 50);
            this.btnSayfaGiris.TabIndex = 1;
            this.btnSayfaGiris.Text = "🌲  Tomruk Girişi";
            this.btnSayfaGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayfaGiris.UseVisualStyleBackColor = false;
            this.btnSayfaGiris.Click += new System.EventHandler(this.btnSayfaGiris_Click);
            // 
            // btnSayfaRaporlar
            // 
            this.btnSayfaRaporlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            this.btnSayfaRaporlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSayfaRaporlar.FlatAppearance.BorderSize = 0;
            this.btnSayfaRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayfaRaporlar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSayfaRaporlar.ForeColor = System.Drawing.Color.White;
            this.btnSayfaRaporlar.Location = new System.Drawing.Point(0, 130);
            this.btnSayfaRaporlar.Name = "btnSayfaRaporlar";
            this.btnSayfaRaporlar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSayfaRaporlar.Size = new System.Drawing.Size(240, 50);
            this.btnSayfaRaporlar.TabIndex = 2;
            this.btnSayfaRaporlar.Text = "📂  Geçmiş Raporlar";
            this.btnSayfaRaporlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayfaRaporlar.UseVisualStyleBackColor = false;
            this.btnSayfaRaporlar.Click += new System.EventHandler(this.btnSayfaRaporlar_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.pnlContent.Controls.Add(this.pnlGirisSayfasi);
            this.pnlContent.Controls.Add(this.pnlRaporlarSayfasi);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(240, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(784, 650);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlGirisSayfasi
            // 
            this.pnlGirisSayfasi.Controls.Add(this.pnlMevcutListAlt);
            this.pnlGirisSayfasi.Controls.Add(this.grpMevcutList);
            this.pnlGirisSayfasi.Controls.Add(this.grpYeniTomruk);
            this.pnlGirisSayfasi.Controls.Add(this.lblGirisBaslik);
            this.pnlGirisSayfasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGirisSayfasi.Location = new System.Drawing.Point(0, 0);
            this.pnlGirisSayfasi.Name = "pnlGirisSayfasi";
            this.pnlGirisSayfasi.Size = new System.Drawing.Size(784, 650);
            this.pnlGirisSayfasi.TabIndex = 0;
            // 
            // lblGirisBaslik
            // 
            this.lblGirisBaslik.AutoSize = true;
            this.lblGirisBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGirisBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            this.lblGirisBaslik.Location = new System.Drawing.Point(20, 20);
            this.lblGirisBaslik.Name = "lblGirisBaslik";
            this.lblGirisBaslik.Size = new System.Drawing.Size(325, 30);
            this.lblGirisBaslik.TabIndex = 0;
            this.lblGirisBaslik.Text = "Tomruk Giriş ve Ölçüm Paneli";
            // 
            // grpYeniTomruk
            // 
            this.grpYeniTomruk.Controls.Add(this.btnEkle);
            this.grpYeniTomruk.Controls.Add(this.txtCap);
            this.grpYeniTomruk.Controls.Add(this.lblCap);
            this.grpYeniTomruk.Controls.Add(this.txtBoy);
            this.grpYeniTomruk.Controls.Add(this.lblBoy);
            this.grpYeniTomruk.Controls.Add(this.cmbAgacTuru);
            this.grpYeniTomruk.Controls.Add(this.lblAgacTuru);
            this.grpYeniTomruk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpYeniTomruk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            this.grpYeniTomruk.Location = new System.Drawing.Point(20, 60);
            this.grpYeniTomruk.Name = "grpYeniTomruk";
            this.grpYeniTomruk.Size = new System.Drawing.Size(744, 100);
            this.grpYeniTomruk.TabIndex = 1;
            this.grpYeniTomruk.TabStop = false;
            this.grpYeniTomruk.Text = "Yeni Tomruk Ekle";
            // 
            // lblAgacTuru
            // 
            this.lblAgacTuru.AutoSize = true;
            this.lblAgacTuru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAgacTuru.ForeColor = System.Drawing.Color.Black;
            this.lblAgacTuru.Location = new System.Drawing.Point(15, 30);
            this.lblAgacTuru.Name = "lblAgacTuru";
            this.lblAgacTuru.Size = new System.Drawing.Size(61, 15);
            this.lblAgacTuru.TabIndex = 0;
            this.lblAgacTuru.Text = "Ağaç Türü";
            // 
            // cmbAgacTuru
            // 
            this.cmbAgacTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgacTuru.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbAgacTuru.FormattingEnabled = true;
            this.cmbAgacTuru.Location = new System.Drawing.Point(15, 52);
            this.cmbAgacTuru.Name = "cmbAgacTuru";
            this.cmbAgacTuru.Size = new System.Drawing.Size(150, 25);
            this.cmbAgacTuru.TabIndex = 1;
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBoy.ForeColor = System.Drawing.Color.Black;
            this.lblBoy.Location = new System.Drawing.Point(190, 30);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(69, 15);
            this.lblBoy.TabIndex = 2;
            this.lblBoy.Text = "Boy (Metre)";
            // 
            // txtBoy
            // 
            this.txtBoy.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtBoy.Location = new System.Drawing.Point(190, 52);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(120, 25);
            this.txtBoy.TabIndex = 3;
            this.txtBoy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSadeceSayi_KeyPress);
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCap.ForeColor = System.Drawing.Color.Black;
            this.lblCap.Location = new System.Drawing.Point(340, 30);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(54, 15);
            this.lblCap.TabIndex = 4;
            this.lblCap.Text = "Çap (Cm)";
            // 
            // txtCap
            // 
            this.txtCap.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCap.Location = new System.Drawing.Point(340, 52);
            this.txtCap.Name = "txtCap";
            this.txtCap.Size = new System.Drawing.Size(120, 25);
            this.txtCap.TabIndex = 5;
            this.txtCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSadeceSayi_KeyPress);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(490, 48);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(230, 32);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "➕ Listeye Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // grpMevcutList
            // 
            this.grpMevcutList.Controls.Add(this.dgvMevcutList);
            this.grpMevcutList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpMevcutList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            this.grpMevcutList.Location = new System.Drawing.Point(20, 180);
            this.grpMevcutList.Name = "grpMevcutList";
            this.grpMevcutList.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.grpMevcutList.Size = new System.Drawing.Size(744, 300);
            this.grpMevcutList.TabIndex = 2;
            this.grpMevcutList.TabStop = false;
            this.grpMevcutList.Text = "Mevcut Tomruk Listesi";
            // 
            // dgvMevcutList
            // 
            this.dgvMevcutList.AllowUserToAddRows = false;
            this.dgvMevcutList.AllowUserToDeleteRows = false;
            this.dgvMevcutList.BackgroundColor = System.Drawing.Color.White;
            this.dgvMevcutList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMevcutList.ColumnHeadersHeight = 32;
            this.dgvMevcutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMevcutList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMevcutList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMevcutList.Location = new System.Drawing.Point(15, 26);
            this.dgvMevcutList.MultiSelect = false;
            this.dgvMevcutList.Name = "dgvMevcutList";
            this.dgvMevcutList.ReadOnly = true;
            this.dgvMevcutList.RowHeadersVisible = false;
            this.dgvMevcutList.RowTemplate.Height = 28;
            this.dgvMevcutList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMevcutList.Size = new System.Drawing.Size(714, 259);
            this.dgvMevcutList.TabIndex = 0;
            // 
            // pnlMevcutListAlt
            // 
            this.pnlMevcutListAlt.Controls.Add(this.btnKaydetVeAktar);
            this.pnlMevcutListAlt.Controls.Add(this.btnTemizle);
            this.pnlMevcutListAlt.Controls.Add(this.btnSeciliSil);
            this.pnlMevcutListAlt.Controls.Add(this.lblTomrukSayisi);
            this.pnlMevcutListAlt.Controls.Add(this.lblToplamHacim);
            this.pnlMevcutListAlt.Location = new System.Drawing.Point(20, 490);
            this.pnlMevcutListAlt.Name = "pnlMevcutListAlt";
            this.pnlMevcutListAlt.Size = new System.Drawing.Size(744, 110);
            this.pnlMevcutListAlt.TabIndex = 3;
            // 
            // lblToplamHacim
            // 
            this.lblToplamHacim.AutoSize = true;
            this.lblToplamHacim.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblToplamHacim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            this.lblToplamHacim.Location = new System.Drawing.Point(15, 10);
            this.lblToplamHacim.Name = "lblToplamHacim";
            this.lblToplamHacim.Size = new System.Drawing.Size(225, 25);
            this.lblToplamHacim.TabIndex = 0;
            this.lblToplamHacim.Text = "Toplam Hacim: 0,000 m³";
            // 
            // lblTomrukSayisi
            // 
            this.lblTomrukSayisi.AutoSize = true;
            this.lblTomrukSayisi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTomrukSayisi.ForeColor = System.Drawing.Color.DimGray;
            this.lblTomrukSayisi.Location = new System.Drawing.Point(17, 42);
            this.lblTomrukSayisi.Name = "lblTomrukSayisi";
            this.lblTomrukSayisi.Size = new System.Drawing.Size(107, 19);
            this.lblTomrukSayisi.TabIndex = 1;
            this.lblTomrukSayisi.Text = "Toplam Adet: 0";
            // 
            // btnSeciliSil
            // 
            this.btnSeciliSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSeciliSil.FlatAppearance.BorderSize = 0;
            this.btnSeciliSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeciliSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSeciliSil.ForeColor = System.Drawing.Color.White;
            this.btnSeciliSil.Location = new System.Drawing.Point(340, 10);
            this.btnSeciliSil.Name = "btnSeciliSil";
            this.btnSeciliSil.Size = new System.Drawing.Size(130, 32);
            this.btnSeciliSil.TabIndex = 2;
            this.btnSeciliSil.Text = "🗑️ Seçileni Sil";
            this.btnSeciliSil.UseVisualStyleBackColor = false;
            this.btnSeciliSil.Click += new System.EventHandler(this.btnSeciliSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(340, 50);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(130, 32);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "🧹 Listeyi Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydetVeAktar
            // 
            this.btnKaydetVeAktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnKaydetVeAktar.FlatAppearance.BorderSize = 0;
            this.btnKaydetVeAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydetVeAktar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKaydetVeAktar.ForeColor = System.Drawing.Color.White;
            this.btnKaydetVeAktar.Location = new System.Drawing.Point(490, 10);
            this.btnKaydetVeAktar.Name = "btnKaydetVeAktar";
            this.btnKaydetVeAktar.Size = new System.Drawing.Size(240, 72);
            this.btnKaydetVeAktar.TabIndex = 4;
            this.btnKaydetVeAktar.Text = "💾 Raporu Kaydet\r\nve Dışa Aktar";
            this.btnKaydetVeAktar.UseVisualStyleBackColor = false;
            this.btnKaydetVeAktar.Click += new System.EventHandler(this.btnKaydetVeAktar_Click);
            // 
            // pnlRaporlarSayfasi
            // 
            this.pnlRaporlarSayfasi.Controls.Add(this.splitRaporlar);
            this.pnlRaporlarSayfasi.Controls.Add(this.lblRaporlarBaslik);
            this.pnlRaporlarSayfasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRaporlarSayfasi.Location = new System.Drawing.Point(0, 0);
            this.pnlRaporlarSayfasi.Name = "pnlRaporlarSayfasi";
            this.pnlRaporlarSayfasi.Size = new System.Drawing.Size(784, 650);
            this.pnlRaporlarSayfasi.TabIndex = 1;
            this.pnlRaporlarSayfasi.Visible = false;
            // 
            // lblRaporlarBaslik
            // 
            this.lblRaporlarBaslik.AutoSize = true;
            this.lblRaporlarBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRaporlarBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            this.lblRaporlarBaslik.Location = new System.Drawing.Point(20, 20);
            this.lblRaporlarBaslik.Name = "lblRaporlarBaslik";
            this.lblRaporlarBaslik.Size = new System.Drawing.Size(306, 30);
            this.lblRaporlarBaslik.TabIndex = 0;
            this.lblRaporlarBaslik.Text = "Geçmiş Raporlar ve Önizleme";
            // 
            // splitRaporlar
            // 
            this.splitRaporlar.Location = new System.Drawing.Point(20, 60);
            this.splitRaporlar.Name = "splitRaporlar";
            // 
            // splitRaporlar.Panel1
            // 
            this.splitRaporlar.Panel1.Controls.Add(this.grpGecmisRaporlar);
            // 
            // splitRaporlar.Panel2
            // 
            this.splitRaporlar.Panel2.Controls.Add(this.grpRaporOnizleme);
            this.splitRaporlar.Size = new System.Drawing.Size(744, 540);
            this.splitRaporlar.SplitterDistance = 240;
            this.splitRaporlar.TabIndex = 1;
            // 
            // grpGecmisRaporlar
            // 
            this.grpGecmisRaporlar.Controls.Add(this.btnRaporListesiYenile);
            this.grpGecmisRaporlar.Controls.Add(this.lstGecmisRaporlar);
            this.grpGecmisRaporlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGecmisRaporlar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpGecmisRaporlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            this.grpGecmisRaporlar.Location = new System.Drawing.Point(0, 0);
            this.grpGecmisRaporlar.Name = "grpGecmisRaporlar";
            this.grpGecmisRaporlar.Padding = new System.Windows.Forms.Padding(10);
            this.grpGecmisRaporlar.Size = new System.Drawing.Size(240, 540);
            this.grpGecmisRaporlar.TabIndex = 0;
            this.grpGecmisRaporlar.TabStop = false;
            this.grpGecmisRaporlar.Text = "Kayıtlı Raporlar";
            // 
            // lstGecmisRaporlar
            // 
            this.lstGecmisRaporlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGecmisRaporlar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lstGecmisRaporlar.FormattingEnabled = true;
            this.lstGecmisRaporlar.ItemHeight = 17;
            this.lstGecmisRaporlar.Location = new System.Drawing.Point(10, 25);
            this.lstGecmisRaporlar.Name = "lstGecmisRaporlar";
            this.lstGecmisRaporlar.Size = new System.Drawing.Size(220, 429);
            this.lstGecmisRaporlar.TabIndex = 0;
            this.lstGecmisRaporlar.SelectedIndexChanged += new System.EventHandler(this.lstGecmisRaporlar_SelectedIndexChanged);
            // 
            // btnRaporListesiYenile
            // 
            this.btnRaporListesiYenile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRaporListesiYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            this.btnRaporListesiYenile.FlatAppearance.BorderSize = 0;
            this.btnRaporListesiYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporListesiYenile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRaporListesiYenile.ForeColor = System.Drawing.Color.White;
            this.btnRaporListesiYenile.Location = new System.Drawing.Point(10, 480);
            this.btnRaporListesiYenile.Name = "btnRaporListesiYenile";
            this.btnRaporListesiYenile.Size = new System.Drawing.Size(220, 32);
            this.btnRaporListesiYenile.TabIndex = 1;
            this.btnRaporListesiYenile.Text = "🔄 Listeyi Yenile";
            this.btnRaporListesiYenile.UseVisualStyleBackColor = false;
            this.btnRaporListesiYenile.Click += new System.EventHandler(this.btnRaporListesiYenile_Click);
            // 
            // grpRaporOnizleme
            // 
            this.grpRaporOnizleme.Controls.Add(this.btnRaporuSil);
            this.grpRaporOnizleme.Controls.Add(this.btnRaporuNotepadIleAc);
            this.grpRaporOnizleme.Controls.Add(this.txtRaporOnizleme);
            this.grpRaporOnizleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRaporOnizleme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpRaporOnizleme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            this.grpRaporOnizleme.Location = new System.Drawing.Point(0, 0);
            this.grpRaporOnizleme.Name = "grpRaporOnizleme";
            this.grpRaporOnizleme.Padding = new System.Windows.Forms.Padding(10);
            this.grpRaporOnizleme.Size = new System.Drawing.Size(500, 540);
            this.grpRaporOnizleme.TabIndex = 0;
            this.grpRaporOnizleme.TabStop = false;
            this.grpRaporOnizleme.Text = "Rapor Önizleme";
            // 
            // txtRaporOnizleme
            // 
            this.txtRaporOnizleme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaporOnizleme.BackColor = System.Drawing.Color.White;
            this.txtRaporOnizleme.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtRaporOnizleme.Location = new System.Drawing.Point(10, 25);
            this.txtRaporOnizleme.Multiline = true;
            this.txtRaporOnizleme.Name = "txtRaporOnizleme";
            this.txtRaporOnizleme.ReadOnly = true;
            this.txtRaporOnizleme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRaporOnizleme.Size = new System.Drawing.Size(480, 429);
            this.txtRaporOnizleme.TabIndex = 0;
            this.txtRaporOnizleme.WordWrap = false;
            // 
            // btnRaporuNotepadIleAc
            // 
            this.btnRaporuNotepadIleAc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRaporuNotepadIleAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnRaporuNotepadIleAc.FlatAppearance.BorderSize = 0;
            this.btnRaporuNotepadIleAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporuNotepadIleAc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRaporuNotepadIleAc.ForeColor = System.Drawing.Color.White;
            this.btnRaporuNotepadIleAc.Location = new System.Drawing.Point(10, 480);
            this.btnRaporuNotepadIleAc.Name = "btnRaporuNotepadIleAc";
            this.btnRaporuNotepadIleAc.Size = new System.Drawing.Size(230, 32);
            this.btnRaporuNotepadIleAc.TabIndex = 1;
            this.btnRaporuNotepadIleAc.Text = "🖥️ Raporu Dışarıda Aç";
            this.btnRaporuNotepadIleAc.UseVisualStyleBackColor = false;
            this.btnRaporuNotepadIleAc.Click += new System.EventHandler(this.btnRaporuNotepadIleAc_Click);
            // 
            // btnRaporuSil
            // 
            this.btnRaporuSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRaporuSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRaporuSil.FlatAppearance.BorderSize = 0;
            this.btnRaporuSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporuSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRaporuSil.ForeColor = System.Drawing.Color.White;
            this.btnRaporuSil.Location = new System.Drawing.Point(260, 480);
            this.btnRaporuSil.Name = "btnRaporuSil";
            this.btnRaporuSil.Size = new System.Drawing.Size(230, 32);
            this.btnRaporuSil.TabIndex = 2;
            this.btnRaporuSil.Text = "🗑️ Raporu Sil";
            this.btnRaporuSil.UseVisualStyleBackColor = false;
            this.btnRaporuSil.Click += new System.EventHandler(this.btnRaporuSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 650);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tomruk Metraj ve Sınıflandırma Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlGirisSayfasi.ResumeLayout(false);
            this.pnlGirisSayfasi.PerformLayout();
            this.grpYeniTomruk.ResumeLayout(false);
            this.grpYeniTomruk.PerformLayout();
            this.grpMevcutList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutList)).EndInit();
            this.pnlMevcutListAlt.ResumeLayout(false);
            this.pnlMevcutListAlt.PerformLayout();
            this.pnlRaporlarSayfasi.ResumeLayout(false);
            this.pnlRaporlarSayfasi.PerformLayout();
            this.splitRaporlar.Panel1.ResumeLayout(false);
            this.splitRaporlar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRaporlar)).EndInit();
            this.splitRaporlar.ResumeLayout(false);
            this.grpGecmisRaporlar.ResumeLayout(false);
            this.grpRaporOnizleme.ResumeLayout(false);
            this.grpRaporOnizleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogoTitle;
        private System.Windows.Forms.Label lblLogoSubtitle;
        private System.Windows.Forms.Button btnSayfaGiris;
        private System.Windows.Forms.Button btnSayfaRaporlar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlGirisSayfasi;
        private System.Windows.Forms.Label lblGirisBaslik;
        private System.Windows.Forms.GroupBox grpYeniTomruk;
        private System.Windows.Forms.Label lblAgacTuru;
        private System.Windows.Forms.ComboBox cmbAgacTuru;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox grpMevcutList;
        private System.Windows.Forms.DataGridView dgvMevcutList;
        private System.Windows.Forms.Panel pnlMevcutListAlt;
        private System.Windows.Forms.Label lblToplamHacim;
        private System.Windows.Forms.Label lblTomrukSayisi;
        private System.Windows.Forms.Button btnSeciliSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydetVeAktar;
        private System.Windows.Forms.Panel pnlRaporlarSayfasi;
        private System.Windows.Forms.Label lblRaporlarBaslik;
        private System.Windows.Forms.SplitContainer splitRaporlar;
        private System.Windows.Forms.GroupBox grpGecmisRaporlar;
        private System.Windows.Forms.ListBox lstGecmisRaporlar;
        private System.Windows.Forms.Button btnRaporListesiYenile;
        private System.Windows.Forms.GroupBox grpRaporOnizleme;
        private System.Windows.Forms.TextBox txtRaporOnizleme;
        private System.Windows.Forms.Button btnRaporuNotepadIleAc;
        private System.Windows.Forms.Button btnRaporuSil;
    }
}
