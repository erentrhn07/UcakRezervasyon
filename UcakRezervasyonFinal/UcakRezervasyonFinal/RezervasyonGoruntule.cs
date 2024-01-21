using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonFinal
{
    internal class RezervasyonGoruntule : Rezervasyon
    {
        private const string dosyaYolu = "rezervasyonlar.csv";

        public static void Goruntule(string kimlikNo)
        {
            List<string[]> rezervasyonlar = RezervasyonlariOku();

            if (rezervasyonlar.Count == 0)
            {
                Console.WriteLine("Hiç rezervasyon bulunamadı.");
                return;
            }

            Console.WriteLine("Rezervasyonlar:");

            foreach (var rezervasyon in rezervasyonlar)
            {
                if (rezervasyon[0] == kimlikNo)
                {
                    Console.WriteLine($"Kimlik No: {rezervasyon[0]}, Ad: {rezervasyon[1]}, Soyad: {rezervasyon[2]}, Koltuk No: {rezervasyon[3]}");
                }
            }
        }

        private static List<string[]> RezervasyonlariOku()
        {
            List<string[]> rezervasyonlar = new List<string[]>();

            try
            {
                if (File.Exists(dosyaYolu))
                {
                    using (StreamReader reader = new StreamReader(dosyaYolu))
                    {
                        while (!reader.EndOfStream)
                        {
                            string satir = reader.ReadLine();
                            string[] veri = satir.Split(',');

                            rezervasyonlar.Add(veri);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

            return rezervasyonlar;
        }
    }
}
