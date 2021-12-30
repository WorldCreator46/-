using System;

namespace Access_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // 접근 제한자(Access Modifier)
            A a = new A();
            a.b = 3;
            a.c = 4;
            Console.WriteLine($"a.b = {a.b}\na.c = {a.c}");
        }
    }
    class A
    {
        public int b, c;
    }
}
