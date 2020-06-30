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
    public partial class musteriEkranı : Form
    {
        public musteriEkranı()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m) //form hareket ettirme komutu
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

        private void musteriEkranı_Load(object sender, EventArgs e)
        {
            csMusteriEkrani me = new csMusteriEkrani();
            dataGridView1.DataSource = me.tablola();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["id"].Value); //id isimli değişken oluşturduk.id değişkenini inte çevirip değeri çağırdık id satırındaki değeri aldık.
            txtAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["adi"].Value.ToString();
            txtSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells["soyadi"].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[e.RowIndex].Cells["cinsiyet"].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells["telefon"].Value.ToString();
            txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells["mail"].Value.ToString();
            txtTc.Text = dataGridView1.Rows[e.RowIndex].Cells["tcNo"].Value.ToString();
            txtOda.Text = dataGridView1.Rows[e.RowIndex].Cells["odaNo"].Value.ToString();
            txtUcret.Text = dataGridView1.Rows[e.RowIndex].Cells["ucret"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime (dataGridView1.Rows[e.RowIndex].Cells["girisTarihi"].Value);
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["cikisTarihi"].Value);

        }

        private void button2_Click(object sender, EventArgs e) //bilgileri getir butonu kodları
        {
            csMusteriEkrani me = new csMusteriEkrani();
            dataGridView1.DataSource = me.tablola();
        }

        private void button3_Click(object sender, EventArgs e) //temizleme butonu kodları
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            cmbCinsiyet.Text ="";
            txtTelefon.Text = "";
            txtMail.Text = "";
            txtTc.Text = "";
            txtOda.Text ="";
            txtUcret.Text = "";
            dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());


        }
        private void button24_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime cikisTarihi = Convert.ToDateTime(dateTimePicker2.Value);
            int id = Convert.ToInt16(lblID.Text);
            csMusteriEkrani me = new csMusteriEkrani();
            me.musteriGuncelle(id, txtAdi.Text, txtSoyadi.Text, cmbCinsiyet.Text, txtTelefon.Text, txtMail.Text, txtTc.Text, txtOda.Text, txtUcret.Text, girisTarihi, cikisTarihi);
            dataGridView1.DataSource = me.tablola();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(lblID.Text);
            csMusteriEkrani me = new csMusteriEkrani();
            me.musteriSil(id);
            dataGridView1.DataSource = me.tablola();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            csMusteriEkrani me = new csMusteriEkrani();
           dataGridView1.DataSource= me.musteriAra(txtAra.Text);
            
        }
    }
}
