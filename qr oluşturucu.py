import qrcode

def qr_kod_olustur():
    print("--- 📱 QR KOD OLUŞTURUCU ---")
    
    link_veya_metin = input("\nQR Koda dönüştürülecek linki veya metni girin: ")
    dosya_adi = input("Kaydedilecek dosya adı (Örn: qr_kodu): ")
    
    if not dosya_adi.endswith(".png"):
        dosya_adi += ".png"

    # QR Kod ayarlarını yapalım
    qr = qrcode.QRCode(
        version=1,
        error_correction=qrcode.constants.ERROR_CORRECT_L,
        box_size=10,
        border=4,
    )
    
    qr.add_data(link_veya_metin)
    qr.make(fit=True)

    # Resmi oluşturalım
    img = qr.make_image(fill_color="black", back_color="white")
    img.save(dosya_adi)

    print("\n" + "="*40)
    print(f"✅ QR Kod başarıyla oluşturuldu!")
    print(f"📁 Kaydedilen Dosya: {dosya_adi}")
    print("="*40)

if __name__ == "__main__":
    qr_kod_olustur()
