using System;

namespace virtual__override
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.A();

            Child child = new Child();
            child.A();

            Daughter daughter = new Daughter();
            daughter.A();
        }
    }
    class Parent
    {
        public virtual void A()
        {
            Console.WriteLine("부모 클래스의 A() 메서드 호출!");
        }
    }
    class Child : Parent
    {
        public override void A()
        {
            Console.WriteLine("자식 클래스(Child)의 A() 메서드 호출!");
        }
    }
    class Daughter : Parent
    {
        public override void A()
        {
            Console.WriteLine("자식 클래스(Daughter)의 A() 메서드 호출!");
        }
    }
}
