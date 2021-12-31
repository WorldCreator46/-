using System;

namespace ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Child cd = new Child(50);
            cd.DisplayValue();
        }
    }
    // sealed class Parent {}
    // 상속을 못하게 하는 키워드인 sealed
    class Parent
    {
        public int num;
        public Parent()
        {
            Console.WriteLine("부모 클래스의 생성자가 호출되었습니다.");
        }
    }
    class Child : Parent
    {
        public int num; // 자식 클래스에도 부모클래스와 같은 이름의 변수가 있다면.
        public Child(int num)
        {
            //this.num = num;
            base.num = num; // base로 접근 가능
            Console.WriteLine("자식 클래스의 생성자가 호출되었습니다.");
        }
        public void DisplayValue()
        {
            //Console.WriteLine($"num의 값은 {num} 입니다.");
            Console.WriteLine($"num의 값은 {base.num} 입니다.");
        }
    }
}
