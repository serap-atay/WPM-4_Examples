using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Models
{
    public class Card
    {
        public string CardNo { get; set; }
        public string AdSoyad { get; set; }
        public int CardAy { get; set; }
        public int CardYil { get; set; }
        public string CardCvv { get; set; }
    }
}
