using System;
using System.ComponentModel.DataAnnotations;

namespace Yatırım.Models
{
    public class FinansVarlik
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Varlık adı zorunludur.")]
        [Display(Name = "Varlık Adı")]
        public string VarlikAdi { get; set; } = string.Empty;

        [Required(ErrorMessage = "Varlık türü zorunludur.")]
        [Display(Name = "Varlık Türü")]
        public string VarlikTuru { get; set; } = string.Empty;

        [Required(ErrorMessage = "Alış fiyatı zorunludur.")]
        [Range(0.0001, double.MaxValue, ErrorMessage = "Alış fiyatı 0'dan büyük olmalıdır.")]
        [Display(Name = "Alış Fiyatı (TL)")]
        public decimal AlisFiyati { get; set; }

        [Required(ErrorMessage = "Satış fiyatı zorunludur.")]
        [Range(0.0001, double.MaxValue, ErrorMessage = "Satış fiyatı 0'dan büyük olmalıdır.")]
        [Display(Name = "Satış Fiyatı (TL)")]
        public decimal SatisFiyati { get; set; }

        [Required(ErrorMessage = "Günlük değişim oranı zorunludur.")]
        [Display(Name = "Günlük Değişim (%)")]
        public decimal GunlukDegisim { get; set; }

        [Display(Name = "Son Güncelleme")]
        public DateTime SonGuncelleme { get; set; } = DateTime.Now;

        // Otomatik Tavsiye Mantığı
        [Display(Name = "Yatırım Tavsiyesi")]
        public string Tavsiye
        {
            get
            {
                if (GunlukDegisim > 2.0m)
                {
                    return "GÜÇLÜ AL";
                }
                else if (GunlukDegisim >= 0.0m && GunlukDegisim <= 2.0m)
                {
                    return "TUT / BEKLE";
                }
                else // GunlukDegisim < 0.0m
                {
                    return "SAT / DÜŞÜŞ MEYİLLİ";
                }
            }
        }
    }
}
