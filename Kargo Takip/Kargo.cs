using System;

namespace Kargo_Takip
{
    public class Kargo
    {
        public string TakipNo { get; set; }
        public string AliciAdi { get; set; }
        public string TeslimAdresi { get; set; }
        public string Durum { get; set; }

        public Kargo()
        {
        }

        public Kargo(string takipNo, string aliciAdi, string teslimAdresi, string durum)
        {
            TakipNo = takipNo;
            AliciAdi = aliciAdi;
            TeslimAdresi = teslimAdresi;
            Durum = durum;
        }
    }
}
