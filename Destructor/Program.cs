using System;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new MyClass("A");
            MyClass m2 = new MyClass("B");
            MyClass m3 = new MyClass("C");
        }
        // 소멸자는 작동이 안되지만 나중에 알아봐야겠다.
    }
    class MyClass
    {
        private string name;
        public MyClass(string name)
        {
            this.name = name;
            Console.WriteLine($"{name} 객체 생성!");
        }
        ~MyClass()
        {
            Console.WriteLine($"{name} 객체 소멸!");
        }
    }
}
