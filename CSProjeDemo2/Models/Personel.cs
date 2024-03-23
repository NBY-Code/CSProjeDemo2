using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Models
{
    public abstract class Personel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public decimal SaatlikUcret { get; set; }
        public double CalismaSaati { get; set; }
        public string Unvan { get; set; }
        public abstract void MaasHesapla();
    }

}
