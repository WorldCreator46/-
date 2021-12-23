using System;

namespace Format_Specifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // 수치 서식 문자열
            int a = 123456789;
            double b = 123.456789;
            Console.WriteLine("수치 서식 문자열");
            Console.WriteLine("통화 (C)       : {0:C}", a);
            Console.WriteLine("10진법 (D)     : {0:D}", a);
            Console.WriteLine("지수 표기법 (E): {0:E}", b);
            Console.WriteLine("고정 소수점 (F): {0:F}", b);
            Console.WriteLine("일반 (G)       : {0:G}", a);
            Console.WriteLine("숫자 (N)       : {0:N}", a);
            Console.WriteLine("16진법 (X)     : {0:X}", a);
            Console.WriteLine("백분율 (P)     : {0:P}\n", b);
            // 사용자 지정 수치 서식 문자열 (Custom Numeric Format Strings)
            a = 1234;
            b = 12.345678;
            Console.WriteLine("사용자 지정 수치 서식 문자열");
            Console.WriteLine("0 자리 표시 (0)        : {0:00000}", a);
            Console.WriteLine("10진수 자리 표시 (#)   : {0:#####}", a);
            Console.WriteLine("소수점 (.)             : {0:0.00000}", b);
            Console.WriteLine("천 단위 자릿수 표시 (,): {0:0,0}", a);
            Console.WriteLine("백분율 자리 표시 (%)   : {0:0%}", b);
            Console.WriteLine("지수 표기법 (e)        : {0:0.000e+0}\n", b);
            // 텍스트 정렬
            Console.WriteLine("텍스트 정렬");
            Console.WriteLine("|{0,15}|", a);
            Console.WriteLine("|{0,-15}|", a);
            Console.WriteLine("|{0,15:N0}|", a);
            Console.WriteLine("|{0,-15:N0}|", a);
        }
    }
}
