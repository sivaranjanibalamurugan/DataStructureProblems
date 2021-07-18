using System;

namespace NumberofBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to binary search tree!!!");
            Console.WriteLine("Number of Binary Search tree with n node");
            int trees = NumberofBST.NumberOfTrees(3);
            Console.WriteLine("Total number of tress ={0}", trees);
        }
    }
}
