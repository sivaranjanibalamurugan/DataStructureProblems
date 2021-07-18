using System;
using System.IO;
using DatastructureProblems;

namespace DatastructureProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\user\source\repos\DatastructureProblems\DatastructureProblems\TextFile.txt";
            string text = File.ReadAllText(filepath);
            string[] textArray = text.Split(" ");
            Console.WriteLine("Implementation of Data structure Programs");
            Console.WriteLine("1.UnOrdered List\n2.Ordered List");
            Console.WriteLine("Enter choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    Console.WriteLine("Hello World!");
                    UnOrderedLinkedList<string> unOrdered = new UnOrderedLinkedList<string>();
                    for (int i = 0; i < textArray.Length; i++)
                    {
                        unOrdered.AddLast(textArray[i]);
                    }
                    Console.WriteLine("enter the word to be searched:");
                    string word = Console.ReadLine();
                    int found = unOrdered.SearchNode(word);
                    if (found == 1)
                    {
                        unOrdered.DeleteNode(word);
                    }
                    else
                    {
                        unOrdered.AddLast(word);
                    }
                    string newText = unOrdered.DisplayList();
                   
                    break;


                case 2:
                    Console.WriteLine("Ordered List");
                    SortedLinkedList<string> ordered = new SortedLinkedList<string>();
                    
                    for (int i = 0; i < textArray.Length; i++)
                    {
                        ordered.Add(textArray[i]);
                    }
                    Console.WriteLine("enter the word to be searched:");
                    string word1 = Console.ReadLine();
                    int found1 = ordered.SearchNode(word1);
                    if (found1 == 1)
                    {
                        ordered.Remove(word1);
                    }
                    else
                    {
                        ordered.Add(word1);
                    }
                    string newText1 = ordered.DisplayList();
                   
                    break;
            }
        }
    }
}