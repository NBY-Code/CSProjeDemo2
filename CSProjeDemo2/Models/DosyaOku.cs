using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Models
{
    public class DosyaOku
    {
        public List<Personel> PersonelListesiOlustur(string dosyaYolu)
        {
            if (!string.IsNullOrEmpty(dosyaYolu) && File.Exists(dosyaYolu))
            {
                try
                {
                    string json = File.ReadAllText(dosyaYolu);
                    var jArray = JArray.Parse(json);
                    var personelListesi = new List<Personel>();

                    foreach (var item in jArray)
                    {
                        var token = item["Unvan"].ToString();
                        Personel personel = null;

                        switch (token)
                        {
                            case "Yonetici":
                                personel = item.ToObject<Yonetici>();
                                break;
                            case "Memur":
                                personel = item.ToObject<Memur>();
                                break;
                            default:
                                throw new InvalidOperationException("Geçersiz unvan.");
                        }

                        personelListesi.Add(personel);
                    }

                    return personelListesi;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Dosya okuma hatası: {ex.Message}");
                    return new List<Personel>();
                }
            }
            else
            {
                Console.WriteLine("Dosya bulunamadı veya dosya yolu belirtilmemiş.");
                return new List<Personel>();
            }
        }
    }

}

