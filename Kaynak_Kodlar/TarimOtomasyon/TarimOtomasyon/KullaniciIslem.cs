using Newtonsoft.Json;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TarimOtomasyon
{
    public class KullaniciIslem
    {
        public string CreateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public KullaniciBilgi kullaniciGetir(string kullaniciMail, string kullaniciParola)
        {
            KullaniciBilgi kullaniciBilgi = null;
            using (var baglan = Database.Baglanti())
            {
                var sqlKomut = new SqlCommand("SELECT * FROM kullanicilar WHERE kullanici_mail = '" + kullaniciMail + "' AND kullanici_parola = '" + kullaniciParola + "'");
                sqlKomut.Connection = baglan;
                baglan.Open();
                using (var reader = sqlKomut.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kullaniciBilgi = new KullaniciBilgi();
                        kullaniciBilgi.ID = reader.GetInt32(0);
                        kullaniciBilgi.kullanici_ad = reader.GetString(1);
                        kullaniciBilgi.kullanici_soyad = reader.GetString(2);
                        kullaniciBilgi.kullanici_mail = reader.GetString(3);
                        kullaniciBilgi.kullanici_parola = reader.GetString(4);
                        kullaniciBilgi.kullanici_yetki = reader.GetInt32(5);
                    }
                    JsonSerializer serializer = new JsonSerializer();

                    using (StreamWriter sw = new StreamWriter($@"kullanici_bilgi.json"))
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, kullaniciBilgi);
                    }
                }
                baglan.Close();
            }
            return kullaniciBilgi;
        }

        public bool KullaniciKayit(KullaniciBilgi kbilgi)
        {
            bool sonuc = false;
            string mdParola = CreateMD5Hash(kbilgi.kullanici_parola);
            if (!kullaniciVarMi(kbilgi))
            {
                using (var baglan = Database.Baglanti())
                {
                    var sqlKomut = new SqlCommand("INSERT INTO kullanicilar(kullanici_ad,kullanici_soyad,kullanici_mail,kullanici_parola) VALUES ('" + kbilgi.kullanici_ad + "', '" + kbilgi.kullanici_soyad + "','" + kbilgi.kullanici_mail + "', '" + mdParola + "')");
                    sqlKomut.Connection = baglan;
                    baglan.Open();
                    if (sqlKomut.ExecuteNonQuery() != -1)
                    {
                        sonuc = true;
                    }

                    baglan.Close();
                }
            }
            return sonuc;
        }
        private bool kullaniciVarMi(KullaniciBilgi kbilgi)
        {
            bool sonuc = false;
            using (var baglan = Database.Baglanti())
            {
                var sqlKomut = new SqlCommand("SELECT * FROM kullanicilar WHERE kullanici_mail='" + kbilgi.kullanici_mail + "'");

                sqlKomut.Connection = baglan;
                baglan.Open();
                using (var reader = sqlKomut.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        sonuc = true;
                    }
                }
                baglan.Close();
            }
            return sonuc;
        }
    }
}
