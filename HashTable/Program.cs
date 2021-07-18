using System;
using System.IO;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table!");
            //creat the object for hash class
            HashTable<int> hash = new HashTable<int>(10);
            Console.WriteLine("search a number using the hash table");
            string filePath = @"C:\Users\user\source\repos\DatastructureProblems\HashTable\NumFile.txt";
            string text = File.ReadAllText(filePath);
            Program.ReadInput(text, hash);
            Console.WriteLine("Enter the number to search:");
            int search = Convert.ToInt32(Console.ReadLine());
            //if the element is present write the into the list 
            if (hash.Search(search) == 1)
            {
                Console.WriteLine("{0} is found", search);
                File.WriteAllText(filePath, hash.display());
            }
            else
            {
                hash.AddNode(search);
                Console.WriteLine("{0} is not found", search);
                File.WriteAllText(filePath, hash.display());
            }
        }
        //read input from file and store it in hash table
        public static void ReadInput(string text, HashTable<int> hash)
        {
            int number;
            string[] textArray = text.Split(" ");
            for (int i = 0; i < textArray.Length - 1; i++)
            {
                if (!(textArray[i].Equals(" ")))
                {
                    number = Convert.ToInt32(textArray[i]);
                    hash.AddNode(number);
                }
            }
        }
    }
    
}
