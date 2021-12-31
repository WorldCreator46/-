using System;

namespace New
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.A();
            Console.WriteLine($"x : {parent.x}");

            Child child = new Child();
            child.A();
            Console.WriteLine($"x : {child.x}");
        }
    }
    class Parent
    {
        public int x = 100;
        public void A()
        {
            Console.WriteLine("부모 클래스의 A() 메서드 호출!");
        }
    }
    class Child : Parent
    {
        public new int x = 200;
        public new void A()
        {
            Console.WriteLine("자식 클래스(Child)의 A() 메서드 호출!");
        }
    }
}
