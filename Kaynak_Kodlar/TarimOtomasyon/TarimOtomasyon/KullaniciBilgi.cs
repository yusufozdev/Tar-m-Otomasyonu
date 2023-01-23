using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimOtomasyon
{
    public class KullaniciBilgi
    {
        int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        string _kullanici_ad;
        public string kullanici_ad
        {
            get { return _kullanici_ad; }
            set { _kullanici_ad = value; }
        }

        string _kullanici_soyad;
        public string kullanici_soyad
        {
            get { return _kullanici_soyad; }
            set { _kullanici_soyad = value; }
        }

        string _kullanici_mail;
        public string kullanici_mail
        {
            get { return _kullanici_mail; }
            set { _kullanici_mail = value;}
        }

        string _kullanici_parola;
        public string kullanici_parola
        {
            get { return _kullanici_parola; }
            set { _kullanici_parola = value; }
        }

        int _kullanici_yetki;
        public int kullanici_yetki
        {
            get { return _kullanici_yetki; }
            set { _kullanici_yetki = value; }
        }
    }
}
