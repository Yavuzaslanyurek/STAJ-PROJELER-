def sezar_coz(sifreli_metin, anahtar):
    cozulmus_metin = ""
    
    for karakter in sifreli_metin:
        if karakter.isalpha():
            baslangic = ord('A') if karakter.isupper() else ord('a')
            # Tersine kaydırma işlemi
            yeni_char = chr((ord(karakter) - baslangic - anahtar) % 26 + baslangic)
            cozulmus_metin += yeni_char
        else:
            cozulmus_metin += karakter
            
    return cozulmus_metin

def main():
    print("--- 🔓 SEZAR ŞİFRE ÇÖZÜCÜ ---")
    sifreli_metin = input("\nÇözülecek şifreli metni girin: ")
    try:
        anahtar = int(input("Şifreleme anahtarını (kaydırma sayısı) girin: "))
    except ValueError:
        print("Lütfen bir sayı girin!")
        return

    sonuc = sezar_coz(sifreli_metin, anahtar)
    print("\n" + "="*35)
    print(f"📖 Çözülmüş Metin: {sonuc}")
    print("="*35)

if __name__ == "__main__":
    main()

