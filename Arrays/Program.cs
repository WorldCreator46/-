using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array
            {
                int[] reading = new int[6] { 4, 9, 1, 0, 21, 12 };
                Console.WriteLine("Array");
                for (int i = 0; i < reading.Length; i++)
                    Console.WriteLine("reading[" + i + "]={0}", reading[i]);
            }
            {
                int[] reading = new int[] { 4, 9, 1, 0, 21, 12 };
                Console.WriteLine("\n속성: Rank={0}, Length={1}", reading.Rank, reading.Length);
                Console.Write("Clear 메소드: ");
                Array.Clear(reading, 0, 5);
                Array.ForEach<int>(reading, new Action<int>(ShowValue));
                Console.WriteLine();
                Console.Write("Resize 메소드: ");
                Array.Resize(ref reading, reading.Length + 3);
                Array.ForEach<int>(reading, new Action<int>(ShowValue));
                Console.WriteLine();
                Console.WriteLine("indexOf 메소드: {0}", Array.IndexOf(reading, 12));

                static void ShowValue(int value)
                {
                    Console.Write("{0} ", value);
                }
            }
            // 2차원 Array
            {
                Console.WriteLine("\n2차원 Array");
                int[,] reading = new int[3, 6] { { 4, 9, 1, 0, 21, 12 }, { 1, 4, 6, 0, 9, 5 }, { 4, 4, 2, 4, 0, 0 } };
                for (int i = 0; i < reading.GetLength(0); i++)
                    for (int j = 0; j < reading.GetLength(1); j++)
                        Console.WriteLine("reading[" + i + ", " + j + "] = {0}", reading[i, j]);
            }
        }
    }
}
