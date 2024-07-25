using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6
{
    public class PaymentProcessor
    {
        
        public bool ProcessPayment(PaymentHandler paymentHandler, string accountNumber, double amount)
        {
            return paymentHandler(accountNumber,amount);
        }

        
    }
}
