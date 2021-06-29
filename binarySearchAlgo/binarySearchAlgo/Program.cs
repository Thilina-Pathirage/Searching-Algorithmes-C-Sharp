using System;

namespace binarySearchAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = { 3, 4, 5, 6, 7, 8, 9 };
            int n = array.Length;
            int x = 5;

            binarySearch b = new binarySearch();
            int result = b.binarySearchmethod(array, x, 0, n - 1);
            if (result == -1)
                Console.WriteLine("Not Found!");
            else
                Console.WriteLine("Element is found at index " + result);
        }
    }
}
