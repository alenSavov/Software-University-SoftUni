using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankingSystem = new Dictionary<string, Dictionary<string, decimal>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                    .Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string bankName = tokens[0];
                string bankAccount = tokens[1];
                decimal accountBalance = decimal.Parse(tokens[2]);

                if (!bankingSystem.ContainsKey(bankName))
                {
                    bankingSystem[bankName] = new Dictionary<string, decimal>();
                }
                if (!bankingSystem[bankName].ContainsKey(bankAccount))
                {
                    bankingSystem[bankName][bankAccount] = 0m;
                }
                bankingSystem[bankName][bankAccount] += accountBalance;

                inputLine = Console.ReadLine();
            }

            bankingSystem
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToList()
                .ForEach(bank => bank.Value
                .OrderByDescending(account => account.Value)
                .ToList()
                .ForEach(accout => Console.WriteLine($"{accout.Key} -> {accout.Value} ({bank.Key})")));



        }
    }
}
