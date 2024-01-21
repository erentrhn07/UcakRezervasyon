using System;
using UcakRezervasyonFinal;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Rezervasyon Uygulaması";
        Console.WriteLine("Rezervasyon Uygulama Sistemine HoşGeldiniz!");

        while (true)
        {
            Console.WriteLine("1. Rezervasyon Oluştur");
            Console.WriteLine("2. Kaydedilen Rezervasyon Görüntüle");
            Console.WriteLine("3. Çıkış");

            Console.Write("Seçenek giriniz (1, 2 veya 3): ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    MusteriOlusturma musteriOlusturma = new MusteriOlusturma();
                    Musteri musteri = musteriOlusturma.MusteriOlustur();

                    UcusOlusturma ucusOlusturma = new UcusOlusturma(musteri);
                    Console.Write(ucusOlusturma.UcusDondur());

                    Rezervasyon.RezervasyonOlustur(musteri, ucusOlusturma);

                    Console.WriteLine("Sayın Yolcumuz İyi Yolculuklar Dileriz");
                    break;

                case "2":
                    Console.WriteLine("Kimlik Numaranızı Girin: ");
                    string kimlikNo = Console.ReadLine();
                    RezervasyonGoruntule.Goruntule(kimlikNo);
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Geçersiz seçenek. Tekrar deneyiniz.");
                    break;
            }
        }
    }
}