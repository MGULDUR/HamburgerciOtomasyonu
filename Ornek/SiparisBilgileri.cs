using Ornek.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek
{
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdedi = 0;

            foreach (Siparis siparis in SiparisOlustur.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach (Malzeme ekstra in SiparisOlustur.ekstralar)
                {
                    ekstraMalzemeGeliri += ekstra.Fiyati;
                }
                satisAdedi += siparis.Adet;
                lstTumSiparisler.Items.Add(siparis);
            }
            lblCiro.Text = ciro.ToString("C2");
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString("C2");
            lblToplamSiparisSayisi.Text = lstTumSiparisler.Items.Count.ToString();
            lblSatilanUrunAdedi.Text = satisAdedi.ToString();
        }
    }
}
