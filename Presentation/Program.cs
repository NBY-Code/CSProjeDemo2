using CSProjeDemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            string dosyaYolu = "Solution Items/personel.json";


            DosyaOku dosyaOku = new DosyaOku();
            List<Personel> personelListesi = dosyaOku.PersonelListesiOlustur(@"C:\Users\user\Desktop\BilgeAdam\CSProjeDemo2\personel.json");


            if (personelListesi.Count > 0)
            {
                MaasBordro maasBordro = new MaasBordro();
                maasBordro.BordroOlustur(personelListesi);

               
                maasBordro.RaporGoruntule(personelListesi);

               
                maasBordro.AzCalisanRaporu(personelListesi);

                Console.WriteLine("Maaş bordroları oluşturuldu.");
            }
            else
            {
                Console.WriteLine("Dosya bulunamadı veya dosya yolu belirtilmemiş.");
            }

            Console.ReadLine();
        }

    }

}
