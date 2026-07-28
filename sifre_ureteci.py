import random
import string

def sifre_ureteci():
    print("--- 🔐 RASTGELE GÜVENLİ ŞİFRE ÜRETİCİ ---")
    
    try:
        uzunluk = int(input("\nŞifre kaç karakter olsun? (Örn: 12): "))
    except ValueError:
        print("Lütfen geçerli bir sayı girin!")
        return

    # Şifrede kullanılacak karakter havuzu
    harfler = string.ascii_letters   # a-z ve A-Z
    sayilar = string.digits          # 0-9
    semboller = string.punctuation   # !, @, #, $, %, vs.
    
    # Tüm karakterleri birleştir
    tum_karakterler = harfler + sayilar + semboller
    
    # Random kütüphanesi ile rastgele seçim yap
    sifre = "".join(random.choice(tum_karakterler) for _ in range(uzunluk))
    
    print("\n" + "="*35)
    print(f"🔑 Üretilen Güvenli Şifreniz: {sifre}")
    print("="*35)

if __name__ == "__main__":
    sifre_ureteci()
