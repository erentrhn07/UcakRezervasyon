using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonFinal
{
    internal class MusteriOlusturma
    {
        public Musteri MusteriOlustur()
        {
            Console.Write("Adınız: ");
            string ad = GecerliAdSoyadGirisi();

            Console.Write("Soyadınız: ");
            string soyad = GecerliAdSoyadGirisi();

            Console.Write("Yaşınız:");
            string yas = GecerliYasGirisi();

            Console.Write("Kimlik Numaranız: ");
            string kimlikNo = GecerliKimlikNoGirisi();

            Console.Write("Telefon Numaranız: ");
            string telefonNo = GecerliTelefonNoGirisi();

            int cinsiyet;
            while (true)
            {
                Console.Write("Cinsiyetiniz(Erkek = 1 / Kadın = 2): ");
                if (int.TryParse(Console.ReadLine(), out cinsiyet) && (cinsiyet == 1 || cinsiyet == 2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı değer. Lütfen geçerli bir değer girin.");
                }
            }

            int engelli;
            while (true)
            {
                Console.Write("Engel Durumunuz Var mı? (Evet = 1 / Hayır = 2): ");
                if (int.TryParse(Console.ReadLine(), out engelli) && (engelli == 1 || engelli == 2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı değer. Lütfen geçerli bir değer girin.");
                }
            }

            return new Musteri(ad, soyad, yas, kimlikNo, telefonNo, cinsiyet, engelli);
        }

        private string GecerliAdSoyadGirisi()
        {
            while (true)
            {
                string giris = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(giris) || !giris.All(char.IsLetter))
                {
                    Console.WriteLine("Hatalı değer. Lütfen sadece harf girin.");
                }
                else
                {
                    return giris;
                }
            }
        }

        private string GecerliYasGirisi()
        {
            while (true)
            {
                Console.Write("Yaşınız: ");
                if (int.TryParse(Console.ReadLine(), out int yas) && yas > 0)
                {
                    return yas.ToString();
                }
                else
                {
                    Console.WriteLine("Hatalı değer. Lütfen geçerli bir yaş girin.");
                }
            }
        }

        private string GecerliKimlikNoGirisi()
        {
            while (true)
            {
                string giris = Console.ReadLine();
                if (giris.Length == 11 && giris.All(char.IsDigit))
                {
                    return giris;
                }
                else
                {
                    Console.WriteLine("Hatalı değer. Kimlik numarası 11 haneli rakamlardan oluşmalıdır.");
                }
            }
        }

        private string GecerliTelefonNoGirisi()
        {
            while (true)
            {
                Console.Write("Telefon Numaranız: ");
                string giris = Console.ReadLine();

                if (!string.IsNullOrEmpty(giris) && giris.All(char.IsDigit) && giris[0] != '0')
                {
                    return giris;
                }
                else
                {
                    Console.WriteLine("Hatalı değer. Telefon numarası başında sıfır olmadan, rakamlardan oluşmalıdır.");
                }
            }
        }

    }
}
