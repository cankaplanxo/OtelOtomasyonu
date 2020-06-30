using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pansiyonOtomasyonu
{
    class musteriKayit
    {
        public string kisininAdi_soyadi { get; set; }
        DataBase db = new DataBase();
        public static void odaGuncelle(string oda, string kisiAdSoyad)
        {
            DataBase db = new DataBase();
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update odalar set odayiAlan=@alanKisi, durumu=@durum where odaAdi = @odaAdi", db.baglanti);
                guncelle.Parameters.AddWithValue("@alanKisi", kisiAdSoyad);
                guncelle.Parameters.AddWithValue("@durum", "Dolu");
                guncelle.Parameters.AddWithValue("@odaAdi", oda);
                guncelle.ExecuteNonQuery();
                guncelle.Dispose();
            }
            catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }
            finally
            {
                db.baglanti.Close();
            }
        }
        public void kayitAl(string adi, string soyadi, string cinsiyet, string telefonNo, string mail, string tcNo, string odaAdi, string ucret, DateTime giris, DateTime cikis)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand kayit_Al = new SqlCommand("insert into musteriler values(@adi,@soyadi,@cinsiyet,@telefon,@mail,@tc,@oda,@ucret,@giris,@cikis)", db.baglanti);
                kayit_Al.Parameters.AddWithValue("@adi", adi);
                kayit_Al.Parameters.AddWithValue("@soyadi", soyadi);
                kayit_Al.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                kayit_Al.Parameters.AddWithValue("@telefon", telefonNo);
                kayit_Al.Parameters.AddWithValue("@mail", mail);
                kayit_Al.Parameters.AddWithValue("@tc", tcNo);
                kayit_Al.Parameters.AddWithValue("@oda", odaAdi);
                kayit_Al.Parameters.AddWithValue("@ucret", ucret);
                kayit_Al.Parameters.AddWithValue("@giris", giris);
                kayit_Al.Parameters.AddWithValue("@cikis", cikis);
                kayit_Al.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Müşteri kayıdı, başarılı bir şekilde oluşmuştur : " + odaAdi + " isimli oda :" + adi + " " + soyadi + " isimli kişiye verilmiştir.", "Bilgi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                kayit_Al.Dispose();
                //////////////////////////////////////
                kisininAdi_soyadi = adi + " " + soyadi;
                odaGuncelle(odaAdi, kisininAdi_soyadi);
            }
            catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }
            finally
            {
                db.baglanti.Close();
            }
        }
    }
}
