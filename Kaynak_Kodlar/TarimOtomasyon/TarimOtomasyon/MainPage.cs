using FontAwesome.Sharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace TarimOtomasyon
{
    public partial class MainPage : Form
    {

        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public MainPage()
        {
            InitializeComponent();
        }

        int yetki = 0;

        private void MainPage_Load(object sender, EventArgs e)
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(6, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            altMenuGizle();
            using (StreamReader file = File.OpenText($@"kullanici_bilgi.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                KullaniciBilgi kullaniciBilgi = (KullaniciBilgi)serializer.Deserialize(file, typeof(KullaniciBilgi));
                labelKullaniciAdSoyad.Text = "Hoşgeldiniz, " + kullaniciBilgi.kullanici_ad + " " + kullaniciBilgi.kullanici_soyad;
                yetki = kullaniciBilgi.kullanici_yetki;
            }

            if (yetki == 1)
            {
                btnYonetici.Show();
            }
            else
            {
                btnYonetici.Hide();
            }

            XmlTextReader xmloku = new XmlTextReader("https://www.tarimdanhaber.com/rss");

            xmloku.ReadToFollowing("item");

            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    tarimdanHaberler.Items.Add(xmloku.ReadString());
                }
            }

            XmlDocument xmlVerisi = new XmlDocument();
            xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
            decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
            decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));

            lblDolar.Text = dolar.ToString();
            lblEuro.Text = euro.ToString();
            lblSterlin.Text = sterlin.ToString();

            WebClient webClient = new WebClient();
            string publicIp = webClient.DownloadString("https://api.ipify.org");

            string apiKey = "572ea8b24cfc47e0af1112608221505";
            string havaDurumuServisURL = "http://api.weatherapi.com/v1/current.xml?key="+ apiKey +"&q=" + publicIp + "&lang=tr";

            XDocument havaDurumuServis = XDocument.Load(havaDurumuServisURL);

            string sehir = havaDurumuServis.Descendants("region").ElementAt(0).Value;
            var sicaklik = havaDurumuServis.Descendants("temp_c").ElementAt(0).Value;
            string havaDurumu = havaDurumuServis.Descendants("text").ElementAt(0).Value;
            string havaDurumuResim = havaDurumuServis.Descendants("icon").ElementAt(0).Value;

            lblHavaDurumuSehir.Text = sehir;
            lblHavaDurumuSicaklik.Text = sicaklik + " °C";

            lblHavaDurumu.Text = havaDurumu;
            pictureHavaDurumu.ImageLocation = "http:" + havaDurumuResim;

            label6.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
            timer1.Start();
        }

        private void altMenuGizle()
        {
            panelSeraAltMenu.Visible = false;
        }

        private void altMenuGoster(Panel altMenu)
        {
            if (altMenu.Visible == false)
            {
                altMenuGizle();
                altMenu.Visible = true;
            }
            else
                altMenu.Visible = false;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(47, 49, 54);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconMevcutSayfa.IconChar = currentBtn.IconChar;
                iconMevcutSayfa.IconColor = Color.FromArgb(206, 207, 209);
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(47, 49, 54);
                currentBtn.ForeColor = Color.FromArgb(94, 97, 103);
                currentBtn.IconColor = Color.FromArgb(94, 97, 103);
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelAna.Controls.Add(childForm);
            panelAna.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelHeaderTitle.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconMevcutSayfa.IconChar = IconChar.Home;
            iconMevcutSayfa.IconColor = Color.FromArgb(206, 207, 209);
            labelHeaderTitle.Text = "Anasayfa";
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void btnUyelik_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(57, 60, 67));
            OpenChildForm(new UyelikForm());
            altMenuGizle();
        }

        private void btnSeralarim_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(57, 60, 67));
            OpenChildForm(new SeraForm());
            altMenuGoster(panelSeraAltMenu);
        }

        private void btnCiftlikTV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(57, 60, 67));
            OpenChildForm(new CiftlikTVForm());
            altMenuGizle();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(57, 60, 67));
            OpenChildForm(new AyarlarForm());
            altMenuGizle();
        }
        private void btnYonetici_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(57, 60, 67));
            OpenChildForm(new YoneticiForm());
            altMenuGizle();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelUst_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSeraEkle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(57, 60, 67));
            OpenChildForm(new SeraEkleForm());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tarimdanhaber.com/");
        }

        private void tarimdanHaberler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.tarimdanHaberler.IndexFromPoint(e.Location);
            XDocument tarimLinkServis = XDocument.Load("https://www.tarimdanhaber.com/rss");
            string tarimLink = tarimLinkServis.Descendants("link").ElementAt(index + 2).Value;
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                System.Diagnostics.Process.Start(tarimLink);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");

            using (StreamReader file = File.OpenText($@"kullanici_bilgi.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                KullaniciBilgi kullaniciBilgi = (KullaniciBilgi)serializer.Deserialize(file, typeof(KullaniciBilgi));
                labelKullaniciAdSoyad.Text = "Hoşgeldiniz, " + kullaniciBilgi.kullanici_ad + " " + kullaniciBilgi.kullanici_soyad;
            }
        }

    }
}
