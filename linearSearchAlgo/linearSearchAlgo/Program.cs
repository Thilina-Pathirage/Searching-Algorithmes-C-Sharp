using System;

namespace linearSearchAlgo
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

            for (int i = 0; i < size; i ++)
            {
                array[i] = random.Next(0, size);
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }

            int sk;

            Console.WriteLine("");
            Console.Write("Enter search key: ");

            sk = int.Parse(Console.ReadLine());

            linearSearchClass l = new linearSearchClass();

            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            int flag = l.linearSearch(array, sk);

            watch.Stop();


            if (flag == -1) 
            {
                Console.WriteLine(sk + " is not found ");
            }
            else
            {
                Console.WriteLine("The " + array[flag] + " found at index " + flag);
                Console.WriteLine("Time: " + watch.Elapsed);
            }

            Console.ReadLine();
        }
    }
}
