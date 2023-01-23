using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TarimOtomasyon
{
    public partial class SeraForm : Form
    {
        public SeraForm()
        {
            InitializeComponent();
        }

        int sera_ID = 0;
        private void SeraForm_Load(object sender, EventArgs e)
        {
            int seraSahibi;

            panelSeralar.HorizontalScroll.Maximum = 0;
            panelSeralar.AutoScroll = false;
            panelSeralar.VerticalScroll.Visible = false;
            panelSeralar.AutoScroll = true;

            using (StreamReader file = File.OpenText($@"kullanici_bilgi.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                KullaniciBilgi kullaniciBilgi = (KullaniciBilgi)serializer.Deserialize(file, typeof(KullaniciBilgi));
                seraSahibi = kullaniciBilgi.ID;
            }
            using (var baglan = Database.Baglanti())
            {
                var sqlKomut = new SqlCommand("SELECT * FROM seralar WHERE sera_sahibi = '" + seraSahibi + "'");
                sqlKomut.Connection = baglan;
                baglan.Open();

                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                int i = 0;
                int butonWidth = 0;

                int left = 0;
                int top = 0;

                int height = (this.Height / 3) - 20;
                int width = (this.Width / 3) - 15;

                if (this.WindowState == FormWindowState.Maximized)
                {
                    
                    this.WindowState = FormWindowState.Maximized;
                    this.Width = Screen.GetWorkingArea(this).Width;
                    this.Height = Screen.GetWorkingArea(this).Height;
                    height = (this.Height / 4) - 20;
                    width = (this.Width / 4) - 15;
                }


                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        Button btn = new Button();

                        Name = "btn" + (i + 1).ToString();

                        sera_ID = sqlDataReader.GetInt32(0);

                        btn.BackColor = Color.FromArgb(225, 205, 182);
                        btn.ForeColor = Color.Black;
                        btn.Text = sqlDataReader.GetString(1);
                        btn.Size = new System.Drawing.Size(width, height);
                        btn.Font = new Font(btn.Font.Name, 15, FontStyle.Bold);
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.TextAlign = ContentAlignment.MiddleCenter;
                        btn.FlatAppearance.BorderSize = 1;
                        btn.FlatAppearance.BorderColor = Color.FromArgb(223, 221, 218);
                        btn.Tag = sera_ID;
                        btn.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                        btn.AutoSize = true;
                        btn.Image = TarimOtomasyon.Properties.Resources.sera;
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.BackgroundImageLayout = ImageLayout.Center;
                        btn.Cursor = Cursors.Hand;
                        btn.BringToFront();

                        btn.Click += Btn_Click;
                        panelSeralar.Controls.Add(btn);

                        i++;

                        left = (btn.Width * (butonWidth / (btn.Width)));

                        butonWidth += btn.Width;

                        switch (butonWidth > this.Width)
                        {
                            case true:
                                left = 0;

                                top += btn.Height + 15;

                                butonWidth = btn.Width;
                                break;
                        }

                        btn.Location = new Point(left + 10, top + 10);
                    }
                }
                sqlDataReader.Close();
            }
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            sera_ID = int.Parse(btn.Tag.ToString());
            panelSera.Visible = true;
            panelSera.Show();
            panelSeralar.Visible = false;

            timer1.Start();



            using (var baglan = Database.Baglanti())
            {
                var sqlKomut = new SqlCommand("SELECT * FROM seralar WHERE ID = '" + sera_ID + "'");
                sqlKomut.Connection = baglan;
                baglan.Open();

                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    txtSeraAdi.Text = sqlDataReader.GetString(1);
                    txtSeraCesiti.Text = sqlDataReader.GetString(2);
                    txtUrunCinsi.Text = sqlDataReader.GetString(3);
                    txtGubrelemeTuru.Text = sqlDataReader.GetString(4);
                    txtGubrelemeSekli.Text = sqlDataReader.GetString(5);
                    txtSulamaYontemi.Text = sqlDataReader.GetString(6);
                    txtAsilamaYontemi.Text = sqlDataReader.GetString(7);
                    txtDikimTarihi.Text = sqlDataReader.GetString(8);
                    txtAlanBuyuklugu.Text = sqlDataReader.GetString(9);
                }

                sqlDataReader.Close();
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
                    var guncelleKomut = new SqlCommand("UPDATE seralar SET sera_adi = '" + txtSeraAdi.Text + "', sera_cesiti = '" + txtSeraCesiti.Text + "', urun_cinsi = '" + txtUrunCinsi.Text + "', gubreleme_turu = '" + txtGubrelemeTuru.Text + "', gubreleme_sekli = '" + txtGubrelemeSekli.Text + "', sulama_yontemi = '" + txtSulamaYontemi.Text + "', asilama_yontemi = '" + txtAsilamaYontemi.Text + "', dikim_tarihi = '" + txtDikimTarihi.Text + "', alan_buyuklugu = '" + txtAlanBuyuklugu.Text + "' WHERE ID = '" + sera_ID + "'", baglan);

                    guncelleKomut.ExecuteNonQuery();
                    MessageBox.Show("Sera bilgilerini başarıyla güncellediniz.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    baglan.Close();
                }
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
    }
}
