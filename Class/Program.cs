using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dog
            {
                Dog dog = new Dog();
                dog.name = "칸";
                dog.gender = "남";
                dog.ownernames = "철수";
                dog.Brak();
                Console.WriteLine($"개의 이름: {dog.name}, 개의 성별: {dog.gender}, 개의 주인이름: {dog.ownernames}");
            }
        }
    }
    class Dog
    {
        public string name, gender, ownernames;
        public void Brak()
        {
            Console.WriteLine($"{name} : 멍멍!");
        }
    }
}
