using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Yatırım.Models;

namespace Yatırım.Controllers
{
    public class FinansController : Controller
    {
        // Uygulama ayakta kaldığı sürece kullanılacak Bellek İçi (In-Memory) Liste
        private static readonly List<FinansVarlik> Varliklar = new List<FinansVarlik>
        {
            new FinansVarlik { Id = 1, VarlikAdi = "USD/TRY", VarlikTuru = "Döviz", AlisFiyati = 32.50m, SatisFiyati = 32.55m, GunlukDegisim = 0.15m, SonGuncelleme = DateTime.Now },
            new FinansVarlik { Id = 2, VarlikAdi = "EUR/TRY", VarlikTuru = "Döviz", AlisFiyati = 35.10m, SatisFiyati = 35.18m, GunlukDegisim = -0.45m, SonGuncelleme = DateTime.Now },
            new FinansVarlik { Id = 3, VarlikAdi = "Gram Altın", VarlikTuru = "Emtia", AlisFiyati = 2450.00m, SatisFiyati = 2465.00m, GunlukDegisim = 2.30m, SonGuncelleme = DateTime.Now },
            new FinansVarlik { Id = 4, VarlikAdi = "BIST100", VarlikTuru = "Hisse", AlisFiyati = 10150.00m, SatisFiyati = 10150.00m, GunlukDegisim = 1.85m, SonGuncelleme = DateTime.Now },
            new FinansVarlik { Id = 5, VarlikAdi = "THYAO", VarlikTuru = "Hisse", AlisFiyati = 305.50m, SatisFiyati = 306.00m, GunlukDegisim = -1.20m, SonGuncelleme = DateTime.Now }
        };

        // 1. Index (Piyasa Ekranı)
        public IActionResult Index()
        {
            // Verileri listeleriz
            return View(Varliklar);
        }

        // 2. PortfoyHesapla (GET)
        [HttpGet]
        public IActionResult PortfoyHesapla()
        {
            ViewBag.Varliklar = Varliklar;
            return View();
        }

        // 2. PortfoyHesapla (POST)
        [HttpPost]
        public IActionResult PortfoyHesapla(int varlikId, decimal miktar)
        {
            var secilenVarlik = Varliklar.FirstOrDefault(v => v.Id == varlikId);
            ViewBag.Varliklar = Varliklar; // Dropdown'ın tekrar dolması için

            if (secilenVarlik != null)
            {
                if (miktar < 0)
                {
                    ModelState.AddModelError("miktar", "Miktar 0 veya daha büyük olmalıdır.");
                    return View();
                }

                decimal toplamDegerAlis = miktar * secilenVarlik.AlisFiyati;
                decimal toplamDegerSatis = miktar * secilenVarlik.SatisFiyati;

                ViewBag.SecilenVarlikAdi = secilenVarlik.VarlikAdi;
                ViewBag.Miktar = miktar;
                ViewBag.AlisFiyati = secilenVarlik.AlisFiyati;
                ViewBag.SatisFiyati = secilenVarlik.SatisFiyati;
                ViewBag.ToplamDegerAlis = toplamDegerAlis;
                ViewBag.ToplamDegerSatis = toplamDegerSatis;
                ViewBag.Hesaplandi = true;
            }
            else
            {
                ModelState.AddModelError("", "Lütfen geçerli bir varlık seçiniz.");
            }

            return View();
        }

        // 3. Ekle (GET)
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        // 3. Ekle (POST)
        [HttpPost]
        public IActionResult Ekle(FinansVarlik yeniVarlik)
        {
            if (ModelState.IsValid)
            {
                // Yeni Id belirle
                yeniVarlik.Id = Varliklar.Count > 0 ? Varliklar.Max(v => v.Id) + 1 : 1;
                yeniVarlik.SonGuncelleme = DateTime.Now;

                Varliklar.Add(yeniVarlik);
                return RedirectToAction(nameof(Index));
            }

            return View(yeniVarlik);
        }
    }
}
