using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6
{
    public delegate bool PaymentHandler(string acnt, double amnt);
    public class PaymentProcessingApp
    {
        public bool ProcessMastercardPayment(string acnt, double amnt)
        {
            Console.WriteLine($"Processing MasterCard Payment for account number:{acnt} amount:{amnt}");
            return true;
        }

        public bool ProcessVisaPayment(string acnt, double amnt)
        {
            Console.WriteLine($"Processing Visa Payment for account number:{acnt} amount:{amnt}");
            return true;
        }

        public bool ProcessDiscoverPayment(string acnt, double amnt)
        {
            Console.WriteLine($"Processing Discover Payment for account number:{acnt} amount:{amnt}");
            return true;
        }


    }
}
