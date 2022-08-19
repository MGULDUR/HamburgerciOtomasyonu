using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek.Entities.Concretes
{
    public class Siparis
    {
        public Menu SeciliMenu { get; set; }
        public List<Malzeme> EkstraMalzemeleri { get; set; }
        public Boyut Boyutu { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;
            switch (Boyutu)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10M;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;
            }
            foreach (Malzeme ekstra in EkstraMalzemeleri)
            {
                ToplamTutar += ekstra.Fiyati;
            }

            ToplamTutar *= Adet;
        }
        public override string ToString()
        {
            if (EkstraMalzemeleri.Count < 1)
            {
                return string.Format("{0} Menü x {1} Adet, {2} Boy, Toplam: {3}", SeciliMenu.Adi, Adet, Boyutu.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                string ekstraMalzemeler = null;
                foreach (Malzeme ekstra in EkstraMalzemeleri)
                {
                    ekstraMalzemeler += ekstra.Adi + ",";
                }
                ekstraMalzemeler = ekstraMalzemeler.Trim(',');

                return string.Format("{0} Menü x {1} Adet, {2} Boy, ({3}),Toplam: {4}", SeciliMenu.Adi, Adet, Boyutu.ToString(), ekstraMalzemeler, ToplamTutar.ToString("C2"));
            }
        }
    }
}
