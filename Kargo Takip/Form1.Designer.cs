namespace Kargo_Takip
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlCreateCargo = new System.Windows.Forms.Panel();
            this.lblCreateCargoTitle = new System.Windows.Forms.Label();
            this.lblAliciAdi = new System.Windows.Forms.Label();
            this.txtAliciAdi = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnKargoOlustur = new System.Windows.Forms.Button();
            this.pnlUpdateStatus = new System.Windows.Forms.Panel();
            this.lblUpdateStatusTitle = new System.Windows.Forms.Label();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.cmbDurumGuncelle = new System.Windows.Forms.ComboBox();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvKargolar = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlCreateCargo.SuspendLayout();
            this.pnlUpdateStatus.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1050, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(434, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kargo Takip ve Yönetim Otomasyonu";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblSubtitle.Location = new System.Drawing.Point(22, 48);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(243, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Gerçek Zamanlı Bellek İçi Kargo Takip Sistemi";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlLeft.Controls.Add(this.pnlCreateCargo);
            this.pnlLeft.Controls.Add(this.pnlUpdateStatus);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 80);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(15);
            this.pnlLeft.Size = new System.Drawing.Size(320, 570);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlCreateCargo
            // 
            this.pnlCreateCargo.BackColor = System.Drawing.Color.White;
            this.pnlCreateCargo.Controls.Add(this.lblCreateCargoTitle);
            this.pnlCreateCargo.Controls.Add(this.lblAliciAdi);
            this.pnlCreateCargo.Controls.Add(this.txtAliciAdi);
            this.pnlCreateCargo.Controls.Add(this.lblAdres);
            this.pnlCreateCargo.Controls.Add(this.txtAdres);
            this.pnlCreateCargo.Controls.Add(this.btnKargoOlustur);
            this.pnlCreateCargo.Location = new System.Drawing.Point(15, 15);
            this.pnlCreateCargo.Name = "pnlCreateCargo";
            this.pnlCreateCargo.Size = new System.Drawing.Size(290, 275);
            this.pnlCreateCargo.TabIndex = 0;
            // 
            // lblCreateCargoTitle
            // 
            this.lblCreateCargoTitle.AutoSize = true;
            this.lblCreateCargoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCreateCargoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCreateCargoTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCreateCargoTitle.Name = "lblCreateCargoTitle";
            this.lblCreateCargoTitle.Size = new System.Drawing.Size(126, 21);
            this.lblCreateCargoTitle.TabIndex = 0;
            this.lblCreateCargoTitle.Text = "Yeni Kargo Ekle";
            // 
            // lblAliciAdi
            // 
            this.lblAliciAdi.AutoSize = true;
            this.lblAliciAdi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAliciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblAliciAdi.Location = new System.Drawing.Point(15, 50);
            this.lblAliciAdi.Name = "lblAliciAdi";
            this.lblAliciAdi.Size = new System.Drawing.Size(110, 17);
            this.lblAliciAdi.TabIndex = 1;
            this.lblAliciAdi.Text = "Alıcı Adı Soyadı:";
            // 
            // txtAliciAdi
            // 
            this.txtAliciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAliciAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAliciAdi.Location = new System.Drawing.Point(15, 70);
            this.txtAliciAdi.Name = "txtAliciAdi";
            this.txtAliciAdi.Size = new System.Drawing.Size(260, 25);
            this.txtAliciAdi.TabIndex = 2;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblAdres.Location = new System.Drawing.Point(15, 110);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(107, 17);
            this.lblAdres.TabIndex = 3;
            this.lblAdres.Text = "Teslimat Adresi:";
            // 
            // txtAdres
            // 
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdres.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAdres.Location = new System.Drawing.Point(15, 130);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdres.Size = new System.Drawing.Size(260, 75);
            this.txtAdres.TabIndex = 4;
            // 
            // btnKargoOlustur
            // 
            this.btnKargoOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnKargoOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKargoOlustur.FlatAppearance.BorderSize = 0;
            this.btnKargoOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKargoOlustur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKargoOlustur.ForeColor = System.Drawing.Color.White;
            this.btnKargoOlustur.Location = new System.Drawing.Point(15, 220);
            this.btnKargoOlustur.Name = "btnKargoOlustur";
            this.btnKargoOlustur.Size = new System.Drawing.Size(260, 38);
            this.btnKargoOlustur.TabIndex = 5;
            this.btnKargoOlustur.Text = "Kargo Oluştur";
            this.btnKargoOlustur.UseVisualStyleBackColor = false;
            this.btnKargoOlustur.Click += new System.EventHandler(this.btnKargoOlustur_Click);
            // 
            // pnlUpdateStatus
            // 
            this.pnlUpdateStatus.BackColor = System.Drawing.Color.White;
            this.pnlUpdateStatus.Controls.Add(this.lblUpdateStatusTitle);
            this.pnlUpdateStatus.Controls.Add(this.lblNewStatus);
            this.pnlUpdateStatus.Controls.Add(this.cmbDurumGuncelle);
            this.pnlUpdateStatus.Controls.Add(this.btnDurumGuncelle);
            this.pnlUpdateStatus.Location = new System.Drawing.Point(15, 305);
            this.pnlUpdateStatus.Name = "pnlUpdateStatus";
            this.pnlUpdateStatus.Size = new System.Drawing.Size(290, 185);
            this.pnlUpdateStatus.TabIndex = 1;
            // 
            // lblUpdateStatusTitle
            // 
            this.lblUpdateStatusTitle.AutoSize = true;
            this.lblUpdateStatusTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpdateStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUpdateStatusTitle.Location = new System.Drawing.Point(15, 15);
            this.lblUpdateStatusTitle.Name = "lblUpdateStatusTitle";
            this.lblUpdateStatusTitle.Size = new System.Drawing.Size(132, 21);
            this.lblUpdateStatusTitle.TabIndex = 0;
            this.lblUpdateStatusTitle.Text = "Durum Güncelle";
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNewStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblNewStatus.Location = new System.Drawing.Point(15, 50);
            this.lblNewStatus.Name = "lblNewStatus";
            this.lblNewStatus.Size = new System.Drawing.Size(122, 17);
            this.lblNewStatus.TabIndex = 1;
            this.lblNewStatus.Text = "Yeni Durum Seçin:";
            // 
            // cmbDurumGuncelle
            // 
            this.cmbDurumGuncelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurumGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDurumGuncelle.FormattingEnabled = true;
            this.cmbDurumGuncelle.Location = new System.Drawing.Point(15, 70);
            this.cmbDurumGuncelle.Name = "cmbDurumGuncelle";
            this.cmbDurumGuncelle.Size = new System.Drawing.Size(260, 25);
            this.cmbDurumGuncelle.TabIndex = 2;
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDurumGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDurumGuncelle.FlatAppearance.BorderSize = 0;
            this.btnDurumGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurumGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDurumGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnDurumGuncelle.Location = new System.Drawing.Point(15, 125);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(260, 38);
            this.btnDurumGuncelle.TabIndex = 3;
            this.btnDurumGuncelle.Text = "Durumu Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = false;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlGrid);
            this.pnlMain.Controls.Add(this.pnlSearch);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(320, 80);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(730, 570);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvKargolar);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 70);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.pnlGrid.Size = new System.Drawing.Size(730, 500);
            this.pnlGrid.TabIndex = 1;
            // 
            // dgvKargolar
            // 
            this.dgvKargolar.AllowUserToAddRows = false;
            this.dgvKargolar.AllowUserToDeleteRows = false;
            this.dgvKargolar.AllowUserToResizeRows = false;
            this.dgvKargolar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKargolar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKargolar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKargolar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.dgvKargolar.Location = new System.Drawing.Point(20, 0);
            this.dgvKargolar.MultiSelect = false;
            this.dgvKargolar.Name = "dgvKargolar";
            this.dgvKargolar.ReadOnly = true;
            this.dgvKargolar.RowHeadersVisible = false;
            this.dgvKargolar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKargolar.Size = new System.Drawing.Size(690, 480);
            this.dgvKargolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKargolar.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtArama);
            this.pnlSearch.Controls.Add(this.btnAra);
            this.pnlSearch.Controls.Add(this.btnTemizle);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(730, 70);
            this.pnlSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSearch.Location = new System.Drawing.Point(20, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(79, 19);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Kargo Ara:";
            // 
            // txtArama
            // 
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArama.Location = new System.Drawing.Point(105, 23);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(280, 25);
            this.txtArama.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(395, 21);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(90, 29);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(495, 21);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(90, 29);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo Takip ve Yönetim Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlCreateCargo.ResumeLayout(false);
            this.pnlCreateCargo.PerformLayout();
            this.pnlUpdateStatus.ResumeLayout(false);
            this.pnlUpdateStatus.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlCreateCargo;
        private System.Windows.Forms.Label lblCreateCargoTitle;
        private System.Windows.Forms.Label lblAliciAdi;
        private System.Windows.Forms.TextBox txtAliciAdi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnKargoOlustur;
        private System.Windows.Forms.Panel pnlUpdateStatus;
        private System.Windows.Forms.Label lblUpdateStatusTitle;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.ComboBox cmbDurumGuncelle;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvKargolar;
    }
}
