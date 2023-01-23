using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace TarimOtomasyon
{
    public partial class YoneticiForm : Form
    {
        public YoneticiForm()
        {
            InitializeComponent();
        }

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

        private void YoneticiForm_Load(object sender, EventArgs e)
        {
            using (var baglan = Database.Baglanti())
            {
                baglan.Open();
                SqlCommand kullanicilar = new SqlCommand("SELECT ID, kullanici_ad, kullanici_soyad, kullanici_mail, kullanici_yetki FROM kullanicilar", baglan);

                SqlCommand seralar = new SqlCommand("SELECT * FROM seralar", baglan);

                SqlDataAdapter da = new SqlDataAdapter(kullanicilar);
                DataTable dt = new DataTable();

                SqlDataAdapter da2 = new SqlDataAdapter(seralar);
                DataTable dt2 = new DataTable();

                da.Fill(dt);
                da2.Fill(dt2);

                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt2;
            
                SqlCommand kullanicilar2 = new SqlCommand("SELECT COUNT(*) FROM kullanicilar", baglan);
                SqlCommand seralar2 = new SqlCommand("SELECT COUNT(*) FROM seralar", baglan);
                Int32 kullaniciSayisi = Convert.ToInt32(kullanicilar2.ExecuteScalar());
                Int32 seraSayisi = Convert.ToInt32(seralar2.ExecuteScalar());
                if (kullaniciSayisi > 0)
                {
                    lblKullanicilar.Text = kullaniciSayisi.ToString();
                }
                else
                {
                    lblKullanicilar.Text = "0";
                }

                if (seraSayisi > 0)
                {
                    lblSeralar.Text = seraSayisi.ToString();
                }
                else
                {
                    lblSeralar.Text = "0";
                }
                baglan.Close();
            }
        }

        public int kullanici_ID;
        string yetkiYazi, eposta;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelKullanici.Visible = true;

            kullanici_ID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);

            eposta = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

            lblKullaniciDuzenle.Text = eposta + " kullanıcısını düzenliyorsunuz.";

            txtAd.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEposta.Text = eposta;

            int yetki = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[4].Value);
            

            if (yetki == 0)
            {
                yetkiYazi = "Kullanıcı";
            } else if (yetki == 1)
            {
                yetkiYazi = "Yönetici";
            }

            txtYetki.Text = yetkiYazi;

        }

        public int sera_ID;
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelSera.Visible = true;

            sera_ID = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);

            txtSeraSahibi.Text = this.dataGridView2.CurrentRow.Cells[10].Value.ToString();

            txtSeraAdi.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtSeraCesiti.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtUrunCinsi.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtGubrelemeTuru.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txtGubrelemeSekli.Text = this.dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txtSulamaYontemi.Text = this.dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txtAsilamaYontemi.Text = this.dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txtDikimTarihi.Text = this.dataGridView2.CurrentRow.Cells[8].Value.ToString();
            txtAlanBuyuklugu.Text = this.dataGridView2.CurrentRow.Cells[9].Value.ToString();

        }

        private void btnSeraGuncelle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSeraAdi.Text) || String.IsNullOrEmpty(txtSeraCesiti.Text) || String.IsNullOrEmpty(txtUrunCinsi.Text) || String.IsNullOrEmpty(txtGubrelemeTuru.Text) || String.IsNullOrEmpty(txtGubrelemeSekli.Text) || String.IsNullOrEmpty(txtSulamaYontemi.Text) || String.IsNullOrEmpty(txtAsilamaYontemi.Text) || String.IsNullOrEmpty(txtDikimTarihi.Text) || String.IsNullOrEmpty(txtAlanBuyuklugu.Text))
            {
                MessageBox.Show("Boş alan bırakamazsınız.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var baglan = Database.Baglanti())
                {
                    baglan.Open();
                    var guncelleKomut = new SqlCommand("UPDATE seralar SET sera_adi = '" + txtSeraAdi.Text + "', sera_cesiti = '" + txtSeraCesiti.Text + "', urun_cinsi = '" + txtUrunCinsi.Text + "', gubreleme_turu = '" + txtGubrelemeTuru.Text + "', gubreleme_sekli = '" + txtGubrelemeSekli.Text + "', sulama_yontemi = '" + txtSulamaYontemi.Text + "', asilama_yontemi = '" + txtAsilamaYontemi.Text + "', dikim_tarihi = '" + txtDikimTarihi.Text + "', alan_buyuklugu = '" + txtAlanBuyuklugu.Text + "', sera_sahibi = '" + txtSeraSahibi.Text + "' WHERE ID = '" + sera_ID + "'", baglan);

                    guncelleKomut.ExecuteNonQuery();
                    MessageBox.Show("Sera bilgilerini başarıyla güncellediniz.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    baglan.Close();
                }
            }
        }

        private void btnSeraSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Serayı gerçekten silmek istiyor musunuz?", "Sera Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                using (var baglan = Database.Baglanti())
                {
                    var sqlKomut = new SqlCommand("DELETE FROM seralar WHERE ID = '" + sera_ID + "'");
                    sqlKomut.Connection = baglan;
                    baglan.Open();

                    sqlKomut.ExecuteNonQuery();

                    baglan.Close();
                }

                lblSeraBilgi.Text = "Sera başarıyla silindi.";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            int rnd = random.Next(25, 38);

            int rnd2 = random.Next(950, 1080);

            int rnd3 = random.Next(54, 78);

            linearScaleLevelComponent1.Value = rnd;

            arcScaleNeedleComponent1.Value = rnd2;

            arcScaleRangeBarComponent1.Value = rnd3;

            label10.Text = rnd.ToString() + " °C";

            label13.Text = rnd2.ToString() + " milibar";

            labelComponent2.Text = "%" + rnd3.ToString();
        }

        int tDurum = 0, yetkiKayit = 0;

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(eposta + " e-posta adresine sahip kullanıcıyı gerçekten silmek istiyor musunuz?", "Kullanıcı Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                using (var baglan = Database.Baglanti())
                {
                    var sqlKomut = new SqlCommand("DELETE FROM kullanicilar WHERE ID = '" + kullanici_ID + "'");
                    sqlKomut.Connection = baglan;
                    baglan.Open();

                    sqlKomut.ExecuteNonQuery();

                    baglan.Close();
                }

                label21.Text = "Kullanıcı başarıyla silindi.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAd.Text) || String.IsNullOrEmpty(txtSoyad.Text) || String.IsNullOrEmpty(txtEposta.Text) || String.IsNullOrEmpty(txtYetki.Text))
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
                            if (sqlDataReader.GetString(0) == txtEposta.Text && sqlDataReader.GetSqlString(0) != eposta)
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

                    if (txtYetki.Text == "Kullanıcı")
                    {
                        yetkiKayit = 0;
                    } 
                    else if (txtYetki.Text == "Yönetici") 
                    {
                        yetkiKayit = 1;
                    }

                    if (tDurum == 0)
                    {
                        var guncelleKomut = new SqlCommand("UPDATE kullanicilar SET kullanici_ad = '" + txtAd.Text + "', kullanici_soyad = '" + txtSoyad.Text + "', kullanici_mail = '" + txtEposta.Text + "', kullanici_yetki = '" + yetkiKayit + "' WHERE ID = '" + kullanici_ID + "'", baglan);

                        guncelleKomut.ExecuteNonQuery();
                        MessageBox.Show(eposta + " e-posta adresine sahip kullanıcının bilgilerini başarıyla güncellediniz.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    baglan.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtYeni.Text) || String.IsNullOrEmpty(txtYeni2.Text))
            {
                MessageBox.Show("Parola alanlarını boş bırakamazsınız.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (String.Compare(txtYeni.Text, txtYeni2.Text) == 0)
                {
                    using (var baglan = Database.Baglanti())
                    {
                        baglan.Open();

                        string md5Yeni = CreateMD5Hash(txtYeni.Text);

                        var guncelleKomut2 = new SqlCommand("UPDATE kullanicilar SET kullanici_parola = '" + md5Yeni + "' WHERE ID = '" + kullanici_ID + "'", baglan);

                        guncelleKomut2.ExecuteNonQuery();
                        MessageBox.Show(eposta + " e-posta adresine sahip kullanıcının parola bilgilerini başarıyla güncellediniz.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
