using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TarimOtomasyon
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        public KullaniciBilgi kullaniciBilgi;
        public KullaniciIslem islem;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string userMail = txtMail.Text;
            string userParola = CreateMD5Hash(txtParola.Text);

            if (!String.IsNullOrEmpty(txtMail.Text) && !String.IsNullOrEmpty(txtParola.Text))
            {
                islem = new KullaniciIslem();
                kullaniciBilgi = islem.kullaniciGetir(userMail, userParola);
                if (kullaniciBilgi != null)
                {
                    MainPage goMain = new MainPage();
                    goMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bilgilerinizden en az birini hatalı olarak girdiniz, tekrar gözden geçirip yeniden deneyin.", "Hatalı Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Boş bıraktığınız alanlar var!", "Boş Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void btnKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayitForm form = new KayitForm();
            form.Show();
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "E-Posta adresiniz")
                txtMail.Text = "";
            txtMail.ForeColor = System.Drawing.Color.White;
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
                txtMail.Text = "E-Posta adresiniz";
            txtMail.ForeColor = System.Drawing.Color.Silver;
        }

        private void txtParola_Enter(object sender, EventArgs e)
        {
            if (txtParola.Text == "Parola")
                txtParola.Text = "";
            txtParola.ForeColor = System.Drawing.Color.White;
            txtParola.PasswordChar = '•';
        }

        private void txtParola_Leave(object sender, EventArgs e)
        {
            if (txtParola.Text == "")
            {
                txtParola.Text = "Parola";
                txtParola.PasswordChar = (char)0;
            }
            txtParola.ForeColor = System.Drawing.Color.Silver;
            
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnGiris;
        }
    }
}
