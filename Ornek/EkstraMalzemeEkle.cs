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
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SiparisOlustur.ekstralar.Add(new Malzeme (txtEkstraMalzeme.Text, nudFiyat.Value));

            Fonksiyon.Temizle(grpEkstraMalzeme.Controls);

            MessageBox.Show("Malzeme Başarılı Bir Şekilde Eklendi!");
        }
    }
}
