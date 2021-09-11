using System;

namespace binarySearchAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Enter size of an array: ");
            size = int.Parse(Console.ReadLine());
            Random random = new Random();

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, size);
            }

            Array.Sort(array);
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            int x;

            Console.WriteLine("");
            Console.Write("Enter search key: ");

            x = int.Parse(Console.ReadLine());
            int n = array.Length;

            binarySearch b = new binarySearch();
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            int result = b.binarySearchmethod(array, x, 0, n-1);

            watch.Stop();

            if (result == -1)
            {
                Console.WriteLine("Not Found!");
            }
            else
            {
                Console.WriteLine("Element is found at index " + result);
                Console.WriteLine("Time: " + watch.Elapsed);
            }
        }
    }
}