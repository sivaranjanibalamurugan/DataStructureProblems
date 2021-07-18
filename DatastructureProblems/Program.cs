using System;
using System.Collections.Generic;
using System.IO;

namespace DatastructureProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DS problems!!");
            LinkedList<string> unOrdered = new LinkedList<string>();
            string filePath = @"C:\Users\user\source\repos\DatastructureProblems\DatastructureProblems\TextFile";
            string text = File.ReadAllText(filePath);
            string[] textArray = text.Split(" ");
            for (int i = 0; i < textArray.Length; i++)
            {
                unOrdered.AddLast(textArray[i]);
            }
            Console.WriteLine("enter the word to be searched:");
            string word = Console.ReadLine();
            int found = unOrdered.SearchNode;
            if (found == 1)
            {
                unOrdered.DeleteNode(word);
            }
            else
            {
                unOrdered.AddLast(word);
            }
            string newText = unOrdered.DisplayList();
            File.WriteAllText(filePath, newText);
        }
    }
}
    

