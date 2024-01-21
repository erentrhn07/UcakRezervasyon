using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonFinal
{
    internal class LokasyonOlusturma : Lokasyon
    {
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Havaalani { get; set; }

        public string[] LokasyonList { get; private set; }

        public LokasyonOlusturma()
        {
            LokasyonlariOku();
        }

        private void LokasyonlariOku()
        {
            try
            {
                LokasyonList = File.ReadAllLines("lokasyonlar.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
