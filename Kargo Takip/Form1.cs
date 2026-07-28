using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Kargo_Takip
{
    public partial class Form1 : Form
    {
        // Bellekte kargo verilerini tutacak liste
        private List<Kargo> kargoListesi = new List<Kargo>();
        
        // Rastgele sayı üretici
        private static readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ComboBox Durum seçeneklerini yükle
            cmbDurumGuncelle.Items.AddRange(new object[] {
                "Hazırlanıyor",
                "Kargoya Verildi",
                "Dağıtımda",
                "Teslim Edildi"
            });
            cmbDurumGuncelle.SelectedIndex = 0;

            // Örnek başlangıç verileri ekle
            OrnekKargoVerileriEkle();

            // DataGridView görsel ayarlarını yap
            GridStiliniYapilandir();

            // Buton Hover Efektlerini Bağla
            ButonHoverEfektleriniBagla();

            // Verileri listele
            VerileriListele(kargoListesi);
        }

        #region Veri Listeleme ve Stil Ayarları

        private void GridStiliniYapilandir()
        {
            dgvKargolar.AutoGenerateColumns = false;
            dgvKargolar.Columns.Clear();

            // Kolon tanımlamaları
            DataGridViewTextBoxColumn colTakipNo = new DataGridViewTextBoxColumn();
            colTakipNo.DataPropertyName = "TakipNo";
            colTakipNo.HeaderText = "Takip No";
            colTakipNo.Name = "TakipNo";
            colTakipNo.FillWeight = 80F;

            DataGridViewTextBoxColumn colAlici = new DataGridViewTextBoxColumn();
            colAlici.DataPropertyName = "AliciAdi";
            colAlici.HeaderText = "Alıcı Adı Soyadı";
            colAlici.Name = "AliciAdi";
            colAlici.FillWeight = 110F;

            DataGridViewTextBoxColumn colAdres = new DataGridViewTextBoxColumn();
            colAdres.DataPropertyName = "TeslimAdresi";
            colAdres.HeaderText = "Teslimat Adresi";
            colAdres.Name = "TeslimAdresi";
            colAdres.FillWeight = 180F;

            DataGridViewTextBoxColumn colDurum = new DataGridViewTextBoxColumn();
            colDurum.DataPropertyName = "Durum";
            colDurum.HeaderText = "Durum";
            colDurum.Name = "Durum";
            colDurum.FillWeight = 90F;

            dgvKargolar.Columns.AddRange(new DataGridViewColumn[] {
                colTakipNo,
                colAlici,
                colAdres,
                colDurum
            });

            // Modern Grid Tasarım Detayları
            dgvKargolar.EnableHeadersVisualStyles = false;
            dgvKargolar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvKargolar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKargolar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvKargolar.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dgvKargolar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvKargolar.ColumnHeadersHeight = 40;

            // Satır yükseklik ve yazı tipi ayarları
            dgvKargolar.RowTemplate.Height = 36;
            dgvKargolar.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvKargolar.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
            dgvKargolar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvKargolar.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternatif Satır Rengi
            dgvKargolar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);

            // Hücre renklendirme olayı (Durumlara göre renklendirme)
            dgvKargolar.CellFormatting += DgvKargolar_CellFormatting;
        }

        private void DgvKargolar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvKargolar.Columns[e.ColumnIndex].Name == "Durum" && e.Value != null)
            {
                string durum = e.Value.ToString();
                e.CellStyle.Font = new Font(dgvKargolar.Font, FontStyle.Bold);

                switch (durum)
                {
                    case "Hazırlanıyor":
                        e.CellStyle.ForeColor = Color.FromArgb(230, 126, 34); // Turuncu
                        break;
                    case "Kargoya Verildi":
                        e.CellStyle.ForeColor = Color.FromArgb(52, 152, 219); // Mavi
                        break;
                    case "Dağıtımda":
                        e.CellStyle.ForeColor = Color.FromArgb(155, 89, 182); // Mor
                        break;
                    case "Teslim Edildi":
                        e.CellStyle.ForeColor = Color.FromArgb(46, 204, 113); // Yeşil
                        break;
                }
            }
        }

        private void VerileriListele(List<Kargo> liste)
        {
            dgvKargolar.DataSource = null;
            dgvKargolar.DataSource = liste.ToList(); // Listeyi kopyalayarak bağla
        }

        private void OrnekKargoVerileriEkle()
        {
            kargoListesi.Add(new Kargo(RastgeleTakipNoUret(), "Ahmet Yılmaz", "Atatürk Mah. Fatih Cad. No:12 Daire:4, Kadıköy / İstanbul", "Teslim Edildi"));
            kargoListesi.Add(new Kargo(RastgeleTakipNoUret(), "Elif Kaya", "Cumhuriyet Cad. Menekşe Sok. No:5, Çankaya / Ankara", "Dağıtımda"));
            kargoListesi.Add(new Kargo(RastgeleTakipNoUret(), "Mehmet Demir", "Hürriyet Mah. Vatan Bulvarı No:45, Nilüfer / Bursa", "Kargoya Verildi"));
            kargoListesi.Add(new Kargo(RastgeleTakipNoUret(), "Zeynep Çelik", "Mevlana Cad. Gül Sokak No:9, Selçuklu / Konya", "Hazırlanıyor"));
        }

        #endregion

        #region Kargo Oluşturma

        private void btnKargoOlustur_Click(object sender, EventArgs e)
        {
            string alici = txtAliciAdi.Text.Trim();
            string adres = txtAdres.Text.Trim();

            // Validasyon
            if (string.IsNullOrEmpty(alici))
            {
                GosterUyari("Lütfen alıcı adı ve soyadını giriniz.", "Eksik Bilgi");
                txtAliciAdi.Focus();
                return;
            }

            if (string.IsNullOrEmpty(adres))
            {
                GosterUyari("Lütfen teslimat adresini giriniz.", "Eksik Bilgi");
                txtAdres.Focus();
                return;
            }

            // Yeni kargo oluştur
            string takipNo = RastgeleTakipNoUret();
            Kargo yeniKargo = new Kargo(takipNo, alici, adres, "Hazırlanıyor");
            kargoListesi.Add(yeniKargo);

            // UI güncelle
            VerileriListele(kargoListesi);
            TemizleKargoGirisleri();

            GosterBilgi($"Kargo başarıyla oluşturuldu!\nTakip No: {takipNo}", "Kargo Oluşturuldu");
        }

        private void TemizleKargoGirisleri()
        {
            txtAliciAdi.Clear();
            txtAdres.Clear();
        }

        private string RastgeleTakipNoUret()
        {
            const string karakterler = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789"; // Okunabilirliği zor karakterler (0, O, 1, I vb.) elenmiştir
            string kod;
            do
            {
                char[] chars = new char[8];
                for (int i = 0; i < 8; i++)
                {
                    chars[i] = karakterler[random.Next(karakterler.Length)];
                }
                kod = new string(chars);
            } while (kargoListesi.Any(k => k.TakipNo == kod)); // Benzersizlik garantisi
            
            return kod;
        }

        #endregion

        #region Durum Güncelleme

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvKargolar.SelectedRows.Count == 0)
            {
                GosterUyari("Lütfen durumunu güncellemek istediğiniz kargoyu listeden seçin.", "Seçim Yapılmadı");
                return;
            }

            // Seçilen kargonun TakipNo bilgisini al
            var seciliSatir = dgvKargolar.SelectedRows[0];
            string takipNo = seciliSatir.Cells["TakipNo"].Value.ToString();

            // Listeden ilgili kargoyu bul
            Kargo guncellenecekKargo = kargoListesi.FirstOrDefault(k => k.TakipNo == takipNo);

            if (guncellenecekKargo != null)
            {
                string eskiDurum = guncellenecekKargo.Durum;
                string yeniDurum = cmbDurumGuncelle.SelectedItem.ToString();

                if (eskiDurum == yeniDurum)
                {
                    GosterUyari("Kargo zaten seçilen durumda.", "Güncelleme Gerekmiyor");
                    return;
                }

                guncellenecekKargo.Durum = yeniDurum;

                // Arama filtresi varsa aramayı koruyarak güncelle
                UygulaMevcutFiltre();

                GosterBilgi($"{takipNo} takip numaralı kargonun durumu '{yeniDurum}' olarak güncellendi.", "Durum Güncellendi");
            }
        }

        #endregion

        #region Arama ve Filtreleme

        private void btnAra_Click(object sender, EventArgs e)
        {
            UygulaMevcutFiltre();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtArama.Clear();
            VerileriListele(kargoListesi);
        }

        private void UygulaMevcutFiltre()
        {
            string aramaMetni = txtArama.Text.Trim().ToLowerInvariant();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                VerileriListele(kargoListesi);
                return;
            }

            // Takip No veya Alıcı adına göre filtreleme
            var filtreliListe = kargoListesi.Where(k => 
                k.TakipNo.ToLowerInvariant().Contains(aramaMetni) || 
                k.AliciAdi.ToLowerInvariant().Contains(aramaMetni)
            ).ToList();

            VerileriListele(filtreliListe);
        }

        #endregion

        #region Buton Hover Efektleri ve Mesaj Kutuları

        private void ButonHoverEfektleriniBagla()
        {
            // Kargo Oluştur (Yeşil)
            RenkEfektiAyarla(btnKargoOlustur, Color.FromArgb(46, 204, 113), Color.FromArgb(39, 174, 96));
            // Durum Güncelle (Mavi)
            RenkEfektiAyarla(btnDurumGuncelle, Color.FromArgb(52, 152, 219), Color.FromArgb(41, 128, 185));
            // Ara (Turuncu)
            RenkEfektiAyarla(btnAra, Color.FromArgb(243, 156, 18), Color.FromArgb(230, 126, 34));
            // Temizle (Gri)
            RenkEfektiAyarla(btnTemizle, Color.FromArgb(127, 140, 141), Color.FromArgb(149, 165, 166));
        }

        private void RenkEfektiAyarla(Button btn, Color normalRenk, Color hoverRenk)
        {
            btn.BackColor = normalRenk;
            btn.MouseEnter += (s, e) => btn.BackColor = hoverRenk;
            btn.MouseLeave += (s, e) => btn.BackColor = normalRenk;
        }

        private void GosterUyari(string mesaj, string baslik)
        {
            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void GosterBilgi(string mesaj, string baslik)
        {
            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
