using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Animal animal = dog; // 업캐스팅
            Dog sameDog = (Dog)animal; // 다운캐스팅

            // Animal animal = new Animal();
            // Dog dog = (Dog)animal;
            // InvalidCastException 예외 발생
        }
    }
    class Animal { }
    class Dog : Animal { }
}
