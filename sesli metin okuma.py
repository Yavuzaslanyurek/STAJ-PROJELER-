import os
from gtts import gTTS
from pydub import AudioSegment

def fon_muzikli_metin_oku():
    print("--- 🎧 FON MÜZİKLİ SESLİ METİN OKUYUCU ---")
    
    metin = input("\nOkunacak metni girin: ")
    fon_dosyasi = input("Fon müziği dosya adı (Örn: fon_muzigi.mp3): ")
    
    if not os.path.exists(fon_dosyasi):
        print(f"❌ Hata: '{fon_dosyasi}' bulunamadı! Lütfen dosyanın proje klasöründe olduğundan emin olun.")
        return

    print("\n1. Metin sese dönüştürülüyor...")
    # Metni Türkçe olarak sese çevirelim
    tts = gTTS(text=metin, lang='tr', slow=False)
    gecici_ses = "gecici_konusma.mp3"
    tts.save(gecici_ses)

    print("2. Ses ve fon müziği harmanlanıyor...")
    # Ses dosyalarını pydub ile yükleyelim
    konusma = AudioSegment.from_file(gecici_ses)
    fon = AudioSegment.from_file(fon_dosyasi)

    # Fon müziğinin sesini biraz kısalım ki konuşma net duyulsun (-15 dB)
    fon = fon - 15

    # Fon müziğini konuşma süresi kadar döngüye sokalım veya keselim
    if len(fon) < len(konusma):
        # Fon müziği kısa gelirse konuşma bitene kadar tekrarlasın
        döngü_sayisi = (len(konusma) // len(fon)) + 1
        fon = (fon * döngü_sayisi)[:len(konusma)]
    else:
        fon = fon[:len(konusma)]

    # İki sesi üst üste bindirelim (overlay)
    final_ses = konusma.overlay(fon)

    # Birleşmiş MP3 dosyasını kaydedelim
    cikti_dosyasi = "fonlu_okuma.mp3"
    final_ses.export(cikti_dosyasi, format="mp3")

    # Geçici konuşma dosyasını temizleyelim
    if os.path.exists(gecici_ses):
        os.remove(gecici_ses)

    print("\n" + "="*45)
    print(f"🎉 İşlem Tamamlandı!")
    print(f"📁 Hazırlanan Ses Dosyası: {cikti_dosyasi}")
    print("="*45)

if __name__ == "__main__":
    fon_muzikli_metin_oku()
