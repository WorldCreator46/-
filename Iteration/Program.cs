using System;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            {
                int num = 1;
                Console.WriteLine("while문\tnum = {0}", num);
                while (num <= 10) Console.WriteLine("num: {0}", num++);
            }
            // do while
            {
                int num = 1;
                Console.WriteLine("\ndo while문\tnum = {0}", num);
                do
                {
                    Console.WriteLine("num: {0}", num++);
                }
                while (num <= 10);
            }
            // for
            {
                int num = 1;
                Console.WriteLine("\nfor문\tnum = {0}", num);
                for (num = 1; num <= 10; num++)
                    Console.WriteLine("num: {0}", num);
            }
            // foreach
            {
                int[] arr = { 1, 2, 5, 7, 4, 9, 8, 10, 4, 7, 11 };
                Console.WriteLine("\nforeach문");
                foreach (int i in arr) 
                    Console.WriteLine("i: {0}", i);
            }
            // 중첩 for
            {
                Console.WriteLine("\n중첩 for문\n");
                for (int a = 2; a < 10; a++) 
                {
                    for (int b = 1; b < 10; b++) 
                    { 
                        Console.WriteLine("{0} * {1} = {2}", a, b, a * b); 
                    }
                    Console.WriteLine();
                } 
            }
        }
    }
}
