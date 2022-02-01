using System;
using static System.Console;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(new Random().Next(100, 1000));
        }
    }
}
