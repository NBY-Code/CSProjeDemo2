using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Models
{
    public class Yonetici : Personel
    {
        public decimal Bonus { get; set; }

        public override void MaasHesapla()
        {
            if (SaatlikUcret >= 500 && CalismaSaati > 0 && Bonus > 0)
            {
                double personelMaaş = ((double)SaatlikUcret * CalismaSaati) + (double)Bonus;
            }
            else
            {
                throw new InvalidOperationException("Girilen Bilgilerle Maaş Hesaplanmaz");
            }
        }
    }

}
