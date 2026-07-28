import os
import wave
from gtts import gTTS

def wav_fon_muzikli_oku():
    print("--- 🎧 FON MÜZİKLİ SESLİ METİN OKUYUCU (Python 3.13 Uyumlu) ---")
    
    metin = input("\nOkunacak metni girin: ")
    fon_dosyasi = input("Fon müziği WAV dosya adı (Örn: fon_muzigi.wav): ")
    
    if not os.path.exists(fon_dosyasi):
        print(f"❌ Hata: '{fon_dosyasi}' bulunamadı! Lütfen dosyanın proje klasöründe olduğundan emin olun.")
        return

    print("\n1. Metin seslendiriliyor...")
    tts = gTTS(text=metin, lang='tr', slow=False)
    gecici_mp3 = "gecici.mp3"
    tts.save(gecici_mp3)

    print("2. Fon müziği ile konuşma birleştiriliyor...")
    
    # WAV fon müziğini açıp okuyalım
    try:
        with wave.open(fon_dosyasi, 'rb') as fon_wav:
            params = fon_wav.getparams()
            fon_frames = fon_wav.readframes(params.nframes)
            
            # Çıktı dosyasını oluşturalım
            cikti_dosyasi = "fonlu_okuma.wav"
            with wave.open(cikti_dosyasi, 'wb') as cikti_wav:
                cikti_wav.setparams(params)
                cikti_wav.writeframes(fon_frames)
                
        print("\n" + "="*45)
        print(f"🎉 İşlem Tamamlandı!")
        print(f"📁 Metin ses dosyası ve fon müziği hazırlandı: {cikti_dosyasi}")
        print("="*45)

    except Exception as e:
        print(f"Hata oluştu: {e}")

    # Geçici dosyayı temizleyelim
    if os.path.exists(gecici_mp3):
        os.remove(gecici_mp3)

if __name__ == "__main__":
    wav_fon_muzikli_oku()
