using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pansiyonOtomasyonu
{
    public partial class anaEkran : Form
    {
        public anaEkran()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m) //formu hareket ettirme komutu
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }
                    return;

            }
            base.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriKayit kayitEkrani = new frmMusteriKayit();
            kayitEkrani.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOdalar odalar = new frmOdalar();
            odalar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musteriEkranı ekran = new musteriEkranı();
            ekran.Show();
        }
    }
}
