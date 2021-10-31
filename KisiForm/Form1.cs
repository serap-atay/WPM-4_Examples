using Kisi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Ders dersler = new Ders();
        Kisi kisi = new Kisi();

        private List<Kisi> kisiler = new List<Kisi>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi yenikisi = new Kisi();
            yenikisi.Ad = txtAd.Text;
            yenikisi.SoyAd = txtSoyAd.Text;
            yenikisi.DogumYili = dtpDogum.Value;
            kisiler.Add(yenikisi);
            lstKisiler.Items.Add(yenikisi.ToString());

        }
    }
}
