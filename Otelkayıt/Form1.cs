using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otelkayıt
{
    public partial class Form1 : Form
    {
        // Model for stays / registrations
        public class Kayit
        {
            public string OdaNo { get; set; }
            public string AdSoyad { get; set; }
            public string TC { get; set; }
            public string OdaTipi { get; set; }
            public DateTime KayitTarihi { get; set; }
        }

        // Dictionary to track room registrations: Key is OdaNo (e.g. "101"), Value is Kayit object
        private Dictionary<string, Kayit> odaKayitlari = new Dictionary<string, Kayit>();

        // BindingList linked to DataGridView
        private BindingList<Kayit> aktifKayitlar = new BindingList<Kayit>();

        // Currently selected room number
        private string seciliOdaNo = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate ComboBox options
            cmbOdaTipi.Items.AddRange(new object[] {
                "Standart Oda / Normal Servis",
                "Suit Oda / Yoğun Bakım",
                "Kral Dairesi / VIP Servis",
                "Paylaşımlı Oda / Acil Gözlem"
            });
            if (cmbOdaTipi.Items.Count > 0)
                cmbOdaTipi.SelectedIndex = 0;

            // Configure Grid Columns programmatically to ensure precision
            dgvKayitlar.AutoGenerateColumns = false;
            dgvKayitlar.Columns.Clear();

            dgvKayitlar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "OdaNo",
                HeaderText = "Oda No",
                Name = "OdaNo",
                Width = 90,
                ReadOnly = true
            });

            dgvKayitlar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "AdSoyad",
                HeaderText = "Müşteri / Hasta Ad Soyad",
                Name = "AdSoyad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });

            dgvKayitlar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TC",
                HeaderText = "T.C. Kimlik / Telefon",
                Name = "TC",
                Width = 180,
                ReadOnly = true
            });

            dgvKayitlar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "OdaTipi",
                HeaderText = "Oda Tipi / Servis",
                Name = "OdaTipi",
                Width = 220,
                ReadOnly = true
            });

            dgvKayitlar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "KayitTarihi",
                HeaderText = "Giriş Zamanı",
                Name = "KayitTarihi",
                Width = 160,
                ReadOnly = true
            });

            // Style grid
            StyleGrid();

            // Bind Data Source
            dgvKayitlar.DataSource = aktifKayitlar;

            // Create rooms layout
            OlusturOdaButtonlari();

            // Initial stats calculation
            GuncelleIstatistikler();
        }

        private void StyleGrid()
        {
            dgvKayitlar.ReadOnly = true;
            dgvKayitlar.AllowUserToAddRows = false;
            dgvKayitlar.AllowUserToDeleteRows = false;
            dgvKayitlar.AllowUserToResizeRows = false;
            dgvKayitlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKayitlar.MultiSelect = false;
            dgvKayitlar.BackgroundColor = Color.White;
            dgvKayitlar.BorderStyle = BorderStyle.None;
            dgvKayitlar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKayitlar.GridColor = Color.FromArgb(226, 232, 240);
            dgvKayitlar.RowHeadersVisible = false;
            dgvKayitlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKayitlar.ColumnHeadersHeight = 36;
            dgvKayitlar.RowTemplate.Height = 32;

            dgvKayitlar.EnableHeadersVisualStyles = false;
            dgvKayitlar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgvKayitlar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKayitlar.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dgvKayitlar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            dgvKayitlar.DefaultCellStyle.BackColor = Color.White;
            dgvKayitlar.DefaultCellStyle.ForeColor = Color.FromArgb(71, 85, 105);
            dgvKayitlar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dgvKayitlar.DefaultCellStyle.SelectionForeColor = Color.FromArgb(29, 78, 216);
            dgvKayitlar.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);

            dgvKayitlar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
        }

        private void OlusturOdaButtonlari()
        {
            flpOdalar.Controls.Clear();
            for (int i = 101; i <= 112; i++)
            {
                Button btn = new Button();
                btn.Name = "btnOda" + i;
                btn.Text = "Oda " + i;
                btn.Tag = i.ToString();
                btn.Size = new Size(130, 75);
                btn.Margin = new Padding(8);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.Cursor = Cursors.Hand;

                // Set green color initially (Boş)
                btn.BackColor = Color.FromArgb(46, 204, 113);

                btn.Click += Oda_Click;
                btn.MouseEnter += Oda_MouseEnter;
                btn.MouseLeave += Oda_MouseLeave;

                flpOdalar.Controls.Add(btn);
            }
        }

        private void Oda_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            seciliOdaNo = btn.Tag.ToString();
            lblSeciliOda.Text = "Oda " + seciliOdaNo;

            GuncelleOdaSecimleri();
            errorProvider1.Clear();

            // If room is occupied, load occupant info
            if (odaKayitlari.ContainsKey(seciliOdaNo))
            {
                Kayit kayit = odaKayitlari[seciliOdaNo];
                txtAdSoyad.Text = kayit.AdSoyad;
                txtTC.Text = kayit.TC;
                cmbOdaTipi.SelectedItem = kayit.OdaTipi;
            }
            else
            {
                // Clear fields for empty room
                txtAdSoyad.Clear();
                txtTC.Clear();
                if (cmbOdaTipi.Items.Count > 0)
                    cmbOdaTipi.SelectedIndex = 0;
            }
        }

        private void Oda_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string odaNo = btn.Tag.ToString();
            bool dolu = odaKayitlari.ContainsKey(odaNo);

            if (dolu)
            {
                btn.BackColor = Color.FromArgb(192, 57, 43); // Darker Red
            }
            else
            {
                btn.BackColor = Color.FromArgb(39, 174, 96); // Darker Green
            }
        }

        private void Oda_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string odaNo = btn.Tag.ToString();
            bool dolu = odaKayitlari.ContainsKey(odaNo);

            if (dolu)
            {
                btn.BackColor = Color.FromArgb(231, 76, 60); // Flat Red
            }
            else
            {
                btn.BackColor = Color.FromArgb(46, 204, 113); // Flat Green
            }
        }

        private void GuncelleOdaSecimleri()
        {
            foreach (Control control in flpOdalar.Controls)
            {
                if (control is Button btn)
                {
                    string odaNo = btn.Tag.ToString();
                    if (odaNo == seciliOdaNo)
                    {
                        btn.FlatAppearance.BorderSize = 3;
                        btn.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235); // Accent Blue Border
                    }
                    else
                    {
                        btn.FlatAppearance.BorderSize = 0;
                    }
                }
            }
        }

        private void GuncelleOdaRenkleri()
        {
            foreach (Control control in flpOdalar.Controls)
            {
                if (control is Button btn)
                {
                    string odaNo = btn.Tag.ToString();
                    bool dolu = odaKayitlari.ContainsKey(odaNo);

                    if (dolu)
                    {
                        btn.BackColor = Color.FromArgb(231, 76, 60); // Flat Red
                    }
                    else
                    {
                        btn.BackColor = Color.FromArgb(46, 204, 113); // Flat Green
                    }
                }
            }
            GuncelleOdaSecimleri();
        }

        private void GuncelleIstatistikler()
        {
            int toplamOda = 12;
            int doluOda = odaKayitlari.Count;
            int bosOda = toplamOda - doluOda;

            lblStatTotalValue.Text = toplamOda.ToString();
            lblStatDoluValue.Text = doluOda.ToString();
            lblStatBosValue.Text = bosOda.ToString();
        }

        private void TemizleForm()
        {
            seciliOdaNo = null;
            lblSeciliOda.Text = "Seçim Yapılmadı";
            txtAdSoyad.Clear();
            txtTC.Clear();
            if (cmbOdaTipi.Items.Count > 0)
                cmbOdaTipi.SelectedIndex = 0;

            errorProvider1.Clear();
            GuncelleOdaSecimleri();
        }

        private bool ValidasyonKontrolu()
        {
            bool gecerli = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(seciliOdaNo))
            {
                MessageBox.Show("Lütfen öncelikle sağ taraftan bir oda seçiniz.", "Oda Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gecerli = false;
                return gecerli;
            }

            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                errorProvider1.SetError(txtAdSoyad, "Ad Soyad alanı boş bırakılamaz.");
                gecerli = false;
            }
            else if (txtAdSoyad.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txtAdSoyad, "Ad Soyad en az 3 karakter olmalıdır.");
                gecerli = false;
            }

            string tcText = txtTC.Text.Trim();
            if (string.IsNullOrWhiteSpace(tcText))
            {
                errorProvider1.SetError(txtTC, "Kimlik No / Telefon alanı boş bırakılamaz.");
                gecerli = false;
            }
            else if (!tcText.All(char.IsDigit))
            {
                errorProvider1.SetError(txtTC, "Kimlik No / Telefon sadece rakamlardan oluşmalıdır.");
                gecerli = false;
            }
            else if (tcText.Length < 10 || tcText.Length > 11)
            {
                errorProvider1.SetError(txtTC, "Kimlik No / Telefon 10 veya 11 haneli olmalıdır.");
                gecerli = false;
            }

            if (cmbOdaTipi.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbOdaTipi, "Lütfen oda tipi seçiniz.");
                gecerli = false;
            }

            return gecerli;
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
            if (!ValidasyonKontrolu())
                return;

            string adSoyad = txtAdSoyad.Text.Trim();
            string tc = txtTC.Text.Trim();
            string odaTipi = cmbOdaTipi.SelectedItem.ToString();

            Kayit yeniKayit = new Kayit
            {
                OdaNo = seciliOdaNo,
                AdSoyad = adSoyad,
                TC = tc,
                OdaTipi = odaTipi,
                KayitTarihi = DateTime.Now
            };

            if (odaKayitlari.ContainsKey(seciliOdaNo))
            {
                // Update occupant in room
                var existing = aktifKayitlar.FirstOrDefault(k => k.OdaNo == seciliOdaNo);
                if (existing != null)
                {
                    aktifKayitlar.Remove(existing);
                }
                odaKayitlari[seciliOdaNo] = yeniKayit;
                aktifKayitlar.Add(yeniKayit);
                MessageBox.Show($"Oda {seciliOdaNo} kaydı başarıyla güncellendi.", "Kayıt Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Register occupant in room
                odaKayitlari.Add(seciliOdaNo, yeniKayit);
                aktifKayitlar.Add(yeniKayit);
                MessageBox.Show($"Oda {seciliOdaNo} için yeni kayıt başarıyla oluşturuldu.", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GuncelleOdaRenkleri();
            GuncelleIstatistikler();
            TemizleForm();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seciliOdaNo))
            {
                MessageBox.Show("Lütfen çıkış işlemi yapılacak odayı seçiniz.", "Oda Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!odaKayitlari.ContainsKey(seciliOdaNo))
            {
                MessageBox.Show($"Oda {seciliOdaNo} zaten boş.", "Oda Zaten Boş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Oda {seciliOdaNo} için kayıt çıkışını onaylıyor musunuz?", "Çıkış İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                odaKayitlari.Remove(seciliOdaNo);

                var existing = aktifKayitlar.FirstOrDefault(k => k.OdaNo == seciliOdaNo);
                if (existing != null)
                {
                    aktifKayitlar.Remove(existing);
                }

                MessageBox.Show($"Oda {seciliOdaNo} çıkış işlemi tamamlandı.", "Çıkış Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GuncelleOdaRenkleri();
                GuncelleIstatistikler();
                TemizleForm();
            }
        }

        private void dgvKayitlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvKayitlar.SelectedRows.Count > 0)
            {
                var row = dgvKayitlar.SelectedRows[0];
                if (row.Cells["OdaNo"].Value != null)
                {
                    string odaNo = row.Cells["OdaNo"].Value.ToString();
                    seciliOdaNo = odaNo;
                    lblSeciliOda.Text = "Oda " + seciliOdaNo;
                    GuncelleOdaSecimleri();

                    if (odaKayitlari.ContainsKey(seciliOdaNo))
                    {
                        Kayit kayit = odaKayitlari[seciliOdaNo];
                        txtAdSoyad.Text = kayit.AdSoyad;
                        txtTC.Text = kayit.TC;
                        cmbOdaTipi.SelectedItem = kayit.OdaTipi;
                    }
                }
            }
        }
    }
}
