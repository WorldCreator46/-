using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 생성자 예제 1
            {
                Console.WriteLine("생성자 예제 1");
                Car car = new Car(325, "람보르기니 가야르도");
                car.ShowCarInformation();
                car.speedUp(50);
                car.speedUp(40);
                car.speedUp(210);
                car.speedUp(30);
            }
            // 생성자 오버로딩
            {
                Console.WriteLine("\n생성자 오버로딩");
                MyClass m1 = new MyClass();
                MyClass m2 = new MyClass(10);
                MyClass m3 = new MyClass(22.5);
            }
        }
    }
    class Car
    {
        private int maxSpeed, speed = 0;
        private string model;
        public Car(int maxSpeed, string model)
        {
            this.maxSpeed = maxSpeed;
            this.model = model;
        }
        public void ShowCarInformation()
        {
            Console.WriteLine($"{model}의 현재 속도: {speed}km/h, 최대 속도: {maxSpeed}km/h");
        }
        public void speedUp(int increment)
        {
            if (speed + increment > maxSpeed)
                Console.WriteLine($"최대 속도 {maxSpeed}km/h를 넘길 수 없습니다.");
            else
            {
                speed += increment;
                ShowSpeed();
            }
        }
        public void speedDown(int decrement)
        {
            if (speed - decrement < 0)
                Console.WriteLine($"속도는 0 아래로 떨어질 수 없습니다.");
            else
            {
                speed -= decrement;
                ShowSpeed();
            }
        }
        public void ShowSpeed()
        {
            Console.WriteLine($"{model}의 현재 속도는 {speed}km/h입니다.");
        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("매개변수가 없는 디폴트 생성자");
        }
        public MyClass(int i)
        {
            Console.WriteLine($"정수형 매개변수 {i}");
        }
        public MyClass(double d)
        {
            Console.WriteLine($"실수형 매개변수 {d}");
        }
    }
}
