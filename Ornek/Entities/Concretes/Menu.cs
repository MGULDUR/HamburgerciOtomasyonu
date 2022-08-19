using Ornek.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    public class Menu : Urun
    {
        public Menu(string ad, decimal fiyat)
        {
            Adi = ad;
            Fiyati = fiyat;
        }
        
        public override string ToString()
        {
            return Adi + " Menü";
        }
    }
}
