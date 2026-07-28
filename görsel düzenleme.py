import os
from PIL import Image

def gorsel_boyutlandir():
    print("--- 🖼️ GÖRSEL BOYUT YENİDEN ŞEKİLLENDİRİCİ ---")
    
    resim_yolu = input("\nBoyutlandırılacak resim dosyasının adını girin (Örn: resim.jpg): ")
    
    if not os.path.exists(resim_yolu):
        print(f"❌ Hata: '{resim_yolu}' adında bir dosya bulunamadı!")
        return

    try:
        genislik = int(input("Yeni Genişlik (Piksel cinsinden, Örn: 800): "))
        yukseklik = int(input("Yeni Yükseklik (Piksel cinsinden, Örn: 600): "))
    except ValueError:
        print("Lütfen genişlik ve yükseklik için geçerli bir sayı girin!")
        return

    try:
        # Resmi açıp yeniden boyutlandıralım
        with Image.open(resim_yolu) as img:
            # Resmin orijinal formatını ve boyutunu alalım
            orijinal_boyut = img.size
            
            # Resim kalitesini koruyarak boyutlandıralım (LANCZOS filtresi ile)
            yeni_img = img.resize((genislik, yukseklik), Image.Resampling.LANCZOS)
            
            # Yeni dosya adı oluşturalım
            dosya_adi, uzanti = os.path.splitext(resim_yolu)
            yeni_dosya_adi = f"{dosya_adi}_{genislik}x{yukseklik}{uzanti}"
            
            yeni_img.save(yeni_dosya_adi)

            print("\n" + "="*45)
            print("✅ Görsel Başarıyla Boyutlandırıldı!")
            print(f"📏 Orijinal Boyut: {orijinal_boyut[0]}x{orijinal_boyut[1]} px")
            print(f"🎯 Yeni Boyut:     {genislik}x{yukseklik} px")
            print(f"📁 Kaydedilen Dosya: {yeni_dosya_adi}")
            print("="*45)

    except Exception as e:
        print(f"Resim işlenirken bir hata oluştu: {e}")

if __name__ == "__main__":
    gorsel_boyutlandir()
