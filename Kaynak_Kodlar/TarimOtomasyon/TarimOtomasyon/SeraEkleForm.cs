using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;

namespace TarimOtomasyon
{
    public partial class SeraEkleForm : Form
    {
        public SeraEkleForm()
        {
            InitializeComponent();
        }
        
        private void btnSeraKaydet_Click(object sender, EventArgs e)
        {
            int seraSahibi;
            using (StreamReader file = File.OpenText($@"kullanici_bilgi.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                KullaniciBilgi kullaniciBilgi = (KullaniciBilgi)serializer.Deserialize(file, typeof(KullaniciBilgi));
                seraSahibi = kullaniciBilgi.ID;
            }
            using (var baglan = Database.Baglanti())
            {
                var sqlKomut = new SqlCommand("INSERT INTO seralar (sera_adi, sera_cesiti, urun_cinsi, gubreleme_turu, gubreleme_sekli, sulama_yontemi, asilama_yontemi, dikim_tarihi, alan_buyuklugu, sera_sahibi) VALUES ('" + txtSeraAdi.Text + "', '" + txtSeraCesiti.Text + "', '" + txtUrunCinsi.Text + "', '" + txtGubrelemeTuru.Text + "', '" + txtGubrelemeSekli.Text + "', '" + txtSulamaYontemi.Text + "', '" + txtAsilamaYontemi.Text + "', '" + txtDikimTarihi.Text + "', '" + txtAlanBuyuklugu.Text + "', @sSahip)");

                sqlKomut.Parameters.AddWithValue("@sSahip", SqlDbType.Int).Value = seraSahibi;
                sqlKomut.Connection = baglan;
                baglan.Open();
                
                if(sqlKomut.ExecuteNonQuery() != -1)
                {
                    labelBilgi.Text = "Seranız başarıyla kaydedildi.";
                }
                else
                {
                    labelBilgi.Text = "Seranız kaydedilirken bir sorun oluştu";
                }
                baglan.Close();
            }
        }
    }
}
