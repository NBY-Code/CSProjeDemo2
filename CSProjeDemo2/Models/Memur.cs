using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Models
{
    public class Memur : Personel
    {
        public int Derece { get; set; }

        public override void MaasHesapla()
        {
            if (CalismaSaati > 180 && Derece > 0)
            {
                double ekMesai = CalismaSaati - 180;
                SaatlikUcret = 500 + Derece * 50;
                double memurMaas = ekMesai * (double)SaatlikUcret * 1.5 + CalismaSaati * (double)SaatlikUcret;
            }
            else if (CalismaSaati > 0 && SaatlikUcret > 0)
            {
                SaatlikUcret = 500 + Derece * 50;
                double memurMaas = (double)SaatlikUcret * CalismaSaati;
            }
            else
            {
                throw new InvalidOperationException("Girilen Bilgilerle Maaş Hesaplanmaz");
            }
        }
    }

}
