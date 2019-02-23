using P01_BillsPaymentSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P01_BillsPaymentSystem.Initialize
{
    public class Initialize
    {
        public static void Seed(BillsPaymentSystemContext context)
        {
            InsertUsers(context);
            InsertCreditCard(context);
            InsertBankAccount(context);
            InsertPaymentMethod(context);
        }

        private static void InsertPaymentMethod(BillsPaymentSystemContext context)
        {
            var payments = PaymentMethodInitiali.GetPaymentMethods();

            for (int i = 0; i < payments.Length; i++)
            {
                if (IsValid(payments[i]))
                {
                    context.PaymentMethods.Add(payments[i]);
                }
            }

            context.SaveChanges();
        }

        private static void InsertBankAccount(BillsPaymentSystemContext context)
        {
            var bankAccounts = BankAccountInitializer.GetBankAccounts();

            for (int i = 0; i < bankAccounts.Length; i++)
            {
                if (IsValid(bankAccounts[i]))
                {
                    context.BankAccount.Add(bankAccounts[i]);
                }
            }
        }

        private static void InsertCreditCard(BillsPaymentSystemContext context)
        {
            var creditCards = CreditCardInitializer.GetCreditCards();

            for (int i = 0; i < creditCards.Length; i++)
            {
                if (IsValid(creditCards[i]))
                {
                    context.CreditCards.Add(creditCards[i]);
                }
            }

            context.SaveChanges();
        }

        private static void InsertUsers(BillsPaymentSystemContext context)
        {
            var users = UserInitialize.GetUsers();

            for (int i = 0; i < users.Length; i++)
            {
                if (IsValid(users[i]))
                {
                    context.Users.Add(users[i]);
                }
            }

            context.SaveChanges();
        }

        private static bool IsValid(object obj)
        {
            var validContext = new ValidationContext(obj);
            var result = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validContext, result, true);
        }
    }
}
