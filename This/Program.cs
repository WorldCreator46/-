using System;

namespace This
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(50);
            a.Show();
        }
    }
    class A
    {
        private int num;
        public A(int num)
        {
            this.num = num;
        }
        public void Show()
        {
            Console.WriteLine("num: " + this.num);
        }
    }
}
