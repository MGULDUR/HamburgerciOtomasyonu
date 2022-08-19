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
    public partial class MenüEkle : Form
    {
        public MenüEkle()
        {
            InitializeComponent();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SiparisOlustur.menuler.Add(new Menu( txtMenuAdi.Text,  nudFiyat.Value ));

            Fonksiyon.Temizle(grpMenuBilgileri.Controls);

            MessageBox.Show("Menü Başarılı Bir Şekilde Eklendi!");
        }
    }
}
