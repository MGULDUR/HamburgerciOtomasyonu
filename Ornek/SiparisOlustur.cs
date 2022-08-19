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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }
        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu("Whopper", 39.99M),
            new Menu("Big King", 36.99M),
            new Menu("Kral", 52.99M),
            new Menu("Chicken Royale", 25.99M),
            new Menu("King Chicken", 23.99M),
            new Menu("Fish Royale", 39.99M),
        };

        public static List<Malzeme> ekstralar = new List<Malzeme>()
        {
            new Malzeme("Ketçap", 1.5M),
            new Malzeme("Mayonez", 1.5M),
            new Malzeme("Hardal", 2),
            new Malzeme("Barbekü", 2),
            new Malzeme("Ranch", 2),
            new Malzeme("Buffalo", 2.5M),
            new Malzeme("Soğan", 10),
        };
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
                cmbSiparisSec.Items.Add(item);
            
            foreach (Malzeme item in ekstralar)
                flpMalzemeler.Controls.Add(new CheckBox() { Text = item.Adi, Width = 150, AutoSize = false, Tag = item } ); //Tag prop'u hangi tipte tutacağını belirtir. Burada object olarak boxing yapıyor

            foreach (Siparis item in mevcutSiparisler)
                lstSiparisiGoster.Items.Add(item); //Form açıldığında tamamlanmayan sipariş varsa listbox'a ekleyecek
            rdKucuk.Checked = true;
            cmbSiparisSec.SelectedIndex = 0;//default olarak -1 seçili. Ancak -1 olursa herhangi bir eleman göstermez

            TutarHesapla();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Menu)cmbSiparisSec.SelectedItem;
            if (rdKucuk.Checked)
                yeniSiparis.Boyutu = Boyut.Kucuk;
            else if (rdOrta.Checked)
                yeniSiparis.Boyutu = Boyut.Orta;
            else
                yeniSiparis.Boyutu = Boyut.Buyuk;

            yeniSiparis.EkstraMalzemeleri = new List<Malzeme>();
            foreach (CheckBox kontrol in flpMalzemeler.Controls)
            {
                if (kontrol.Checked)
                    yeniSiparis.EkstraMalzemeleri.Add((Malzeme)kontrol.Tag);
            }

            yeniSiparis.Adet = (int)nudSiparisAdedi.Value;

            yeniSiparis.Hesapla();

            mevcutSiparisler.Add(yeniSiparis);
            lstSiparisiGoster.Items.Add(yeniSiparis);
            TutarHesapla(); //Metodun içinde toplam tutarı label'a yazdıracak kod var
            tumSiparisler.Add(yeniSiparis);

            Fonksiyon.Temizle(grpMenuSecim.Controls);
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı: " + TutarHesapla().ToString("C2") + "\nSatın Alma İşlemini Onaylıyor Musunuz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                mevcutSiparisler.Clear(); //Mevcut Siparişler listesini temizle
                Fonksiyon.Temizle(this.Controls);
                MessageBox.Show("Siparişiniz Tamamlandı!");
            }
            else
            {
                MessageBox.Show("İşleminiz İptal Edildi!");
            }
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lstSiparisiGoster.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lstSiparisiGoster.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblFiyat.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }
    }
}
