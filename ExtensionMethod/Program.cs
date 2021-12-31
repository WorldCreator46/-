using Extension;
using System;

namespace Extension
{
    public static class ExtensionMethod
    {
        public static int Multiplication(this int var, int a, int b)
        {
            int result = var;
            for (int i = 0; i < b; i++)
                result *= a;
            return result;
        }
    }
}
namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5.Multiplication(2, 3));
        }
    }
}
