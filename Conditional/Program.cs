using System;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            // if~else
            {
                int a = 50, b = 50;
                Console.WriteLine("\nif ~ else문\na = {0}, b = {1}", a, b);
                if (a < b) Console.WriteLine("b가 a보다 큽니다."); 
                else if (a > b) Console.WriteLine("a가 b보다 큽니다.");
                else Console.WriteLine("a 와 b는 서로 같습니다.");
                // 중첩 if
                Console.WriteLine("\n중첩 if문\na = {0}", a);
                if (a > 0)
                {
                    Console.WriteLine("a는 양수입니다.");
                    if (a > 30) Console.WriteLine("a는 30보다 큽니다.");
                }
                else Console.WriteLine("a는 양수가 아닙니다.");
            }
            // switch, case(label), break
            {
                char day = '수';
                Console.WriteLine("\nswitch문\nday = {0}", day);
                switch (day)
                {
                    case '일':
                        Console.WriteLine("일요일");
                        break;
                    case '월':
                        Console.WriteLine("월요일");
                        break;
                    case '화':
                        Console.WriteLine("화요일");
                        break;
                    case '수':
                        Console.WriteLine("수요일");
                        break;
                    case '목':
                        Console.WriteLine("목요일");
                        break;
                    case '금':
                        Console.WriteLine("금요일");
                        break;
                    case '토':
                        Console.WriteLine("토요일");
                        break;
                    default:
                        Console.WriteLine("아무 요일에도 해당하지 않습니다."); 
                        break;
                }
            }
        }
    }
}
