using System;

namespace Set__Get
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            Console.WriteLine($"mc.Name : {mc.Name}");
            mc.Name = "Kelley";
            Console.WriteLine($"mc.Name : {mc.Name}");
        }
    }
    public class MyClass
    {
        private string name = "John";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                // 조건을 걸 수 있음
                if (value.Length < 5)
                    name = value;
            }
        }
    }
}
