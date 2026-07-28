namespace Otelkayıt
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlStatTotal = new System.Windows.Forms.Panel();
            this.lblStatTotalTitle = new System.Windows.Forms.Label();
            this.lblStatTotalValue = new System.Windows.Forms.Label();
            this.pnlStatDolu = new System.Windows.Forms.Panel();
            this.lblStatDoluTitle = new System.Windows.Forms.Label();
            this.lblStatDoluValue = new System.Windows.Forms.Label();
            this.pnlStatBos = new System.Windows.Forms.Panel();
            this.lblStatBosTitle = new System.Windows.Forms.Label();
            this.lblStatBosValue = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblOdaTipi = new System.Windows.Forms.Label();
            this.cmbOdaTipi = new System.Windows.Forms.ComboBox();
            this.lblSeciliOdaLabel = new System.Windows.Forms.Label();
            this.lblSeciliOda = new System.Windows.Forms.Label();
            this.btnKayitEt = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblRoomsTitle = new System.Windows.Forms.Label();
            this.flpOdalar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvKayitlar = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlStatTotal.SuspendLayout();
            this.pnlStatDolu.SuspendLayout();
            this.pnlStatBos.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKayitlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pnlStatTotal);
            this.pnlHeader.Controls.Add(this.pnlStatDolu);
            this.pnlHeader.Controls.Add(this.pnlStatBos);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1084, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ODA & KAYIT OTOMASYONU";
            // 
            // pnlStatTotal
            // 
            this.pnlStatTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlStatTotal.Controls.Add(this.lblStatTotalTitle);
            this.pnlStatTotal.Controls.Add(this.lblStatTotalValue);
            this.pnlStatTotal.Location = new System.Drawing.Point(600, 15);
            this.pnlStatTotal.Name = "pnlStatTotal";
            this.pnlStatTotal.Size = new System.Drawing.Size(140, 50);
            this.pnlStatTotal.TabIndex = 1;
            // 
            // lblStatTotalTitle
            // 
            this.lblStatTotalTitle.AutoSize = true;
            this.lblStatTotalTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblStatTotalTitle.Location = new System.Drawing.Point(10, 6);
            this.lblStatTotalTitle.Name = "lblStatTotalTitle";
            this.lblStatTotalTitle.Size = new System.Drawing.Size(77, 13);
            this.lblStatTotalTitle.TabIndex = 0;
            this.lblStatTotalTitle.Text = "TOPLAM ODA";
            // 
            // lblStatTotalValue
            // 
            this.lblStatTotalValue.AutoSize = true;
            this.lblStatTotalValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalValue.ForeColor = System.Drawing.Color.White;
            this.lblStatTotalValue.Location = new System.Drawing.Point(10, 18);
            this.lblStatTotalValue.Name = "lblStatTotalValue";
            this.lblStatTotalValue.Size = new System.Drawing.Size(38, 30);
            this.lblStatTotalValue.TabIndex = 1;
            this.lblStatTotalValue.Text = "12";
            // 
            // pnlStatDolu
            // 
            this.pnlStatDolu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatDolu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnlStatDolu.Controls.Add(this.lblStatDoluTitle);
            this.pnlStatDolu.Controls.Add(this.lblStatDoluValue);
            this.pnlStatDolu.Location = new System.Drawing.Point(760, 15);
            this.pnlStatDolu.Name = "pnlStatDolu";
            this.pnlStatDolu.Size = new System.Drawing.Size(140, 50);
            this.pnlStatDolu.TabIndex = 2;
            // 
            // lblStatDoluTitle
            // 
            this.lblStatDoluTitle.AutoSize = true;
            this.lblStatDoluTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatDoluTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblStatDoluTitle.Location = new System.Drawing.Point(10, 6);
            this.lblStatDoluTitle.Name = "lblStatDoluTitle";
            this.lblStatDoluTitle.Size = new System.Drawing.Size(61, 13);
            this.lblStatDoluTitle.TabIndex = 0;
            this.lblStatDoluTitle.Text = "DOLU ODA";
            // 
            // lblStatDoluValue
            // 
            this.lblStatDoluValue.AutoSize = true;
            this.lblStatDoluValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatDoluValue.ForeColor = System.Drawing.Color.White;
            this.lblStatDoluValue.Location = new System.Drawing.Point(10, 18);
            this.lblStatDoluValue.Name = "lblStatDoluValue";
            this.lblStatDoluValue.Size = new System.Drawing.Size(26, 30);
            this.lblStatDoluValue.TabIndex = 1;
            this.lblStatDoluValue.Text = "0";
            // 
            // pnlStatBos
            // 
            this.pnlStatBos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatBos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnlStatBos.Controls.Add(this.lblStatBosTitle);
            this.pnlStatBos.Controls.Add(this.lblStatBosValue);
            this.pnlStatBos.Location = new System.Drawing.Point(920, 15);
            this.pnlStatBos.Name = "pnlStatBos";
            this.pnlStatBos.Size = new System.Drawing.Size(140, 50);
            this.pnlStatBos.TabIndex = 3;
            // 
            // lblStatBosTitle
            // 
            this.lblStatBosTitle.AutoSize = true;
            this.lblStatBosTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatBosTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.lblStatBosTitle.Location = new System.Drawing.Point(10, 6);
            this.lblStatBosTitle.Name = "lblStatBosTitle";
            this.lblStatBosTitle.Size = new System.Drawing.Size(56, 13);
            this.lblStatBosTitle.TabIndex = 0;
            this.lblStatBosTitle.Text = "BOŞ ODA";
            // 
            // lblStatBosValue
            // 
            this.lblStatBosValue.AutoSize = true;
            this.lblStatBosValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatBosValue.ForeColor = System.Drawing.Color.White;
            this.lblStatBosValue.Location = new System.Drawing.Point(10, 18);
            this.lblStatBosValue.Name = "lblStatBosValue";
            this.lblStatBosValue.Size = new System.Drawing.Size(38, 30);
            this.lblStatBosValue.TabIndex = 1;
            this.lblStatBosValue.Text = "12";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlLeft.Controls.Add(this.lblFormTitle);
            this.pnlLeft.Controls.Add(this.lblAdSoyad);
            this.pnlLeft.Controls.Add(this.txtAdSoyad);
            this.pnlLeft.Controls.Add(this.lblTC);
            this.pnlLeft.Controls.Add(this.txtTC);
            this.pnlLeft.Controls.Add(this.lblOdaTipi);
            this.pnlLeft.Controls.Add(this.cmbOdaTipi);
            this.pnlLeft.Controls.Add(this.lblSeciliOdaLabel);
            this.pnlLeft.Controls.Add(this.lblSeciliOda);
            this.pnlLeft.Controls.Add(this.btnKayitEt);
            this.pnlLeft.Controls.Add(this.btnCikisYap);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 80);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(380, 351);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblFormTitle.Location = new System.Drawing.Point(20, 20);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(232, 21);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Müşteri / Hasta Kayıt Formu";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAdSoyad.Location = new System.Drawing.Point(20, 60);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(64, 17);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdSoyad.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtAdSoyad.Location = new System.Drawing.Point(20, 83);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(340, 26);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTC.Location = new System.Drawing.Point(20, 125);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(125, 17);
            this.lblTC.TabIndex = 3;
            this.lblTC.Text = "Kimlik No / Telefon";
            // 
            // txtTC
            // 
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTC.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTC.Location = new System.Drawing.Point(20, 148);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(340, 26);
            this.txtTC.TabIndex = 4;
            // 
            // lblOdaTipi
            // 
            this.lblOdaTipi.AutoSize = true;
            this.lblOdaTipi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblOdaTipi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblOdaTipi.Location = new System.Drawing.Point(20, 190);
            this.lblOdaTipi.Name = "lblOdaTipi";
            this.lblOdaTipi.Size = new System.Drawing.Size(107, 17);
            this.lblOdaTipi.TabIndex = 5;
            this.lblOdaTipi.Text = "Oda Tipi / Servis";
            // 
            // cmbOdaTipi
            // 
            this.cmbOdaTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdaTipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOdaTipi.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbOdaTipi.FormattingEnabled = true;
            this.cmbOdaTipi.Location = new System.Drawing.Point(20, 213);
            this.cmbOdaTipi.Name = "cmbOdaTipi";
            this.cmbOdaTipi.Size = new System.Drawing.Size(340, 27);
            this.cmbOdaTipi.TabIndex = 6;
            // 
            // lblSeciliOdaLabel
            // 
            this.lblSeciliOdaLabel.AutoSize = true;
            this.lblSeciliOdaLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblSeciliOdaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSeciliOdaLabel.Location = new System.Drawing.Point(20, 260);
            this.lblSeciliOdaLabel.Name = "lblSeciliOdaLabel";
            this.lblSeciliOdaLabel.Size = new System.Drawing.Size(81, 19);
            this.lblSeciliOdaLabel.TabIndex = 7;
            this.lblSeciliOdaLabel.Text = "Seçili Oda:";
            // 
            // lblSeciliOda
            // 
            this.lblSeciliOda.AutoSize = true;
            this.lblSeciliOda.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblSeciliOda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblSeciliOda.Location = new System.Drawing.Point(120, 260);
            this.lblSeciliOda.Name = "lblSeciliOda";
            this.lblSeciliOda.Size = new System.Drawing.Size(135, 21);
            this.lblSeciliOda.TabIndex = 8;
            this.lblSeciliOda.Text = "Seçim Yapılmadı";
            // 
            // btnKayitEt
            // 
            this.btnKayitEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnKayitEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayitEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitEt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKayitEt.ForeColor = System.Drawing.Color.White;
            this.btnKayitEt.Location = new System.Drawing.Point(20, 295);
            this.btnKayitEt.Name = "btnKayitEt";
            this.btnKayitEt.Size = new System.Drawing.Size(160, 40);
            this.btnKayitEt.TabIndex = 9;
            this.btnKayitEt.Text = "Kayıt Et";
            this.btnKayitEt.UseVisualStyleBackColor = false;
            this.btnKayitEt.Click += new System.EventHandler(this.btnKayitEt_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(225))))); // modified to red dynamically in designer code
            this.btnCikisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCikisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisYap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCikisYap.ForeColor = System.Drawing.Color.White;
            this.btnCikisYap.Location = new System.Drawing.Point(200, 295);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(160, 40);
            this.btnCikisYap.TabIndex = 10;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.lblRoomsTitle);
            this.pnlRight.Controls.Add(this.flpOdalar);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(380, 80);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(704, 351);
            this.pnlRight.TabIndex = 2;
            // 
            // lblRoomsTitle
            // 
            this.lblRoomsTitle.AutoSize = true;
            this.lblRoomsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoomsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblRoomsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRoomsTitle.Name = "lblRoomsTitle";
            this.lblRoomsTitle.Size = new System.Drawing.Size(127, 21);
            this.lblRoomsTitle.TabIndex = 0;
            this.lblRoomsTitle.Text = "Oda Durumları";
            // 
            // flpOdalar
            // 
            this.flpOdalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpOdalar.AutoScroll = true;
            this.flpOdalar.Location = new System.Drawing.Point(20, 50);
            this.flpOdalar.Name = "flpOdalar";
            this.flpOdalar.Size = new System.Drawing.Size(664, 285);
            this.flpOdalar.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.lblGridTitle);
            this.pnlBottom.Controls.Add(this.dgvKayitlar);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 431);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1084, 250);
            this.pnlBottom.TabIndex = 3;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblGridTitle.Location = new System.Drawing.Point(20, 10);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(262, 21);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Aktif Konaklayan / Hasta Kayıtları";
            // 
            // dgvKayitlar
            // 
            this.dgvKayitlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKayitlar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKayitlar.Location = new System.Drawing.Point(20, 40);
            this.dgvKayitlar.Name = "dgvKayitlar";
            this.dgvKayitlar.Size = new System.Drawing.Size(1044, 190);
            this.dgvKayitlar.TabIndex = 1;
            this.dgvKayitlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKayitlar_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel / Hastane Oda ve Kayıt Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlStatTotal.ResumeLayout(false);
            this.pnlStatTotal.PerformLayout();
            this.pnlStatDolu.ResumeLayout(false);
            this.pnlStatDolu.PerformLayout();
            this.pnlStatBos.ResumeLayout(false);
            this.pnlStatBos.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKayitlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlStatTotal;
        private System.Windows.Forms.Label lblStatTotalTitle;
        private System.Windows.Forms.Label lblStatTotalValue;
        private System.Windows.Forms.Panel pnlStatDolu;
        private System.Windows.Forms.Label lblStatDoluTitle;
        private System.Windows.Forms.Label lblStatDoluValue;
        private System.Windows.Forms.Panel pnlStatBos;
        private System.Windows.Forms.Label lblStatBosTitle;
        private System.Windows.Forms.Label lblStatBosValue;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblOdaTipi;
        private System.Windows.Forms.ComboBox cmbOdaTipi;
        private System.Windows.Forms.Label lblSeciliOdaLabel;
        private System.Windows.Forms.Label lblSeciliOda;
        private System.Windows.Forms.Button btnKayitEt;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblRoomsTitle;
        private System.Windows.Forms.FlowLayoutPanel flpOdalar;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvKayitlar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
