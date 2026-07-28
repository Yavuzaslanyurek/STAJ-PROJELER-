namespace BiletRezervasyon
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
            this.pnlSeats = new System.Windows.Forms.Panel();
            this.lblScreen = new System.Windows.Forms.Label();
            this.pnlSeatContainer = new System.Windows.Forms.Panel();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.lblLegendEmpty = new System.Windows.Forms.Label();
            this.lblLegendSelected = new System.Windows.Forms.Label();
            this.lblLegendOccupied = new System.Windows.Forms.Label();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.lblSefer = new System.Windows.Forms.Label();
            this.cmbSefer = new System.Windows.Forms.ComboBox();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblSecilenKoltuk = new System.Windows.Forms.Label();
            this.txtSecilenKoltuk = new System.Windows.Forms.TextBox();
            this.btnBiletKes = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.pnlTickets = new System.Windows.Forms.Panel();
            this.lblTicketsHeader = new System.Windows.Forms.Label();
            this.lstBiletler = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlSeats.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.pnlOperations.SuspendLayout();
            this.pnlTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstBiletler)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(904, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(904, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bilet Rezervasyon & Koltuk Seçim Otomasyonu";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSeats
            // 
            this.pnlSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.pnlSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSeats.Controls.Add(this.lblScreen);
            this.pnlSeats.Controls.Add(this.pnlSeatContainer);
            this.pnlSeats.Controls.Add(this.pnlLegend);
            this.pnlSeats.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSeats.Location = new System.Drawing.Point(0, 65);
            this.pnlSeats.Name = "pnlSeats";
            this.pnlSeats.Size = new System.Drawing.Size(430, 546);
            this.pnlSeats.TabIndex = 1;
            // 
            // lblScreen
            // 
            this.lblScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScreen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lblScreen.Location = new System.Drawing.Point(20, 20);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(388, 30);
            this.lblScreen.TabIndex = 0;
            this.lblScreen.Text = "EKRAN / YOL ÖNÜ";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSeatContainer
            // 
            this.pnlSeatContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.pnlSeatContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSeatContainer.Location = new System.Drawing.Point(20, 65);
            this.pnlSeatContainer.Name = "pnlSeatContainer";
            this.pnlSeatContainer.Size = new System.Drawing.Size(388, 385);
            this.pnlSeatContainer.TabIndex = 1;
            // 
            // pnlLegend
            // 
            this.pnlLegend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.pnlLegend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLegend.Controls.Add(this.lblLegendEmpty);
            this.pnlLegend.Controls.Add(this.lblLegendSelected);
            this.pnlLegend.Controls.Add(this.lblLegendOccupied);
            this.pnlLegend.Location = new System.Drawing.Point(20, 465);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(388, 60);
            this.pnlLegend.TabIndex = 2;
            // 
            // lblLegendEmpty
            // 
            this.lblLegendEmpty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblLegendEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLegendEmpty.ForeColor = System.Drawing.Color.White;
            this.lblLegendEmpty.Location = new System.Drawing.Point(15, 15);
            this.lblLegendEmpty.Name = "lblLegendEmpty";
            this.lblLegendEmpty.Size = new System.Drawing.Size(100, 30);
            this.lblLegendEmpty.TabIndex = 0;
            this.lblLegendEmpty.Text = "Boş";
            this.lblLegendEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLegendSelected
            // 
            this.lblLegendSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblLegendSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLegendSelected.ForeColor = System.Drawing.Color.White;
            this.lblLegendSelected.Location = new System.Drawing.Point(143, 15);
            this.lblLegendSelected.Name = "lblLegendSelected";
            this.lblLegendSelected.Size = new System.Drawing.Size(100, 30);
            this.lblLegendSelected.TabIndex = 1;
            this.lblLegendSelected.Text = "Seçili";
            this.lblLegendSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLegendOccupied
            // 
            this.lblLegendOccupied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblLegendOccupied.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLegendOccupied.ForeColor = System.Drawing.Color.White;
            this.lblLegendOccupied.Location = new System.Drawing.Point(271, 15);
            this.lblLegendOccupied.Name = "lblLegendOccupied";
            this.lblLegendOccupied.Size = new System.Drawing.Size(100, 30);
            this.lblLegendOccupied.TabIndex = 2;
            this.lblLegendOccupied.Text = "Dolu";
            this.lblLegendOccupied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOperations
            // 
            this.pnlOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.pnlOperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOperations.Controls.Add(this.lblSefer);
            this.pnlOperations.Controls.Add(this.cmbSefer);
            this.pnlOperations.Controls.Add(this.lblMusteriAdi);
            this.pnlOperations.Controls.Add(this.txtMusteriAdi);
            this.pnlOperations.Controls.Add(this.lblTC);
            this.pnlOperations.Controls.Add(this.txtTC);
            this.pnlOperations.Controls.Add(this.lblSecilenKoltuk);
            this.pnlOperations.Controls.Add(this.txtSecilenKoltuk);
            this.pnlOperations.Controls.Add(this.btnBiletKes);
            this.pnlOperations.Controls.Add(this.btnIptal);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(430, 65);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(474, 250);
            this.pnlOperations.TabIndex = 2;
            // 
            // lblSefer
            // 
            this.lblSefer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSefer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblSefer.Location = new System.Drawing.Point(20, 20);
            this.lblSefer.Name = "lblSefer";
            this.lblSefer.Size = new System.Drawing.Size(120, 25);
            this.lblSefer.TabIndex = 0;
            this.lblSefer.Text = "Film / Sefer:";
            this.lblSefer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSefer
            // 
            this.cmbSefer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.cmbSefer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSefer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSefer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSefer.ForeColor = System.Drawing.Color.White;
            this.cmbSefer.FormattingEnabled = true;
            this.cmbSefer.Location = new System.Drawing.Point(160, 20);
            this.cmbSefer.Name = "cmbSefer";
            this.cmbSefer.Size = new System.Drawing.Size(290, 25);
            this.cmbSefer.TabIndex = 1;
            this.cmbSefer.SelectedIndexChanged += new System.EventHandler(this.CmbSefer_SelectedIndexChanged);
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMusteriAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblMusteriAdi.Location = new System.Drawing.Point(20, 60);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(120, 25);
            this.lblMusteriAdi.TabIndex = 2;
            this.lblMusteriAdi.Text = "Ad Soyad:";
            this.lblMusteriAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.txtMusteriAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMusteriAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMusteriAdi.ForeColor = System.Drawing.Color.White;
            this.txtMusteriAdi.Location = new System.Drawing.Point(160, 60);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(290, 25);
            this.txtMusteriAdi.TabIndex = 3;
            // 
            // lblTC
            // 
            this.lblTC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblTC.Location = new System.Drawing.Point(20, 100);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(120, 25);
            this.lblTC.TabIndex = 4;
            this.lblTC.Text = "T.C. / Telefon:";
            this.lblTC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTC.ForeColor = System.Drawing.Color.White;
            this.txtTC.Location = new System.Drawing.Point(160, 100);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(290, 25);
            this.txtTC.TabIndex = 5;
            // 
            // lblSecilenKoltuk
            // 
            this.lblSecilenKoltuk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSecilenKoltuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblSecilenKoltuk.Location = new System.Drawing.Point(20, 140);
            this.lblSecilenKoltuk.Name = "lblSecilenKoltuk";
            this.lblSecilenKoltuk.Size = new System.Drawing.Size(120, 25);
            this.lblSecilenKoltuk.TabIndex = 6;
            this.lblSecilenKoltuk.Text = "Seçilen Koltuk:";
            this.lblSecilenKoltuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSecilenKoltuk
            // 
            this.txtSecilenKoltuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.txtSecilenKoltuk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecilenKoltuk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtSecilenKoltuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.txtSecilenKoltuk.Location = new System.Drawing.Point(160, 140);
            this.txtSecilenKoltuk.Name = "txtSecilenKoltuk";
            this.txtSecilenKoltuk.ReadOnly = true;
            this.txtSecilenKoltuk.Size = new System.Drawing.Size(290, 25);
            this.txtSecilenKoltuk.TabIndex = 7;
            // 
            // btnBiletKes
            // 
            this.btnBiletKes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnBiletKes.FlatAppearance.BorderSize = 0;
            this.btnBiletKes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiletKes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBiletKes.ForeColor = System.Drawing.Color.White;
            this.btnBiletKes.Location = new System.Drawing.Point(160, 185);
            this.btnBiletKes.Name = "btnBiletKes";
            this.btnBiletKes.Size = new System.Drawing.Size(135, 40);
            this.btnBiletKes.TabIndex = 8;
            this.btnBiletKes.Text = "Bilet Kes";
            this.btnBiletKes.UseVisualStyleBackColor = false;
            this.btnBiletKes.Click += new System.EventHandler(this.BtnBiletKes_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(315, 185);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(135, 40);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "Bilet İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // pnlTickets
            // 
            this.pnlTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.pnlTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTickets.Controls.Add(this.lblTicketsHeader);
            this.pnlTickets.Controls.Add(this.lstBiletler);
            this.pnlTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTickets.Location = new System.Drawing.Point(430, 315);
            this.pnlTickets.Name = "pnlTickets";
            this.pnlTickets.Size = new System.Drawing.Size(474, 296);
            this.pnlTickets.TabIndex = 3;
            // 
            // lblTicketsHeader
            // 
            this.lblTicketsHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTicketsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblTicketsHeader.Location = new System.Drawing.Point(20, 10);
            this.lblTicketsHeader.Name = "lblTicketsHeader";
            this.lblTicketsHeader.Size = new System.Drawing.Size(200, 20);
            this.lblTicketsHeader.TabIndex = 0;
            this.lblTicketsHeader.Text = "KESİLEN BİLETLER";
            this.lblTicketsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstBiletler
            // 
            this.lstBiletler.AllowUserToAddRows = false;
            this.lstBiletler.AllowUserToDeleteRows = false;
            this.lstBiletler.AllowUserToResizeRows = false;
            this.lstBiletler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBiletler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.lstBiletler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBiletler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstBiletler.Location = new System.Drawing.Point(20, 35);
            this.lstBiletler.MultiSelect = false;
            this.lstBiletler.Name = "lstBiletler";
            this.lstBiletler.ReadOnly = true;
            this.lstBiletler.RowHeadersVisible = false;
            this.lstBiletler.RowTemplate.Height = 25;
            this.lstBiletler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstBiletler.Size = new System.Drawing.Size(430, 240);
            this.lstBiletler.TabIndex = 1;
            this.lstBiletler.SelectionChanged += new System.EventHandler(this.LstBiletler_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(904, 611);
            this.Controls.Add(this.pnlTickets);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.pnlSeats);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon & Koltuk Seçim Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlSeats.ResumeLayout(false);
            this.pnlLegend.ResumeLayout(false);
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.pnlTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstBiletler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSeats;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Panel pnlSeatContainer;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Label lblLegendEmpty;
        private System.Windows.Forms.Label lblLegendSelected;
        private System.Windows.Forms.Label lblLegendOccupied;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Label lblSefer;
        private System.Windows.Forms.ComboBox cmbSefer;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblSecilenKoltuk;
        private System.Windows.Forms.TextBox txtSecilenKoltuk;
        private System.Windows.Forms.Button btnBiletKes;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Panel pnlTickets;
        private System.Windows.Forms.Label lblTicketsHeader;
        private System.Windows.Forms.DataGridView lstBiletler;
    }
}
