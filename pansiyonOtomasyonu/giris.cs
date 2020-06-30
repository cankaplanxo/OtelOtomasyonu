using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pansiyonOtomasyonu
{
    class giris
    {
        DataBase db = new DataBase();
        public string kullaniciAdi_tut { get; set; }
        public string kullaniciSifre_tut{get; set;}

        public string girisDurumu { get; set; }
        ////////////////////////////////////

        public void girisYap(string kullaniciAdi, string kullaniciSifre, DateTime tarih)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand loginName = new SqlCommand("select kullaniciAdi from kullaniciBilgileri where kullaniciAdi = @kulAdi", db.baglanti);
                loginName.Parameters.AddWithValue(@"kulAdi", kullaniciAdi);
                SqlDataReader kulAdi_Oku = loginName.ExecuteReader();
                if (kulAdi_Oku.Read())
                {
                    kullaniciAdi_tut = kulAdi_Oku["kullaniciAdi"].ToString();
                    SqlCommand loginPw = new SqlCommand("select kullaniciSifre from kullaniciBilgileri where kullaniciSifre=@sifre", db.baglanti);
                    loginPw.Parameters.AddWithValue("@sifre", kullaniciSifre);
                    SqlDataReader loginPw_Oku = loginPw.ExecuteReader();
                    if (loginPw_Oku.Read())
                    {
                        kullaniciSifre_tut = loginPw_Oku["kullaniciSifre"].ToString();
                        girisDurumu = kullaniciAdi_tut + " " + kullaniciSifre_tut; // can can
                        SqlCommand dateUptade = new SqlCommand("update kullaniciBilgileri set girisTarihi=@tarih where kullaniciAdi =@kuladi AND kullaniciSifre=@kulsifre", db.baglanti);
                        dateUptade.Parameters.AddWithValue("@tarih", tarih);
                        dateUptade.Parameters.AddWithValue("@kuladi", kullaniciAdi_tut);
                        dateUptade.Parameters.AddWithValue("@kulsifre", kullaniciSifre_tut);
                        dateUptade.ExecuteNonQuery();
                        dateUptade.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı şifresini yanlış girdiniz...", "Hata | Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    loginPw.Dispose();
                    loginPw_Oku.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını yanlış girdiniz...","Hata | Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //dispose komutu işimiz bittiğinde verilerin ramden boşaltılmasını sağlar.
                loginName.Dispose();
                kulAdi_Oku.Close();
                db.baglanti.Close();
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
            }
        }
}