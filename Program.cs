using System;

namespace DatastructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 5, 6, 7, 9, 12, 15, 34, 56 };
            if (BinarySearch.MyBinarySearch(arr, 7) > 0)
            {
                Console.WriteLine("You have it");
            }
            else
            {
                Console.WriteLine("Get the other one");
            }
            Console.ReadLine();
        }
    }
}
