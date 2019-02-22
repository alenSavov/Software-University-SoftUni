using System;
using System.Collections.Generic;
using System.Text;


public class BankAccount
{
    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public void Deposit(int id,decimal amount)
    {
        balance += amount; 
    }
    public void Withdraw(int id, decimal amount)
    {
        balance -= amount;
    }
    public override string ToString()
    {
        return $"Account ID{this.id}, balance {this.balance:f2}";
    }

}

