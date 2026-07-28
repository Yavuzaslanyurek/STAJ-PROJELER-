using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BiletRezervasyon
{
    public partial class Form1 : Form
    {
        // Sefer ve Bilet modelleri
        public class Sefer
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            // Koltuk No -> Bilet eşleştirmesi
            public Dictionary<int, Bilet> OccupiedSeats { get; set; } = new Dictionary<int, Bilet>();

            public Sefer(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public override string ToString()
            {
                return $"{Name} ({Price:C2})";
            }
        }

        public class Bilet
        {
            public string MusteriAdi { get; set; }
            public string MusteriTC { get; set; }
            public string SeferName { get; set; }
            public int KoltukNo { get; set; }
            public decimal Fiyat { get; set; }
        }

        private List<Sefer> seferler = new List<Sefer>();
        private List<Bilet> tumBiletler = new List<Bilet>();
        private List<Button> seatButtons = new List<Button>();
        private int secilenKoltukNo = -1;
        private bool isUpdatingSelection = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Seferleri Tanımla
            seferler.Add(new Sefer("Salon 1 - Matrix", 150.00m));
            seferler.Add(new Sefer("Salon 2 - Inception", 150.00m));
            seferler.Add(new Sefer("Otobüs - İstanbul Seferi", 500.00m));
            seferler.Add(new Sefer("Otobüs - Ankara Seferi", 450.00m));

            // ComboBox Doldur
            cmbSefer.DataSource = seferler;

            // Grid Sütunlarını Ayarla
            SetupTicketGrid();

            // Koltukları Oluştur
            CreateSeats();

            // İlk Durum
            UpdateSeatColors();
        }

        private void SetupTicketGrid()
        {
            lstBiletler.Columns.Clear();
            lstBiletler.AutoGenerateColumns = false;

            var colMusteri = new DataGridViewTextBoxColumn
            {
                Name = "MusteriAdi",
                HeaderText = "Müşteri Adı",
                DataPropertyName = "MusteriAdi",
                Width = 110
            };
            var colTC = new DataGridViewTextBoxColumn
            {
                Name = "MusteriTC",
                HeaderText = "T.C. / Tel",
                DataPropertyName = "MusteriTC",
                Width = 90
            };
            var colSefer = new DataGridViewTextBoxColumn
            {
                Name = "SeferName",
                HeaderText = "Sefer",
                DataPropertyName = "SeferName",
                Width = 130
            };
            var colKoltuk = new DataGridViewTextBoxColumn
            {
                Name = "KoltukNo",
                HeaderText = "Koltuk",
                DataPropertyName = "KoltukNo",
                Width = 55
            };
            var colFiyat = new DataGridViewTextBoxColumn
            {
                Name = "Fiyat",
                HeaderText = "Fiyat",
                DataPropertyName = "Fiyat",
                Width = 60
            };

            lstBiletler.Columns.AddRange(colMusteri, colTC, colSefer, colKoltuk, colFiyat);

            // Görsel İyileştirmeler
            lstBiletler.EnableHeadersVisualStyles = false;
            lstBiletler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 37, 50);
            lstBiletler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            lstBiletler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lstBiletler.DefaultCellStyle.BackColor = Color.FromArgb(34, 40, 52);
            lstBiletler.DefaultCellStyle.ForeColor = Color.White;
            lstBiletler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            lstBiletler.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void CreateSeats()
        {
            int rows = 4;
            int cols = 5;
            int seatWidth = 60;
            int seatHeight = 60;
            int colGap = 12;
            int rowGap = 20;

            int startX = (pnlSeatContainer.Width - (cols * seatWidth + (cols - 1) * colGap)) / 2;
            int startY = (pnlSeatContainer.Height - (rows * seatHeight + (rows - 1) * rowGap)) / 2;

            pnlSeatContainer.Controls.Clear();
            seatButtons.Clear();

            for (int i = 0; i < 20; i++)
            {
                int row = i / cols;
                int col = i % cols;
                int seatNo = i + 1;

                Button btn = new Button
                {
                    Width = seatWidth,
                    Height = seatHeight,
                    Left = startX + col * (seatWidth + colGap),
                    Top = startY + row * (seatHeight + rowGap),
                    Text = "Koltuk " + seatNo,
                    Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand,
                    Tag = seatNo
                };

                btn.FlatAppearance.BorderSize = 0;
                btn.Click += Seat_Click;

                pnlSeatContainer.Controls.Add(btn);
                seatButtons.Add(btn);
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            if (isUpdatingSelection) return;

            Button btn = sender as Button;
            if (btn == null) return;

            int seatNo = (int)btn.Tag;
            Sefer seciliSefer = cmbSefer.SelectedItem as Sefer;
            if (seciliSefer == null) return;

            if (seciliSefer.OccupiedSeats.ContainsKey(seatNo))
            {
                // Dolu koltuğa tıklandı. İptal kolaylığı için textbox'a ata.
                txtSecilenKoltuk.Text = seatNo.ToString();
                secilenKoltukNo = -1;

                // İlgili biletin gridde seçilmesini sağla
                SelectTicketInGrid(seciliSefer.Name, seatNo);
            }
            else
            {
                // Boş koltuk tıklandı -> Seçim moduna al
                secilenKoltukNo = seatNo;
                txtSecilenKoltuk.Text = seatNo.ToString();
            }

            UpdateSeatColors();
        }

        private void SelectTicketInGrid(string seferName, int koltukNo)
        {
            isUpdatingSelection = true;
            try
            {
                foreach (DataGridViewRow row in lstBiletler.Rows)
                {
                    if (row.Cells["SeferName"].Value.ToString() == seferName &&
                        Convert.ToInt32(row.Cells["KoltukNo"].Value) == koltukNo)
                    {
                        row.Selected = true;
                        txtMusteriAdi.Text = row.Cells["MusteriAdi"].Value.ToString();
                        txtTC.Text = row.Cells["MusteriTC"].Value.ToString();
                        break;
                    }
                }
            }
            finally
            {
                isUpdatingSelection = false;
            }
        }

        private void UpdateSeatColors()
        {
            Sefer seciliSefer = cmbSefer.SelectedItem as Sefer;
            if (seciliSefer == null) return;

            for (int i = 0; i < seatButtons.Count; i++)
            {
                int seatNo = i + 1;
                Button btn = seatButtons[i];

                if (seciliSefer.OccupiedSeats.ContainsKey(seatNo))
                {
                    // Dolu
                    btn.BackColor = Color.FromArgb(239, 68, 68);
                    btn.ForeColor = Color.White;
                }
                else if (seatNo == secilenKoltukNo)
                {
                    // Geçici Seçili
                    btn.BackColor = Color.FromArgb(59, 130, 246);
                    btn.ForeColor = Color.White;
                }
                else
                {
                    // Boş
                    btn.BackColor = Color.FromArgb(16, 185, 129);
                    btn.ForeColor = Color.White;
                }
            }
        }

        private void RefreshTicketGrid()
        {
            isUpdatingSelection = true;
            try
            {
                lstBiletler.Rows.Clear();
                foreach (var bilet in tumBiletler)
                {
                    lstBiletler.Rows.Add(
                        bilet.MusteriAdi,
                        bilet.MusteriTC,
                        bilet.SeferName,
                        bilet.KoltukNo,
                        bilet.Fiyat.ToString("C2")
                    );
                }
            }
            finally
            {
                isUpdatingSelection = false;
            }
        }

        private void CmbSefer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdatingSelection) return;

            secilenKoltukNo = -1;
            txtSecilenKoltuk.Clear();
            txtMusteriAdi.Clear();
            txtTC.Clear();
            UpdateSeatColors();
        }

        private void BtnBiletKes_Click(object sender, EventArgs e)
        {
            Sefer seciliSefer = cmbSefer.SelectedItem as Sefer;
            if (seciliSefer == null)
            {
                MessageBox.Show("Lütfen geçerli bir Sefer seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMusteriAdi.Text))
            {
                MessageBox.Show("Lütfen Müşteri Adı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTC.Text))
            {
                MessageBox.Show("Lütfen T.C. Kimlik / Telefon girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (secilenKoltukNo == -1)
            {
                MessageBox.Show("Lütfen boş bir koltuk seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (seciliSefer.OccupiedSeats.ContainsKey(secilenKoltukNo))
            {
                MessageBox.Show("Seçilen koltuk zaten dolu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Bilet Kaydet
            Bilet bilet = new Bilet
            {
                MusteriAdi = txtMusteriAdi.Text.Trim(),
                MusteriTC = txtTC.Text.Trim(),
                SeferName = seciliSefer.Name,
                KoltukNo = secilenKoltukNo,
                Fiyat = seciliSefer.Price
            };

            seciliSefer.OccupiedSeats[secilenKoltukNo] = bilet;
            tumBiletler.Add(bilet);

            RefreshTicketGrid();

            // Alanları Temizle
            secilenKoltukNo = -1;
            txtSecilenKoltuk.Clear();
            txtMusteriAdi.Clear();
            txtTC.Clear();

            UpdateSeatColors();

            MessageBox.Show("Bilet başarıyla kesildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            Sefer seciliSefer = cmbSefer.SelectedItem as Sefer;
            int iptalKoltukNo = -1;

            // 1. Textbox'taki koltuk numarasını kontrol et
            if (int.TryParse(txtSecilenKoltuk.Text, out int seatVal))
            {
                iptalKoltukNo = seatVal;
            }

            // 2. Eğer textbox boş veya geçersizse griddeki seçili satırdan bilet bul
            if (iptalKoltukNo == -1 && lstBiletler.SelectedRows.Count > 0)
            {
                var row = lstBiletler.SelectedRows[0];
                string seferName = row.Cells["SeferName"].Value.ToString();
                int koltukNo = Convert.ToInt32(row.Cells["KoltukNo"].Value);

                Sefer targetSefer = seferler.FirstOrDefault(s => s.Name == seferName);
                if (targetSefer != null && targetSefer.OccupiedSeats.ContainsKey(koltukNo))
                {
                    var bilet = targetSefer.OccupiedSeats[koltukNo];
                    targetSefer.OccupiedSeats.Remove(koltukNo);
                    tumBiletler.Remove(bilet);

                    RefreshTicketGrid();
                    secilenKoltukNo = -1;
                    txtSecilenKoltuk.Clear();
                    txtMusteriAdi.Clear();
                    txtTC.Clear();
                    UpdateSeatColors();

                    MessageBox.Show("Bilet başarıyla iptal edildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // 3. Textbox'taki değere göre iptal et
            if (iptalKoltukNo != -1 && seciliSefer != null)
            {
                if (seciliSefer.OccupiedSeats.ContainsKey(iptalKoltukNo))
                {
                    var bilet = seciliSefer.OccupiedSeats[iptalKoltukNo];
                    seciliSefer.OccupiedSeats.Remove(iptalKoltukNo);
                    tumBiletler.Remove(bilet);

                    RefreshTicketGrid();
                    secilenKoltukNo = -1;
                    txtSecilenKoltuk.Clear();
                    txtMusteriAdi.Clear();
                    txtTC.Clear();
                    UpdateSeatColors();

                    MessageBox.Show("Bilet başarıyla iptal edildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seçilen koltuk zaten boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen iptal etmek istediğiniz dolu koltuğu seçin veya bilet listesinden tıklayın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LstBiletler_SelectionChanged(object sender, EventArgs e)
        {
            if (isUpdatingSelection) return;

            if (lstBiletler.SelectedRows.Count > 0)
            {
                isUpdatingSelection = true;
                try
                {
                    var row = lstBiletler.SelectedRows[0];
                    string seferName = row.Cells["SeferName"].Value.ToString();
                    string koltukNoStr = row.Cells["KoltukNo"].Value.ToString();
                    string musteriAdi = row.Cells["MusteriAdi"].Value.ToString();
                    string musteriTC = row.Cells["MusteriTC"].Value.ToString();

                    Sefer targetSefer = seferler.FirstOrDefault(s => s.Name == seferName);
                    if (targetSefer != null)
                    {
                        cmbSefer.SelectedItem = targetSefer;
                    }

                    txtSecilenKoltuk.Text = koltukNoStr;
                    txtMusteriAdi.Text = musteriAdi;
                    txtTC.Text = musteriTC;
                    secilenKoltukNo = -1;

                    UpdateSeatColors();
                }
                finally
                {
                    isUpdatingSelection = false;
                }
            }
        }
    }
}
