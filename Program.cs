using System;

namespace Learning.oop.homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccountOne = new BankAccount();
            BankAccount bankAccountTwo = new BankAccount();
            bankAccountTwo.AccountBalance = 1000;
            bankAccountOne.Transaction(bankAccountTwo, 300);

            Console.WriteLine($"bankAccountOne.AccountBalance = { bankAccountOne.AccountBalance }; bankAccountTwo = {bankAccountTwo.AccountBalance}");
        }
    }
}
