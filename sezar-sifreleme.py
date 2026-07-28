def sezar_sifrele(metin, anahtar):
    sifreli_metin = ""
    
    for karakter in metin:
        # Harf ise kaydırma işlemi yap
        if karakter.isalpha():
            baslangic = ord('A') if karakter.isupper() else ord('a')
            # 26 harflik alfabe döngüsü
            yeni_char = chr((ord(karakter) - baslangic + anahtar) % 26 + baslangic)
            sifreli_metin += yeni_char
        else:
            # Boşluk veya nokta gibi karakterleri aynen koru
            sifreli_metin += karakter
            
    return sifreli_metin

def main():
    print("--- 🔒 SEZAR ŞİFRELEME PROGRAMI ---")
    metin = input("\nŞifrelenecek metni girin: ")
    try:
        anahtar = int(input("Kaydırma miktarını girin (Örn: 3): "))
    except ValueError:
        print("Lütfen bir sayı girin!")
        return

    sonuc = sezar_sifrele(metin, anahtar)
    print("\n" + "="*35)
    print(f"🔐 Şifreli Metin: {sonuc}")
    print("="*35)

if __name__ == "__main__":
    main()
