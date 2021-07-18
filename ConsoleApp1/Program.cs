using System;
using System.Collections.Generic;
namespace CashCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to bank");
            BankAccount account;
            LinkedList<BankAccount> bankAccountsList = new LinkedList<BankAccount>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter account holder name:");
                string name = Console.ReadLine();
                Console.WriteLine("enter amount:");
                int amount = Convert.ToInt32(Console.ReadLine());
                account = new BankAccount(name, amount);
                bankAccountsList.AddLast(account);

            }
            CashCounterQueue<string> cashCounter = new CashCounterQueue<string>();
            cashCounter.AddFirst("person1");
            cashCounter.AddFirst("person2");
            cashCounter.AddFirst("person3");
            cashCounter.SelectChoice(bankAccountsList);
            cashCounter.SelectChoice(bankAccountsList);
            cashCounter.SelectChoice(bankAccountsList);
            foreach (BankAccount i in bankAccountsList)
            {
                Console.WriteLine("Account holder:{0}   balance:{1}", i.accHolder, i.amount);
            }
        }
    }
}