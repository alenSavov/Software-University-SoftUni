using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Optimized_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" |".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                
            List<BankAccount> bankData = new List<BankAccount>();

            while (input[0] != "end")
            {
                string bank = input[0];
                string name = input[1];
                decimal balance = decimal.Parse(input[2]);

                BankAccount newBank = new BankAccount()
                {
                    Name = name,
                    Bank = bank,
                    Balance = balance
                };

                bankData.Add(newBank);

                 input = Console.ReadLine()
                .Split(" |".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            bankData = bankData
                .OrderBy(n => n.Bank.Length)
                .OrderByDescending(bal => bal.Balance)
                .ToList();

            foreach (var account in bankData)
            {
                Console.WriteLine($"{account.Name} -> {account.Balance} ({account.Bank})");
            }
        }
    }

    public class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
    }
}
