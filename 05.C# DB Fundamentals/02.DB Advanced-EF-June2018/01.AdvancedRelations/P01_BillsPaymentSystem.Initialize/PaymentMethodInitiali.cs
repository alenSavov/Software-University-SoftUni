using P01_BillsPaymentSystem.Data.Models;
using P01_BillsPaymentSystem.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Initialize
{
    public class PaymentMethodInitiali
    {
        public static PaymentMethod[] GetPaymentMethods()
        {
            PaymentMethod[] paymentMethods = new PaymentMethod[]
            {
                 new PaymentMethod() {UserId = 1, BankAccountId = 1, Type = PaymentType.BankAccount},
                 new PaymentMethod() {UserId = 2, BankAccountId = 2, Type = PaymentType.CreditCard},
                 new PaymentMethod() {UserId = 3, BankAccountId = 3, Type = PaymentType.BankAccount},
                 new PaymentMethod() {UserId = 3, BankAccountId = 4, Type = PaymentType.CreditCard}
            };

            return paymentMethods;
        }
    }
}
