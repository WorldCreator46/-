using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // 수식 연산자
            {
                int a = 74, b = 7;
                Console.WriteLine("\n수식 연산자");
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                /* 
                 * 정수 간 나눗셈은 정수이기 때문에 아래와 같이 제수나 피제수를 실수로 변환해야한다.
                 * Console.WriteLine("{0} / {1} = {2}", a, b, a / (double)b);
                 * Console.WriteLine("{0} / {1} = {2}", a, b, (a + 0.0) / b);
                 * Console.WriteLine("{0} / {1} = {2}", a, b, 1.0 * a / b);
                 */
                Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
            }
            // 증감 연산자
            {
                int a = 1;
                Console.WriteLine("\n증감 연산자\na = {0}", a);
                // a의 값을 1 증가시키고(a = 2), a의 값을 출력(2)
                Console.WriteLine("++a = {0}", ++a);
                // a의 값을 출력한 뒤(2), a의 값을 1 증가(a = 3)
                Console.WriteLine("a++ = {0}", a++);
                // a의 값을 1 감소시키고(a = 2), a의 값을 출력(2)
                Console.WriteLine("--a = {0}", --a);
                // a의 값을 출력한 뒤(2), a의 값을 1 감소(a = 1)
                Console.WriteLine("a-- = {0}", a--);
                a = 3;
                int b = 5;
                // a++ + b의 결과는 8, 출력 후 a = 4, b = 5
                Console.WriteLine("\na = {0}, b = {1}\na++ + b = {2}", a, b, a++ + b);
                a = 3;
                b = 5;
                // a++ + --b의 결과는 7, 출력 후 a = 4, b = 4
                Console.WriteLine("a++ + --b = {0}", a++ + --b);
                a = 3;
                // ++a + a++의 결과는 8, 출력 후 a =5
                Console.WriteLine("++a + a++ = {0}", ++a + a++);
            }
            // 관계 연산자
            {
                int a = 70, b = 80;
                Console.WriteLine("\n관계연산자\na = {0}, b = {1}", a, b);
                Console.WriteLine("a < b = {0}", a < b);
                Console.WriteLine("a > b = {0}", a > b);
                Console.WriteLine("a == b = {0}", a == b);
                Console.WriteLine("a != b = {0}", a != b);
                Console.WriteLine("a >= b = {0}", a >= b);
                Console.WriteLine("a <= b = {0}", a <= b);
            }
            // 할당 연산자
            {
                int a = 50, b = 60;
                Console.WriteLine("\n할당 연산자\na = {0}, b = {1}", a, b);
                a += b; Console.WriteLine("a += b => a = {0}", a);
                a -= b; Console.WriteLine("a -= b => a = {0}", a);
                a *= b; Console.WriteLine("a *= b => a = {0}", a);
                a /= b; Console.WriteLine("a /= b => a = {0}", a);
                a %= b; Console.WriteLine("a %= b => a = {0}", a);
            }
            // 논리 연산자
            {
                int a = 50, b = 60;
                Console.WriteLine("\n논리 연산자\na = {0}, b = {1}", a, b);
                Console.WriteLine("a > 40 && b > 50 = {0}", a > 40 && b > 50);
                Console.WriteLine("a > 40 || b > 70 = {0}", a > 40 || b > 70);
                Console.WriteLine("!(a < b) = {0}", !(a < b));
            }
            // 비트 연산자
            {
                int a = 5, b = 10;
                Console.WriteLine("\n비트 연산자\na = {0}, b = {1}", a, b);
                Console.WriteLine("a & b = {0}", a & b); // 비트 단위 AND 연산
                Console.WriteLine("a | b = {0}", a | b); // 비트 단위 OR 연산
                Console.WriteLine("a ^ b = {0}", a ^ b); // 비트 단위 XOR 연산
            }
            // 시프트 연산자
            {
                int a = 616;
                Console.WriteLine("\n시프트 연산자\na = {0}", a);
                // 비트가 왼쪽으로 4칸 밀림(새로 나타난 하위 비트는 0으로 채워짐)
                Console.WriteLine("a << 4 = {0}", a << 4);
                // 비트가 오른쪽으로 4칸 밀림
                // (새로 나타난 하위 비트는 부호 비트로 채워짐(양수 = 0, 음수 = 1))
                Console.WriteLine("a >> 4 = {0}", a >> 4); 
            }
        }
    }
}
