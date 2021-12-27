using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call by value (값을 복사)
            {

                int a = 40, b = 10;
                Console.WriteLine("Call by value\nSwap before: a={0}, b={1}", a, b);
                Swap(a, b);
                Console.WriteLine("Swap after: a={0}, b={1}", a, b);
                static void Swap(int a, int b)
                {
                    int temp = b;
                    b = a;
                    a = temp;
                }
            }
            // Call by reference (주소를 복사)
            {

                int a = 40, b = 10;
                Console.WriteLine("\nCall by reference\nSwap before: a={0}, b={1}", a, b);
                Swap(ref a, ref b);
                Console.WriteLine("Swap after: a={0}, b={1}", a, b);
                static void Swap(ref int a, ref int b)
                {
                    int temp = b;
                    b = a;
                    a = temp;
                }
            }
            // Method Overloading
            {
                int a = 50, b = 10, c = 4, d = 7, e = 9;
                double f = 544.2, g = 63.2;
                Console.WriteLine("\nMethod Overloading");
                Console.WriteLine("Add({0}, {1}) = {2}", a, b, Add(a, b));
                Console.WriteLine("Add({0}, {1}) = {2:0.0#}", f, g, Add(f, g));
                Console.WriteLine("Add({0}, {1}, {2}) = {3}", c, d, e, Add(c, d, e));
            }
            // ref
            {
                int a = 40;
                Console.WriteLine("\nref\nint a = {0}", a);
                Add(ref a, 100);
                Console.WriteLine("Add(ref a, 100) => a = {0}", a);
                Add(ref a, 200);
                Console.WriteLine("Add(ref a, 200) => a = {0}", a);
                Add(ref a, 300);
                Console.WriteLine("Add(ref a, 300) => a = {0}", a);

                static void Add(ref int a, int b)
                {
                    a += b;
                }
            }
            // out
            {
                int a;
                Console.WriteLine("\nout");
                Add(out a);
                Console.WriteLine("Add(out a) => a={0}", a);
                static void Add(out int a)
                {
                    a = 100;
                }
            }
            // params
            {
                Console.WriteLine("\nparams");
                Console.WriteLine("total(20, 10, 40, 4, 7, 6, 44, 55, 2) => sum = {0}", total(20, 10, 40, 4, 7, 6, 44, 55, 2));
                Console.WriteLine("total(30, 4, 5) => sum = {0}", total(30, 4, 5));
                static int total(params int[] list)
                {
                    int sum = 0;
                    for (int i = 0; i < list.Length; i++)
                        sum += list[i];
                    return sum;
                }
            }
        }
        // Method Overloading
        static int Add(int a, int b)
        {
            return a + b;
        }
        static double Add(double a, double b)
        {
            return a + b;
        }
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
