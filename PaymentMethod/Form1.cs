using PaymentMethod.Models.Payment.Abstracts;
using PaymentMethod.Models.Payment.Managers;
using PaymentMethod.Models.Payment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSecim.DataSource = Enum.GetNames(typeof(PaymentMethods));
        }
        private Card yeniCard;
        private PaymentMethods method;
        private int[] taksitler = new[] { 1, 2, 3, 6, 9, 12 };
        private decimal sepetTutari = new Random().Next(1000, 10000);

        private void cmbSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            yeniCard ??= new Card();
            method = Enum.Parse<PaymentMethods>(cmbSecim.SelectedIndex.ToString());
            lstTaksitler.Items.Clear();
            this.Text = $"Sepet Tutarı: {sepetTutari}";
            if (method == PaymentMethods.Debit)
            {
                lstTaksitler.Items.Add($"Tek Çekim : {sepetTutari:c2}");
            }
            else if (method == PaymentMethods.Credit)
            {
                foreach (int taksit in taksitler)
                {
                    lstTaksitler.Items.Add($"{taksit} x {sepetTutari}/{taksit}:c2");
                }
            }
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            IPayable paymentmanager = null;
            switch (method)
            {
                case PaymentMethods.Credit:
                    paymentmanager = new CreditPaymentManager();
                    CreditPayment payment = new CreditPayment();
                    payment.Commission = 1.12m;
                    payment.Installment = taksitler[lstTaksitler.SelectedIndex];
                    payment.CustomerId = "123";
                    payment.Total = sepetTutari;
                    payment.CardInfo = creditCardBox1.CardInfo;

                    paymentmanager.Pay(payment);
                    break;
                case PaymentMethods.Debit:
                    paymentmanager = new DebitPaymentManager();
                    DebitPayment payment2 = new DebitPayment();
                    payment2.CardInfo = creditCardBox1.CardInfo;
                    payment2.Commision = 1.12m;
                    payment2.CustomerId = "12345";
                    payment2.TaxAmount = 12;
                    payment2.Total = sepetTutari;

                    paymentmanager.Pay(payment2);
                    break;
                default:
                    break;
            }
            if (paymentmanager.State == MessagesStates.Success)
            {
                MessageBox.Show("Ödeme işleminiz başarılı");
            }
        }

        private void creditCardBox1_AdSoyadHata(object sender, KeyPressEventArgs e)
        {
            ErrorProvider provider = new ErrorProvider();
            provider.SetError(creditCardBox1, $"Yanlış bir karakter girdiniz: {e.KeyChar}");
            provider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            //Thread.Sleep(1000);
            //provider.Clear();
            this.Text = $"Yanlış bir karakter girdiniz: { e.KeyChar}";
        }
    }
}

