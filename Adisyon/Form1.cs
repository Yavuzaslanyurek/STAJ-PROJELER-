using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adisyon
{
    public partial class Form1 : Form
    {
        // Ürün adlarını ve birim fiyatlarını tutan Dictionary yapısı
        private readonly Dictionary<string, decimal> urunFiyatlari = new Dictionary<string, decimal>
        {
            { "Karışık Pizza", 250.00m },
            { "Hamburger Menü", 220.00m },
            { "Tavuk Wrap", 160.00m },
            { "Kola / Fanta", 50.00m },
            { "Açık Ayran", 30.00m },
            { "Sütlaç", 85.00m }
        };

        // Eklenen adisyon kalemlerini tutacak liste
        private readonly List<AdisyonItem> adisyonListesi = new List<AdisyonItem>();
        private decimal toplamTutar = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ComboBox'a ürünleri doldur
            cmbUrunler.Items.Clear();
            foreach (var urun in urunFiyatlari.Keys)
            {
                cmbUrunler.Items.Add(urun);
            }

            if (cmbUrunler.Items.Count > 0)
            {
                cmbUrunler.SelectedIndex = 0;
            }

            // Arayüzü başlangıç durumuna getir
            AdisyonTemizle();
        }

        // Yardımcı Metot: Adisyona ürün ekleme
        private void EkleUrun(string urunAdi, int adet)
        {
            if (string.IsNullOrEmpty(urunAdi) || !urunFiyatlari.ContainsKey(urunAdi))
            {
                MessageBox.Show("Lütfen listeden geçerli bir ürün seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal birimFiyat = urunFiyatlari[urunAdi];

            // Listede aynı ürün varsa miktarını artır, yoksa yeni kalem ekle
            var varolanItem = adisyonListesi.FirstOrDefault(x => x.UrunAdi == urunAdi);
            if (varolanItem != null)
            {
                varolanItem.Adet += adet;
            }
            else
            {
                adisyonListesi.Add(new AdisyonItem
                {
                    UrunAdi = urunAdi,
                    Adet = adet,
                    BirimFiyat = birimFiyat
                });
            }

            ListeyiGuncelle();
            HesaplaToplam();
        }

        // Yardımcı Metot: Adisyondan ürün silme
        private void SilUrun(int index)
        {
            if (index >= 0 && index < adisyonListesi.Count)
            {
                adisyonListesi.RemoveAt(index);
                ListeyiGuncelle();
                HesaplaToplam();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü listeden seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Yardımcı Metot: Toplam hesabı yeniden hesaplama
        private void HesaplaToplam()
        {
            toplamTutar = adisyonListesi.Sum(item => item.ToplamTutar);
            lblToplam.Text = $"Toplam Tutar: {toplamTutar:N2} TL";
        }

        // Yardımcı Metot: ListBox'ı güncel veriyle yenileme
        private void ListeyiGuncelle()
        {
            lstAdisyon.Items.Clear();
            foreach (var item in adisyonListesi)
            {
                lstAdisyon.Items.Add(item);
            }
        }

        // Yardımcı Metot: Adisyonu sıfırlama
        private void AdisyonTemizle()
        {
            adisyonListesi.Clear();
            ListeyiGuncelle();
            HesaplaToplam();
            txtAlinanPara.Clear();
            numAdet.Value = 1;
            if (cmbUrunler.Items.Count > 0)
            {
                cmbUrunler.SelectedIndex = 0;
            }
        }

        // Olay İşleyici: Ürün Ekle Butonu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbUrunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen eklenecek bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secilenUrun = cmbUrunler.SelectedItem.ToString();
            int adet = (int)numAdet.Value;

            EkleUrun(secilenUrun, adet);
        }

        // Olay İşleyici: Ürün Sil Butonu
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            int seciliIndex = lstAdisyon.SelectedIndex;
            SilUrun(seciliIndex);
        }

        // Olay İşleyici: Hesap Kapat Butonu
        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            if (adisyonListesi.Count == 0)
            {
                MessageBox.Show("Adisyonda ödenecek herhangi bir ürün bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string alinanParaMetni = txtAlinanPara.Text.Trim();
            if (string.IsNullOrEmpty(alinanParaMetni))
            {
                MessageBox.Show("Lütfen müşteriden alınan para miktarını giriniz.", "Girdi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sayısal değeri Türkçe virgül ve global nokta uyumluluğuyla dönüştürmeyi dene
            decimal alinanPara;
            bool donusumBasarili = decimal.TryParse(alinanParaMetni.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out alinanPara);
            if (!donusumBasarili)
            {
                donusumBasarili = decimal.TryParse(alinanParaMetni, out alinanPara);
            }

            if (!donusumBasarili || alinanPara < 0)
            {
                MessageBox.Show("Lütfen geçerli bir sayısal tutar giriniz.", "Geçersiz Tutar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (alinanPara < toplamTutar)
            {
                decimal eksikMiktar = toplamTutar - alinanPara;
                MessageBox.Show($"Alınan bakiye yetersiz!\n\nToplam Tutar: {toplamTutar:N2} TL\nAlınan Para: {alinanPara:N2} TL\nEksik Tutar: {eksikMiktar:N2} TL", "Ödeme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal paraUstu = alinanPara - toplamTutar;
                MessageBox.Show($"Hesap başarıyla kapatıldı!\n\nToplam Tutar: {toplamTutar:N2} TL\nAlınan Para: {alinanPara:N2} TL\nPara Üstü: {paraUstu:N2} TL", "Ödeme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdisyonTemizle();
            }
        }
    }

    // Adisyondaki her bir kalemi temsil eden model sınıfı
    public class AdisyonItem
    {
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal ToplamTutar => Adet * BirimFiyat;

        public override string ToString()
        {
            return $"{Adet} x {UrunAdi} - {ToplamTutar:N2} TL";
        }
    }
}
