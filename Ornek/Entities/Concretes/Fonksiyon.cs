using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Ornek.Entities.Concretes
{
    public class Fonksiyon
    {
        //Menü Combobox'ı ilk eleman seçili hale gelecek
        //Boyut radiobutton'u küçük rdo seçili hale gelecek
        //Malzeme flowlayoutpanel'deki checkbox'ların checked'i kaldırılacak
        //adet numericupdown'daki değer minimum değere çekilecek
        //Menü ve malzeme ekle formlarında ekleme işlemi başarılı olursa textbox temizlenecek ve numericupdown minimum değere çekilecek
        //not: ilgili metoda ulaşmak için fonksiyon class'ında instance almadan çağrılacak
        //not2: Metot parametre olarak Control koleksiyonu alacak

        public static void Temizle(ControlCollection Controls)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is Label && item.ForeColor == Color.Red)
                {
                    item.Text = "0";
                }
                else if (item is GroupBox)
                {
                    Temizle(((GroupBox)item).Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    Temizle(((FlowLayoutPanel)item).Controls);
                }
                else if (item is RadioButton && item.Name == "rdKucuk")
                {
                    ((RadioButton)item).Checked = true;
                }
                else if (item is ListBox)
                {
                    ((ListBox)item).Items.Clear();
                }
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = ((NumericUpDown)item).Minimum;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
            }
        }
    }
}
