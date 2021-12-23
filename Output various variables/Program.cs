using System;

namespace Output_various_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // 정수형
            byte int_a = 200;
            sbyte int_b = -100;
            short int_c = 30000;
            ushort int_d = 40000;
            int int_e = 1000000;
            uint int_f = 2000000;
            long int_g = 4100000;
            ulong int_h = 9200000;
            Console.WriteLine("정수형\na={0}, b={1}, c={2}, d={3}, e={4}, f={5}, g={6}, h={7}\n",
                int_a, int_b, int_c, int_d, int_e, int_f, int_g, int_h);
            // 실수형
            float real_a = 1234.5678f;
            double real_b = 1234.5678910;
            decimal real_c = 1234.56789101112m;
            Console.WriteLine("실수형\na={0}, b={1}, c={2}\n", real_a, real_b, real_c);
            // 문자, 문자열
            char text_a = '안';
            string text_b = "녕하세요.";
            Console.WriteLine("문자, 문자열\n{0}{1}\n", text_a, text_b);
            // 논리 자료형
            bool bool_a = true;
            bool bool_b = false;
            Console.WriteLine("논리 자료형\na={0}, b={1}\n", bool_a, bool_b);
            // 객체 자료형
            object obj_a = 123456789;
            object obj_b = 1234.56789;
            object obj_c = true;
            object obj_d = "안녕하세요";
            Console.WriteLine("객체 자료형\na={0}, b={1}, c={2}, d={3}\n", obj_a, obj_b, obj_c, obj_d);
        }
    }
}
