using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonFinal
{
    internal class Musteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yas { get; set; }
        public string KimlikNo { get; set; }
        public string TelefonNo { get; set; }
        public int Cinsiyet { get; set; }
        public int Engelli { get; set; }

        public Musteri(string ad, string soyad, string yas, string kimlikNo, string telefonNo, int cinsiyet, int engelli)
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
            KimlikNo = kimlikNo;
            TelefonNo = telefonNo;
            Cinsiyet = cinsiyet;
            Engelli = engelli;
        }
    }
}
