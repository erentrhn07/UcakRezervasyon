using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonFinal
{
    internal class UcusOlusturma
    {
        public string Musteri { get; private set; }
        public string Ucak { get; private set; }
        public string UcakSeriNo { get; private set; }
        public string Lokasyon { get; private set; }
        public DateTime Tarih { get; private set; }

        public UcusOlusturma(Musteri musteri)
        {
            Musteri = musteri.Ad + " " + musteri.Soyad;

            UcakOlusturma ucakOlusturma = new UcakOlusturma();
            Ucak = ucakOlusturma.Model;
            UcakSeriNo = ucakOlusturma.SeriNo;

            Console.WriteLine("\n Aktif Uçuşlar: ");
            LokasyonSecimi();

            TarihGirisi();
        }

        private void LokasyonSecimi()
        {
            LokasyonOlusturma lokasyonOlusturma = new LokasyonOlusturma();

            int LSayac = 1;
            foreach (var item in lokasyonOlusturma.LokasyonList)
            {
                Console.WriteLine(LSayac + ". lokasyonlar.txt =>" + item);
                LSayac++;
            }

            while (true)
            {
                Console.Write("Uçuş Lokasyonu Seçiniz: ");
                string secimStr = Console.ReadLine();

                if (int.TryParse(secimStr, out int secim) && secim >= 1 && secim <= LSayac - 1)
                {
                    Lokasyon = lokasyonOlusturma.LokasyonList[secim - 1];
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                }
            }
        }

        private void TarihGirisi()
        {
            DateTime bugun = DateTime.Now;
            DateTime birAySonrasi = bugun.AddMonths(1);

            while (true)
            {
                Console.Write("\nTarih Giriniz (gün/ay/yıl): ");
                string tarihStr = Console.ReadLine();

                if (DateTime.TryParseExact(tarihStr, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime tarih))
                {

                    if (tarih < bugun || tarih > birAySonrasi)
                    {
                        Console.WriteLine("Uçuş tarihini doğru giriniz.");
                    }
                    else
                    {
                        Tarih = tarih;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı tarih formatı. Tekrar deneyiniz.");
                }
            }
        }

        public string UcusDondur()
        {
            Rezervasyon rezervasyon = new Rezervasyon();

            string temp = "\nSayın: " + Musteri + "\nUçağınız: " + Ucak + "\nUçak Seri Numaranız: " + UcakSeriNo + " \nLokasyonunuz: " + Lokasyon + "\nUçuş Tarihiniz: " + Tarih.ToShortDateString();
            return temp;
        }
    }
}
