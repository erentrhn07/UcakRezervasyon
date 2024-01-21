using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonFinal
{
    internal class UcakOlusturma : Ucak
    {
       public string Model { get; set; }
       public string SeriNo { get; set; }
       public int YolcuKapasitesi { get; set; }

    public UcakOlusturma() 
    {
            UcaklariOku();
    }
        private void UcaklariOku() 
        {
            try 
            {
                string[] ucaklar = File.ReadAllLines("ucaklar.txt");
                int randomIndex = new Random().Next(0, ucaklar.Length);

                string[] ucakBilgisi = ucaklar[randomIndex].Split(',');

                Model = ucakBilgisi[0];
                SeriNo = ucakBilgisi[1];
                YolcuKapasitesi = Convert.ToInt32(ucakBilgisi[2]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Uçak bilgisi okunurken bir hata oluştu: " + ex.Message);
            }
        }

    }
}
