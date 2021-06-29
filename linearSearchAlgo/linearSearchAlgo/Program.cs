using System;

namespace linearSearchAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 56, 3, 249, 518, 7, 26, 94, 651, 23, 9 };
            int sk = 43;
            Console.WriteLine("Enter the search key: ");
            
            linearSearchClass l = new linearSearchClass();

            int flag = l.linearSearch(array, sk);


            if (flag == -1) 
            {
                Console.WriteLine(sk + " is not found ");
            }
            else
            {
                Console.WriteLine("The " + array[flag] + " found at index " + flag);
            }
            
        }
    }
}
