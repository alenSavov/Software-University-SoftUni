using P01_BillsPaymentSystem.Data.Models;
using System;

namespace P01_BillsPaymentSystem.Initialize
{
    public class BankAccountInitializer
    {
       public static BankAccount[] GetBankAccounts()
       {
           BankAccount[] bankAccounts = new BankAccount[]
           {
               // new BankAccount() { Balance = 10, BankName = "UniCredit", SwiftCode = "1234"},
               // new BankAccount() { Balance = 20, BankName = "OBB", SwiftCode = "2345"},
               // new BankAccount() { Balance = 30, BankName = "TBI", SwiftCode = "4321"},
               // new BankAccount() { Balance = 40, BankName = "DSK", SwiftCode = "2322"}
           };
      
           return bankAccounts;
       }

    }
}
