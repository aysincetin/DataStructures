using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Binary tree = new Binary(27);
            tree.Add(14);
            tree.Add(35);
            tree.Add(10);
            tree.Add(42);
            tree.Delete(10);
            tree.Search(35);
            Console.WriteLine("Minimum value: " + " " + tree.minValue());
            Console.WriteLine("Maximum value: " + " " + tree.maxValue());
        }
    }
}
