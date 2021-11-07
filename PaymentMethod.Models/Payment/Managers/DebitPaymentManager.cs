using PaymentMethod.Models.Payment.Abstracts;
using PaymentMethod.Models.Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Managers
{
    public class DebitPaymentManager : IPayable
    {
        public MessagesStates State { get; set; }

        public void Pay(PaymentBase payment)
        {
            try
            {
                DebitPayment debit = payment as DebitPayment;
                State= MessagesStates.Success;
            }
            catch (Exception)
            {

                State= MessagesStates.Fail;
            }
        }
    }
}
