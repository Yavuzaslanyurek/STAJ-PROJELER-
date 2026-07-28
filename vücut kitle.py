def vki_hesapla():
    print("--- ⚖️ VÜCUT KİTLE İNDEKSİ (VKİ) HESAPLAYICI ---")
    
    try:
        kilo = float(input("\nKilonuzu kg cinsinden girin (Örn: 70): "))
        boy_cm = float(input("Boyunuzu cm cinsinden girin (Örn: 175): "))
    except ValueError:
        print("Lütfen geçerli bir sayı girin!")
        return

    # cm'yi metreye çevirip VKİ hesaplayalım (kilo / boy^2)
    boy_m = boy_cm / 100
    vki = kilo / (boy_m ** 2)

    print("\n" + "="*35)
    print(f"📊 VKİ Değeriniz: {vki:.2f}")

    if vki < 18.5:
        print("Kategori: Zayıf 🌿")
    elif 18.5 <= vki < 25:
        print("Kategori: Normal (Sağlıklı) ✅")
    elif 25 <= vki < 30:
        print("Kategori: Fazla Kilolu ⚠️")
    else:
        print("Kategori: Obezite 🚨")
    print("="*35)

if __name__ == "__main__":
    vki_hesapla()
