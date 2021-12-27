using System;

namespace Iteration2__goto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Infinity loop
            {
                int sum = 0;
                Console.WriteLine("Infinity loop(while(true), while(1), for(;;))\n" +
                    "int sum = 0");
                while (true)
                {
                    Console.Write("수를 입력하세요: "); 
                    string line = Console.ReadLine();
                    if (line == "end") break;
                    sum += int.Parse(line);
                }
                Console.WriteLine("지금까지 입력된 수를 모두 더합니다: " + sum);
            }
            // break
            {
                int num = 0, lim = 40;
                Console.WriteLine("\nbreak\nint num = 0\nnum이 {0}이 되면 탈출", lim);
                while (num < 100)
                {
                    if (num == lim) break;
                    Console.WriteLine("num: " + num); 
                    num++;
                }
            }
            // continue
            {
                int i, j = 2, z = 1;
                Console.WriteLine("\ncontinue\nint i, j = {0}, z = {1}\ni를 j로 나눈 나머지의 값이 z라면 건너뛰기", j, z);
                for (i = 1; i <= 50; i++) 
                {
                    if (i % j == z) continue;
                    Console.WriteLine("i: " + i); 
                }
            }
            // goto
            {
                int num = 0, lim = 40;
                Console.WriteLine("\ngoto\nint num = 0\nnum이 {0}이 되면 EXIT 문으로 이동", lim);
                while (num < 100)
                {
                    if (num == lim) goto EXIT;
                    Console.WriteLine("num: " + num);
                    num++;
                }
                EXIT:
                Console.WriteLine("탈출!");
            }
        }
    }
}
