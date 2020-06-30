using System;
using System.Collections;
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
    public partial class frmOdalar : Form
    {
        public frmOdalar()
        {
            InitializeComponent();
        }
        ArrayList odalar = new ArrayList();
        private void frmOdalar_Load(object sender, EventArgs e)
        {
            string odaAdi = "";
            string yeniDeger = "";
            
            for (int i = 1; i < this.Controls.Count + 1; i++)
            {//controls find komutu kontroller içinde bir arama yapmaya yarar.

                odaAdi = Convert.ToString(this.Controls.Find("oda" + i.ToString(), true).FirstOrDefault() as Button);
                //iki nokta üst üsteden sonraki yazıyı aldıran komut
                yeniDeger = odaAdi.Split(':').Last();
                odalar.Add(yeniDeger);
                
            }
            
            odalarinDurumu();
            
        }
        void odalarinDurumu()
        //csOdalar sınıfımızı burada tanımlıyoruz
        {
            string yeniOda = "";
            csOdalar oda = new csOdalar();
            try
            {
                foreach (string odaninAdi in odalar) // ODA 1 Dolu
                {
                    //eğer oda doluysa aldırdığımız buton adını buraya çağır. Butonun rengini kırmızı yap.
                    oda.odaDegerleri(odaninAdi, "Dolu"); //
                    if (oda.durum_oku == "Dolu")
                    {
                        yeniOda = odaninAdi;
                        this.Controls.Find(oda.butonAdi, true)[0].BackColor = Color.Red;
                        this.Controls.Find(oda.butonAdi, true)[0].Text = yeniOda + " \n" + oda.alanKisi;
                        oda.durum_oku = "";
                    }
                    if (oda.durum_oku == "Boş")
                    //oda durumu boş gelirse hiçbişey yapma.Butonun rengini yeşil yap
                    {
                        this.Controls.Find(oda.butonAdi, true)[0].BackColor = Color.Green;
                    }
                }
            }
            catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }
        }
    }
}