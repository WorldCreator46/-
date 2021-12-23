using System;

namespace Type_Conersion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 암시적 변환(별도의 구문이 필요하지 않음)
            int a = 500;
            float b = a; 
            Console.WriteLine("a={0}, b={1}", a, b);
            // 명시적 변환
            double c = 123.45;
            int d = (int)c; 
            Console.WriteLine("c={0}, d={1}\n", c, d);
            // 실수, 정수 => 문자열
            Console.WriteLine("실수, 정수 => 문자열");
            b = 60.44f;
            string e = a.ToString();
            string f = b.ToString();
            Console.WriteLine("a={0}, b={1}, c={2}, d={3}\n", a, b, e, f);
            // 문자열 => 실수, 정수
            Console.WriteLine("문자열 => 실수, 정수");
            e = "123";
            f = "123.456";
            int g = int.Parse(e);
            float h = float.Parse(f);
            Console.WriteLine("e={0}, f={1}, g={2}, h={3}\n", e, f, g, h);
        }
    }
}
