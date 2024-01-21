using System;
using System.Collections.Generic;
using System.IO;
using UcakRezervasyonFinal;

internal class Rezervasyon
{
    public static void RezervasyonOlustur(Musteri musteri, UcusOlusturma ucusOlusturma)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("rezervasyonlar.csv", true))
            {
                writer.WriteLine($"{musteri.Ad},{musteri.Soyad},{musteri.KimlikNo},{musteri.TelefonNo},{ucusOlusturma.Ucak},{ucusOlusturma.UcakSeriNo},{ucusOlusturma.Lokasyon},{ucusOlusturma.Tarih}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Rezervasyon oluştururken bir hata oluştu: " + ex.Message);
        }
    }
}
