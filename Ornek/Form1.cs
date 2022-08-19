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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        void ChildForm(Form childform)
        {
            this.Width = childform.Width + 25;
            this.Height = childform.Height + 70;

            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childform.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                childform.MdiParent = this;
                childform.Show();
            }
        }
        private void tsmSiparisOlustur_Click(object sender, EventArgs e)
        {
            ChildForm(new SiparisOlustur());
        }
        
        private void tsmSiparisBilgileri_Click(object sender, EventArgs e)
        {
            ChildForm(new SiparisBilgileri());
        }

        private void tsmMenuEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new MenüEkle());
        }

        private void tsmEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new EkstraMalzemeEkle());
        }
        public void Temizle(GroupBox grp)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 1;
                }
                else if (item is ListBox)
                {
                    ((ListBox)item).Items.Clear();
                }
                else if (item is Label && item.ForeColor == Color.Red)
                {
                    item.Text = "";
                }
            }
        }
    }
}
