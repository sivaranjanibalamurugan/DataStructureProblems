using System;

namespace PrimeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to prime array!");
            Console.WriteLine("Printing the 2D array of prime number between 0-1000");
            PrimeNumber prime = new PrimeNumber();
            prime.StorePrime();
            prime.Print();

            Console.WriteLine();
            Console.WriteLine("Printing 2D Array of Prime Anagram");
            prime.StoreAnagaram();
            prime.PrintAnagram();
            Console.WriteLine("Print anagram in queue");
            prime.PrintAnagramQueue();
        }
    }
}
