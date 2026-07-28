using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TomrukOtomasyonu
{
    public partial class Form1 : Form
    {
        // Current log items in memory
        private BindingList<TomrukItem> tomruklar = new BindingList<TomrukItem>();
        
        // Folder where reports are saved
        private string reportsPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up reports path inside executable directory
            reportsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Raporlar");
            if (!Directory.Exists(reportsPath))
            {
                Directory.CreateDirectory(reportsPath);
            }

            // Populate Tree Species combobox
            cmbAgacTuru.Items.Clear();
            cmbAgacTuru.Items.AddRange(new string[] { "Çam", "Göknar", "Meşe", "Kayın", "Ladin" });
            cmbAgacTuru.SelectedIndex = 0;

            // Configure DataGridView properties and bind to list
            StyleDataGridView();
            ConfigureColumns();
            dgvMevcutList.DataSource = tomruklar;

            // Update footer totals
            GuncelleToplamlar();

            // Initial load of history reports
            YukleGecmisRaporlar();
        }

        #region Custom Styling and Configurations

        private void StyleDataGridView()
        {
            dgvMevcutList.AutoGenerateColumns = false;
            dgvMevcutList.EnableHeadersVisualStyles = false;
            
            // Grid Header styling
            dgvMevcutList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(19, 46, 22);
            dgvMevcutList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMevcutList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgvMevcutList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            // Cell styling
            dgvMevcutList.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular);
            dgvMevcutList.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 245, 233);
            dgvMevcutList.DefaultCellStyle.SelectionForeColor = Color.Black;
            
            // Alternating rows styling
            dgvMevcutList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 245);
            
            // Borders and Colors
            dgvMevcutList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMevcutList.GridColor = Color.FromArgb(220, 225, 220);
            
            dgvMevcutList.RowHeadersVisible = false;
            dgvMevcutList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMevcutList.MultiSelect = false;
            dgvMevcutList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ConfigureColumns()
        {
            dgvMevcutList.Columns.Clear();

            DataGridViewTextBoxColumn colTuru = new DataGridViewTextBoxColumn();
            colTuru.DataPropertyName = "AgacTuru";
            colTuru.HeaderText = "Ağaç Türü";
            colTuru.Name = "AgacTuru";
            colTuru.FillWeight = 100;
            dgvMevcutList.Columns.Add(colTuru);

            DataGridViewTextBoxColumn colBoy = new DataGridViewTextBoxColumn();
            colBoy.DataPropertyName = "Boy";
            colBoy.HeaderText = "Boy (m)";
            colBoy.Name = "Boy";
            colBoy.FillWeight = 80;
            dgvMevcutList.Columns.Add(colBoy);

            DataGridViewTextBoxColumn colCap = new DataGridViewTextBoxColumn();
            colCap.DataPropertyName = "Cap";
            colCap.HeaderText = "Çap (cm)";
            colCap.Name = "Cap";
            colCap.FillWeight = 80;
            dgvMevcutList.Columns.Add(colCap);

            DataGridViewTextBoxColumn colHacim = new DataGridViewTextBoxColumn();
            colHacim.DataPropertyName = "Hacim";
            colHacim.HeaderText = "Hacim (m³)";
            colHacim.Name = "Hacim";
            colHacim.FillWeight = 100;
            colHacim.DefaultCellStyle.Format = "N3";
            dgvMevcutList.Columns.Add(colHacim);

            DataGridViewTextBoxColumn colSinif = new DataGridViewTextBoxColumn();
            colSinif.DataPropertyName = "Sinif";
            colSinif.HeaderText = "Sınıf";
            colSinif.Name = "Sinif";
            colSinif.FillWeight = 140;
            dgvMevcutList.Columns.Add(colSinif);
        }

        private void GuncelleToplamlar()
        {
            double toplamHacim = tomruklar.Sum(t => t.Hacim);
            lblToplamHacim.Text = $"Toplam Hacim: {toplamHacim:N3} m³";
            lblTomrukSayisi.Text = $"Toplam Adet: {tomruklar.Count}";
        }

        private void SayfaDegistir(bool girisSayfasiActive)
        {
            if (girisSayfasiActive)
            {
                pnlGirisSayfasi.Visible = true;
                pnlGirisSayfasi.BringToFront();
                pnlRaporlarSayfasi.Visible = false;

                btnSayfaGiris.BackColor = Color.FromArgb(30, 70, 34); // Active Dark Green
                btnSayfaRaporlar.BackColor = Color.FromArgb(19, 46, 22); // Inactive Darker Green
            }
            else
            {
                pnlRaporlarSayfasi.Visible = true;
                pnlRaporlarSayfasi.BringToFront();
                pnlGirisSayfasi.Visible = false;

                btnSayfaRaporlar.BackColor = Color.FromArgb(30, 70, 34); // Active
                btnSayfaGiris.BackColor = Color.FromArgb(19, 46, 22); // Inactive
            }
        }

        #endregion

        #region Sayısal Giriş Doğrulama (Validation)

        private void txtSadeceSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, control keys (backspace), dot and comma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Only allow one decimal separator (dot or comma)
            TextBox txt = sender as TextBox;
            if (txt != null && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                if (txt.Text.Contains(".") || txt.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
        }

        private bool TryParseOndalik(string text, out double value)
        {
            value = 0;
            if (string.IsNullOrWhiteSpace(text)) return false;

            // Replace dot and comma with system decimal separator
            string decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string cleanedText = text.Replace(".", decimalSeparator).Replace(",", decimalSeparator).Trim();

            return double.TryParse(cleanedText, out value);
        }

        #endregion

        #region Event Handlers - Tomruk Giriş Sayfası

        private void btnSayfaGiris_Click(object sender, EventArgs e)
        {
            SayfaDegistir(true);
        }

        private void btnSayfaRaporlar_Click(object sender, EventArgs e)
        {
            SayfaDegistir(false);
            YukleGecmisRaporlar();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string agacTuru = cmbAgacTuru.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(agacTuru))
            {
                MessageBox.Show("Lütfen bir ağaç türü seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryParseOndalik(txtBoy.Text, out double boy) || boy <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir tomruk boyu giriniz (m) (Örn: 4.0 veya 2.5).", "Hatalı Değer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoy.Focus();
                return;
            }

            if (!TryParseOndalik(txtCap.Text, out double cap) || cap <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir tomruk çapı giriniz (cm) (Örn: 30).", "Hatalı Değer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCap.Focus();
                return;
            }

            // Create log item and add it to our list
            TomrukItem item = new TomrukItem
            {
                AgacTuru = agacTuru,
                Boy = boy,
                Cap = cap
            };

            tomruklar.Add(item);
            GuncelleToplamlar();

            // Clear input fields for next entry
            txtBoy.Clear();
            txtCap.Clear();
            cmbAgacTuru.Focus();
        }

        private void btnSeciliSil_Click(object sender, EventArgs e)
        {
            if (dgvMevcutList.SelectedRows.Count > 0)
            {
                var seciliSatir = dgvMevcutList.SelectedRows[0];
                var seciliTomruk = seciliSatir.DataBoundItem as TomrukItem;
                if (seciliTomruk != null)
                {
                    tomruklar.Remove(seciliTomruk);
                    GuncelleToplamlar();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı tabloda seçiniz.", "Seçim Yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (tomruklar.Count == 0) return;

            DialogResult dr = MessageBox.Show("Mevcut tomruk listesini tamamen temizlemek istediğinize emin misiniz?", "Listeyi Temizle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tomruklar.Clear();
                GuncelleToplamlar();
            }
        }

        private void btnKaydetVeAktar_Click(object sender, EventArgs e)
        {
            if (tomruklar.Count == 0)
            {
                MessageBox.Show("Listede kaydedilecek tomruk verisi bulunmamaktadır.", "Boş Liste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generate report content
            string dosyaAdi = $"Rapor_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string tamYol = Path.Combine(reportsPath, dosyaAdi);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=========================================================================");
            sb.AppendLine("                 TOMRUK METRAJ VE SINIFLANDIRMA RAPORU                  ");
            sb.AppendLine("=========================================================================");
            sb.AppendLine($"Tarih/Saat: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
            sb.AppendLine($"Klasör:     {reportsPath}");
            sb.AppendLine("-------------------------------------------------------------------------");
            sb.AppendLine(string.Format("{0,-15} | {1,-10} | {2,-10} | {3,-12} | {4,-20}", "Ağaç Türü", "Boy (m)", "Çap (cm)", "Hacim (m³)", "Sınıf"));
            sb.AppendLine("-------------------------------------------------------------------------");
            
            foreach (var t in tomruklar)
            {
                sb.AppendLine(string.Format("{0,-15} | {1,-10:N2} | {2,-10:N1} | {3,-12:N3} | {4,-20}", 
                    t.AgacTuru, t.Boy, t.Cap, t.Hacim, t.Sinif));
            }
            sb.AppendLine("-------------------------------------------------------------------------");

            // Group totals
            double uzunHacim = tomruklar.Where(t => t.Sinif == "Uzun Boy Tomruk").Sum(t => t.Hacim);
            int uzunAdet = tomruklar.Count(t => t.Sinif == "Uzun Boy Tomruk");

            double kisaHacim = tomruklar.Where(t => t.Sinif == "Kısa Boy Tomruk").Sum(t => t.Hacim);
            int kisaAdet = tomruklar.Count(t => t.Sinif == "Kısa Boy Tomruk");

            double kagitHacim = tomruklar.Where(t => t.Sinif == "Kağıtlık Odun").Sum(t => t.Hacim);
            int kagitAdet = tomruklar.Count(t => t.Sinif == "Kağıtlık Odun");

            double genelHacim = tomruklar.Sum(t => t.Hacim);
            int genelAdet = tomruklar.Count;

            sb.AppendLine("GRUP TOPLAMLARI:");
            sb.AppendLine("-------------------------------------------------------------------------");
            sb.AppendLine(string.Format("Uzun Boy Tomruk  => Adet: {0,-4} | Toplam Hacim: {1:N3} m³", uzunAdet, uzunHacim));
            sb.AppendLine(string.Format("Kısa Boy Tomruk  => Adet: {0,-4} | Toplam Hacim: {1:N3} m³", kisaAdet, kisaHacim));
            sb.AppendLine(string.Format("Kağıtlık Odun    => Adet: {0,-4} | Toplam Hacim: {1:N3} m³", kagitAdet, kagitHacim));
            sb.AppendLine("-------------------------------------------------------------------------");
            sb.AppendLine(string.Format("GENEL TOPLAM     => Adet: {0,-4} | Toplam Hacim: {1:N3} m³", genelAdet, genelHacim));
            sb.AppendLine("=========================================================================");

            try
            {
                File.WriteAllText(tamYol, sb.ToString(), Encoding.UTF8);
                MessageBox.Show($"Rapor başarıyla kaydedildi:\n{dosyaAdi}", "Rapor Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear current list
                tomruklar.Clear();
                GuncelleToplamlar();

                // Go to page 2 (Reports), reload list, and select the newly created report
                SayfaDegistir(false);
                YukleGecmisRaporlar();

                // Find the saved report in the list and select it
                for (int i = 0; i < lstGecmisRaporlar.Items.Count; i++)
                {
                    var fileItem = lstGecmisRaporlar.Items[i] as RaporDosyasi;
                    if (fileItem != null && fileItem.DosyaAdi == dosyaAdi)
                    {
                        lstGecmisRaporlar.SelectedIndex = i;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rapor kaydedilirken bir hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Event Handlers - Geçmiş Raporlar Sayfası

        private void YukleGecmisRaporlar()
        {
            lstGecmisRaporlar.Items.Clear();
            txtRaporOnizleme.Clear();

            if (!Directory.Exists(reportsPath)) return;

            // Load files ending with .txt sorted descending by their name (newest first)
            var dosyalar = Directory.GetFiles(reportsPath, "Rapor_*.txt")
                                    .Select(d => new FileInfo(d))
                                    .OrderByDescending(f => f.Name)
                                    .ToList();

            foreach (var d in dosyalar)
            {
                RaporDosyasi item = new RaporDosyasi
                {
                    DosyaAdi = d.Name,
                    TamYol = d.FullName,
                    OlusturmaTarihi = GetRaporTarihi(d.Name, d.FullName)
                };
                lstGecmisRaporlar.Items.Add(item);
            }
        }

        private DateTime GetRaporTarihi(string dosyaAdi, string tamYol)
        {
            try
            {
                // Format: Rapor_yyyyMMdd_HHmmss.txt
                if (dosyaAdi.StartsWith("Rapor_") && dosyaAdi.Length >= 21)
                {
                    string datePart = dosyaAdi.Substring(6, 8);  // yyyyMMdd
                    string timePart = dosyaAdi.Substring(15, 6); // HHmmss
                    
                    int yil = int.Parse(datePart.Substring(0, 4));
                    int ay = int.Parse(datePart.Substring(4, 2));
                    int gun = int.Parse(datePart.Substring(6, 2));
                    
                    int saat = int.Parse(timePart.Substring(0, 2));
                    int dak = int.Parse(timePart.Substring(2, 2));
                    int sn = int.Parse(timePart.Substring(4, 2));
                    
                    return new DateTime(yil, ay, gun, saat, dak, sn);
                }
            }
            catch
            {
                // Fallback to file creation date if naming parsing fails
            }
            return File.GetCreationTime(tamYol);
        }

        private void lstGecmisRaporlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secili = lstGecmisRaporlar.SelectedItem as RaporDosyasi;
            if (secili != null)
            {
                try
                {
                    if (File.Exists(secili.TamYol))
                    {
                        txtRaporOnizleme.Text = File.ReadAllText(secili.TamYol, Encoding.UTF8);
                    }
                    else
                    {
                        txtRaporOnizleme.Text = "Seçili rapor dosyası diskte bulunamadı.";
                    }
                }
                catch (Exception ex)
                {
                    txtRaporOnizleme.Text = $"Rapor okunurken bir hata oluştu:\n{ex.Message}";
                }
            }
            else
            {
                txtRaporOnizleme.Clear();
            }
        }

        private void btnRaporListesiYenile_Click(object sender, EventArgs e)
        {
            YukleGecmisRaporlar();
        }

        private void btnRaporuNotepadIleAc_Click(object sender, EventArgs e)
        {
            var secili = lstGecmisRaporlar.SelectedItem as RaporDosyasi;
            if (secili == null)
            {
                MessageBox.Show("Lütfen dışarıda açmak istediğiniz raporu listeden seçiniz.", "Seçim Yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (File.Exists(secili.TamYol))
                {
                    System.Diagnostics.Process.Start(secili.TamYol);
                }
                else
                {
                    MessageBox.Show("Seçili rapor dosyası diskte bulunamadı.", "Dosya Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rapor açılırken hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRaporuSil_Click(object sender, EventArgs e)
        {
            var secili = lstGecmisRaporlar.SelectedItem as RaporDosyasi;
            if (secili == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz raporu listeden seçiniz.", "Seçim Yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show($"Seçili raporu ({secili.DosyaAdi}) kalıcı olarak silmek istediğinize emin misiniz?", "Raporu Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    if (File.Exists(secili.TamYol))
                    {
                        File.Delete(secili.TamYol);
                    }
                    YukleGecmisRaporlar();
                    MessageBox.Show("Rapor başarıyla silindi.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dosya silinirken hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }

    #region Helper Models

    public class TomrukItem
    {
        public string AgacTuru { get; set; }
        public double Boy { get; set; }
        public double Cap { get; set; }

        // Hacim (m³) = π * (Çap / 200)² * Boy (Rounded to 3 decimals)
        public double Hacim => Math.Round(Math.PI * Math.Pow(Cap / 200.0, 2) * Boy, 3);

        // Classification Logic
        public string Sinif
        {
            get
            {
                if (Cap < 20)
                {
                    return "Kağıtlık Odun";
                }
                else
                {
                    if (Boy >= 4.0 && Cap >= 30)
                    {
                        return "Uzun Boy Tomruk";
                    }
                    else
                    {
                        return "Kısa Boy Tomruk";
                    }
                }
            }
        }
    }

    public class RaporDosyasi
    {
        public string DosyaAdi { get; set; }
        public string TamYol { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

        public override string ToString()
        {
            return $"{OlusturmaTarihi:dd.MM.yyyy HH:mm:ss}";
        }
    }

    #endregion
}
