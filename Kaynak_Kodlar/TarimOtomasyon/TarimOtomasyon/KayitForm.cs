using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TarimOtomasyon
{
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }

        public KullaniciBilgi kullaniciBilgi;
        public KullaniciIslem islem;

        private int ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return 1;
            else
                return 0;
        }


        private void btnKayit_Click(object sender, EventArgs e)
        {
            islem = new KullaniciIslem();
            kullaniciBilgi = new KullaniciBilgi();
            kullaniciBilgi.kullanici_ad = textAd.Text;
            kullaniciBilgi.kullanici_soyad = textSoyad.Text;
            kullaniciBilgi.kullanici_mail = textMail.Text;
            kullaniciBilgi.kullanici_parola = textParola.Text;

            if (!String.IsNullOrEmpty(textAd.Text) && !String.IsNullOrEmpty(textSoyad.Text) && !String.IsNullOrEmpty(textMail.Text) && !String.IsNullOrEmpty(textParola.Text))
            {
                if (ValidateEmail(textMail.Text) == 1)
                {
                    if (islem.KullaniciKayit(kullaniciBilgi))
                    {
                        MessageBox.Show("Hesabınız başarıyla oluşturuldu. Artık sisteme giriş yapabilirsiniz.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hesabınız oluşturulurken bir hatayla karşılaşıldı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz bir e-posta adresi girdiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Boş bıraktığınız alanlar var!.", "Boş Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

            GirisForm giris = new GirisForm();
            giris.Show();
            this.Hide();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
