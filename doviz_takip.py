import urllib.request
import xml.etree.ElementTree as ET

def kur_bilgilerini_cek():
    # TCMB (Türkiye Cumhuriyet Merkez Bankası) Günlük Döviz Kurları XML Servisi
    url = "https://www.tcmb.gov.tr/kurlar/today.xml"
    
    print("--- ANLIK DÖVİZ KURLARI (TCMB) ---")
    print("Veriler çekiliyor...\n")
    
    try:
        req = urllib.request.Request(url, headers={'User-Agent': 'Mozilla/5.0'})
        with urllib.request.urlopen(req) as response:
            xml_data = response.read()
            
        root = ET.fromstring(xml_data)
        
        # Takip etmek istediğimiz para birimleri
        hedef_kurlar = ["USD", "EUR", "GBP"]
        
        for Currency in root.findall('Currency'):
            kod = Currency.get('Kod')
            if kod in hedef_kurlar:
                isim = Currency.find('Isim').text
                alis = Currency.find('ForexBuying').text
                satis = Currency.find('ForexSelling').text
                print(f"📌 {kod} ({isim}):")
                print(f"   Alış : {alis} TL")
                print(f"   Satış: {satis} TL")
                print("-" * 30)
                
    except Exception as e:
        print("Hata oluştu, veriler çekilemedi:", e)

if __name__ == "__main__":
    kur_bilgilerini_cek()
