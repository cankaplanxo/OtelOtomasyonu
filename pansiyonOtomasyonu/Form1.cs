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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m) //formu hareket ettirme komutu
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if((int)m.Result==0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }
                        return;

            }
            base.WndProc(ref m);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            giris grs = new giris();
            anaEkran main = new anaEkran();
            if (txtKullanici.Text==string.Empty || txtSifre.Text== string.Empty)
            {
                MessageBox.Show("Lütfen kullanıcı adını ve şifreni giriniz.", " HATA | Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                grs.girisYap(txtKullanici.Text, txtSifre.Text, DateTime.Now);
                string bilgiTut = txtKullanici.Text + " " + txtSifre.Text.ToString();
                if (grs.girisDurumu == bilgiTut)
                {
                    main.Show();
                    this.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
