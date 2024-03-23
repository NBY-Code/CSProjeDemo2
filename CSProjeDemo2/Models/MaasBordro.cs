using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Models
{
    public class MaasBordro
    {
        public void BordroOlustur(List<Personel> personelListesi)
        {
            foreach (var personel in personelListesi)
            {
                personel.MaasHesapla();
                string dosyaYolu = $"{personel.Ad}_{personel.Soyad}_{DateTime.Now:MMMM_yyyy}.json";
                string json = JsonConvert.SerializeObject(personel, Formatting.Indented);
                File.WriteAllText(dosyaYolu, json);
            }
        }

        public void RaporGoruntule(List<Personel> personelListesi)
        {
            Console.WriteLine("Maaş Raporu:");
            foreach (var personel in personelListesi)
            {
                Console.WriteLine($"Ad: {personel.Ad} {personel.Soyad}, Maaş: {personel.SaatlikUcret * (decimal)personel.CalismaSaati}");
            }
        }

        public void AzCalisanRaporu(List<Personel> personelListesi)
        {
            Console.WriteLine("150 saatten az çalışan personellerin raporu:");
            foreach (var personel in personelListesi)
            {
                if (personel.CalismaSaati < 150)
                {
                    Console.WriteLine($"Ad: {personel.Ad} {personel.Soyad}, Çalışma Saati: {personel.CalismaSaati}");
                }
            }
        }
    }

}

