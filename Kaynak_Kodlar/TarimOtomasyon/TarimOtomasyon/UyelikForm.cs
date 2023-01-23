using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace TarimOtomasyon
{
    public partial class UyelikForm : Form
    {
        public UyelikForm()
        {
            InitializeComponent();
        }

        string kPosta, kParola;
        int kID;

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

        private void UyelikForm_Load(object sender, EventArgs e)
        {
            using (StreamReader file = File.OpenText($@"kullanici_bilgi.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                KullaniciBilgi kullaniciBilgi = (KullaniciBilgi)serializer.Deserialize(file, typeof(KullaniciBilgi));
                txtAd.Text = kullaniciBilgi.kullanici_ad;
                txtSoyad.Text = kullaniciBilgi.kullanici_soyad;
                txtEposta.Text = kullaniciBilgi.kullanici_mail;
                kPosta = kullaniciBilgi.kullanici_mail;
                kID = kullaniciBilgi.ID;
                kParola = (kullaniciBilgi.kullanici_parola).ToUpper();
            }
        }

        int tDurum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAd.Text) || String.IsNullOrEmpty(txtSoyad.Text) || String.IsNullOrEmpty(txtEposta.Text))
            {
                MessageBox.Show("Boş alan bırakamazsınız.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var baglan = Database.Baglanti())
                {
                    var sqlKomut = new SqlCommand("SELECT kullanici_mail FROM kullanicilar");
                    sqlKomut.Connection = baglan;
                    baglan.Open();

                    SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            if(sqlDataReader.GetString(0) == txtEposta.Text && sqlDataReader.GetSqlString(0) != kPosta)
                            {
                                MessageBox.Show("Bu e-posta adresi bir başkası tarafından kullanılıyor!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                tDurum = 1;
                            }
                            else
                            {
                                tDurum = 0;
                            }
                        }
                    }

                    sqlDataReader.Close();

                    if (tDurum == 0)
                    {
                        var guncelleKomut = new SqlCommand("UPDATE kullanicilar SET kullanici_ad = '" + txtAd.Text + "', kullanici_soyad = '" + txtSoyad.Text + "', kullanici_mail = '" + txtEposta.Text + "' WHERE ID = '" + kID + "'", baglan);

                        guncelleKomut.ExecuteNonQuery();
                        MessageBox.Show("Temel bilgilerinizi başarıyla güncellediniz.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string json = File.ReadAllText("kullanici_bilgi.json");
                        dynamic jsonObj = JsonConvert.DeserializeObject(json);
                        jsonObj["kullanici_ad"] = txtAd.Text;
                        jsonObj["kullanici_soyad"] = txtSoyad.Text;
                        jsonObj["kullanici_mail"] = txtEposta.Text;
                        string output = JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText("kullanici_bilgi.json", output);
                    }

                    baglan.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMevcut.Text) || String.IsNullOrEmpty(txtYeni.Text) || String.IsNullOrEmpty(txtYeni2.Text))
            {
                MessageBox.Show("Parola alanlarını boş bırakamazsınız.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CreateMD5Hash(txtMevcut.Text) != kParola)
                {
                    MessageBox.Show("Mevcut parolanız sistemdeki parolanızla uyuşmuyor.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    if (String.Compare(txtYeni.Text, txtYeni2.Text) == 0)
                    {
                        using (var baglan = Database.Baglanti())
                        {
                            baglan.Open();

                            string md5Yeni = CreateMD5Hash(txtYeni.Text);

                            var guncelleKomut2 = new SqlCommand("UPDATE kullanicilar SET kullanici_parola = '" + md5Yeni + "' WHERE ID = '" + kID + "'", baglan);

                            guncelleKomut2.ExecuteNonQuery();
                            MessageBox.Show("Parola bilgilerinizi başarıyla güncellediniz.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string json = File.ReadAllText("kullanici_bilgi.json");
                            dynamic jsonObj = JsonConvert.DeserializeObject(json);
                            jsonObj["kullanici_parola"] = md5Yeni;
                            string output = JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText("kullanici_bilgi.json", output);

                            baglan.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yeni girdiğiniz parolalar birbiriyle uyuşmuyor!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
