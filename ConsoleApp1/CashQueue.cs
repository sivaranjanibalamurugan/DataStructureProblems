using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
    public class Node<T>
    {
        public T value;
        public Node<T> Next;
        public Node(T value)
        {
            this.value = value;
            this.Next = null;
        }
    }

    class CashCounterQueue<T>
    {
        private Node<T> front;
        private Node<T> rear;
        int amount = 1000;
        //method to insert the element in front;
        public void AddFirst(T value)
        {
            //creating the new node with given value
            Node<T> newNode = new Node<T>(value);
            //check whether the front is null or not . 
            if (front == null)
            {
                front = newNode;
            }
            //make ne element as head
            else
            {
                rear = front;
                while (rear.Next != null)
                {
                    rear = rear.Next;
                }
                rear.Next = newNode;
            }
        }
        public string DeleteFirst()
        {
            rear = front;
            if (rear == null)
            {
                Console.WriteLine("No element in the list");
            }
            //make the next node as head
            else
            {
                front = front.Next;
            }
            return rear.value.ToString();
        }
        public void DisplayList()
        {
            rear = front;
            //if head is null then no element is present
            if (front == null)
            {
                Console.WriteLine("No element in the list");
            }
            //else until temp become null print the elements 
            else
            {
                while (rear != null)
                {
                    Console.WriteLine("" + rear.value);
                    rear = rear.Next;
                }
            }
        }
        public void SelectChoice(LinkedList<BankAccount> banks)
        {
            string name = DeleteFirst();
           // int amount;
            BankAccount account = null;
            foreach (BankAccount i in banks)
            {
                if (i.accHolder.Equals(name))
                {
                    account = i;
                }
            }
            Console.WriteLine("Enter 1.Deposit\n2.Withdraw");
            Console.Write("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter amount to deposit:");
                    int amt = Convert.ToInt32(Console.ReadLine());
                    UpdateChange(account, amt, banks, name, choice);
                    break;
                case 2:
                    Console.WriteLine("Enter amount to withdraw:");
                    int amt1 = Convert.ToInt32(Console.ReadLine());
                    if (account.amount > amt1 && account != null)
                    {
                        UpdateChange(account, amt1, banks, name, choice);

                    }
                    else
                    {
                        Console.WriteLine("no balance available");
                    }
                    break;
            }
        }
        public void UpdateChange(BankAccount bank, int amount, LinkedList<BankAccount> bankAccounts, string name, int choice)
        {
            if (bank == null)
            {
                BankAccount bank1 = new BankAccount(name, amount);
                bankAccounts.AddLast(bank1);
            }
            else if (choice == 1)
            {
                bank.amount = bank.amount + amount;
            }
            else
            {
                bank.amount = bank.amount - amount;
            }
        }
    }
}