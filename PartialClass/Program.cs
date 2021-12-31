using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Nested nested = new Nested();
            nested.Test();
            nested.Test2();
            nested.Test3();
        }
    }
    partial class Nested
    {
        public void Test() { Console.WriteLine("Test()"); }
    }
    partial class Nested
    {
        public void Test2() { Console.WriteLine("Test2()"); }
    }
    partial class Nested
    {
        public void Test3() { Console.WriteLine("Test3()"); }
    }
}
