using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiForm
{
   public class Kisi
    {
        private string _ad;
        private string _soyad;
        private string _tc;
        public DateTime DogumYili { get; set; }
        public string Ad
        {
            get
            {
                return _ad;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new FormatException(message: "Lütfen bir değer giriniz.");
                foreach (char harf in value)
                {
                    if (char.IsDigit(harf))
                    {
                        throw new FormatException(message: "Sadece harf giriniz:");
                    }
                }
                _ad = value;
            }
            
        }
        public string SoyAd
        {
            get
            {
                return _soyad.Substring(0, 1).ToUpper() + _soyad.Substring(1).ToLower(); ;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new FormatException(message: "Lütfen bir değer giriniz.");
                foreach (char harf in value)
                {
                    if (char.IsDigit(harf))
                    {
                        throw new FormatException(message: "Sadece harf giriniz:");
                    }
                }
                _soyad = value;
            }
        }
        public int Yas
        {
            get
            {
                return DateTime.Now.Year - this.DogumYili.Year;
            }
        }
        public override string ToString()
        {
            return $"{this.Ad} {this.SoyAd} {this.Yas}";
    }
        
    }

}
