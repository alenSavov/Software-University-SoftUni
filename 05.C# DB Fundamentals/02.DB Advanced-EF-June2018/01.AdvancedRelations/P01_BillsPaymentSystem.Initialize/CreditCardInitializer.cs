using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Initialize
{
    public class CreditCardInitializer
    {
        public static CreditCard[] GetCreditCards()
        {
            CreditCard[] creditCards = new CreditCard[]
            {
                // new CreditCard() { Limit = 200, MoneyOwed =0, ExpirationDate = DateTime.Now.AddMonths(-12)},
                // new CreditCard() { Limit = 300, MoneyOwed =0, ExpirationDate = DateTime.Now.AddMonths(-1)},
                // new CreditCard() { Limit = 400, MoneyOwed =0, ExpirationDate = DateTime.Now.AddMonths(-2)},
                // new CreditCard() { Limit = 500, MoneyOwed =0, ExpirationDate = DateTime.Now.AddMonths(-10)}
            };
      
            return creditCards;
        }
    }
}
