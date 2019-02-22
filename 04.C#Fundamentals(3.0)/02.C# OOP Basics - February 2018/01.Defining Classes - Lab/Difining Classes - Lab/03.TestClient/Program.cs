using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        var data = new Dictionary<int, BankAccount>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            var splitCommand = command.Split();
            var accountId = int.Parse(splitCommand[1]);

            switch (splitCommand[0])
            {
                case "Create":
                    if (data.ContainsKey(accountId))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        var acc = new BankAccount();
                        acc.Id = accountId;
                        data.Add(accountId, acc);
                    }
                    break;
                case "Deposit":
                    if (data.ContainsKey(accountId) == false)
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        data[accountId].Balance += int.Parse(splitCommand[2]);
                    }
                    break;
                case "Withdraw":
                    if (data.ContainsKey(accountId))
                    {
                        if (data[accountId].Balance < int.Parse(splitCommand[2]))
                        {
                            Console.WriteLine($"Insufficient balance");
                        }
                        else
                        {
                            data[accountId].Balance -= int.Parse(splitCommand[2]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    break;
                case "Print":
                    if (data.ContainsKey(accountId))
                    {
                        Console.WriteLine(data[accountId].ToString());
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    break;
            }
        }
    }
}

