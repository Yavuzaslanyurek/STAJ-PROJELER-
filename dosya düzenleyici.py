import os
import shutil

# Düzenlemek istediğin klasörün yolunu buraya yaz
# Örnek: "C:/Users/KullaniciAdi/Desktop/TestKlasoru"
KLASOR_YOLU = os.path.expanduser("~/Desktop")

# Uzantılara göre oluşturulacak klasör kategorileri
KATEGORILER = {
    "Resimler": [".jpg", ".jpeg", ".png", ".gif", ".svg"],
    "Belgeler": [".pdf", ".docx", ".txt", ".xlsx", ".pptx"],
    "Videolar": [".mp4", ".mkv", ".avi"],
    "Müzikler": [".mp3", ".wav"],
    "Arşivler": [".zip", ".rar", ".7z"],
    "Programlar": [".exe", ".msi"]
}

def dosyalari_düzenle():
    if not os.path.exists(KLASOR_YOLU):
        print("Belirtilen klasör bulunamadı!")
        return

    for dosya in os.listdir(KLASOR_YOLU):
        dosya_yolu = os.path.join(KLASOR_YOLU, dosya)
        
        # Sadece dosyalarla işlem yap, klasörlere dokunma
        if os.path.isfile(dosya_yolu):
            _, uzanti = os.path.splitext(dosya)
            uzanti = uzanti.lower()
            
            tasindi = False
            for kategori, uzantilar in KATEGORILER.items():
                if uzanti in uzantilar:
                    kategori_kutu = os.path.join(KLASOR_YOLU, kategori)
                    
                    # Hedef klasör yoksa oluştur
                    if not os.path.exists(kategori_kutu):
                        os.makedirs(kategori_kutu)
                        
                    shutil.move(dosya_yolu, os.path.join(kategori_kutu, dosya))
                    print(f"'{dosya}' -> {kategori} klasörüne taşındı.")
                    tasindi = True
                    break
            
            # Belirlenmeyen uzantılar için "Diğer" klasörü
            if not tasindi and uzanti != "":
                diger_kutu = os.path.join(KLASOR_YOLU, "Diğer")
                if not os.path.exists(diger_kutu):
                    os.makedirs(diger_kutu)
                shutil.move(dosya_yolu, os.path.join(diger_kutu, dosya))
                print(f"'{dosya}' -> Diğer klasörüne taşındı.")

    print("\nTemizlik tamamlandı! Klasörünüz düzenlendi. ✨")

if __name__ == "__main__":
    dosyalari_düzenle()
