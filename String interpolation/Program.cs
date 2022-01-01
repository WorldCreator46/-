using System;

namespace String_interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // 파이썬의 f스트링과 거의 같음
            string name = "이름";
            var date = DateTime.Now;
            Console.WriteLine("안녕, {0}! 오늘은 {1}, {2:HH:mm}이야.", name, date.DayOfWeek, date);
            Console.WriteLine($"안녕, {name}! 오늘은 {date.DayOfWeek}, {date:HH:mm}이야.");
            // 둘다 같은 결과를 내지만 아랫쪽이 더 직관적이다.
            const int F = 20;
            Console.WriteLine($"{Math.PI, F} 원주율의 기본형식");
            Console.WriteLine($"{Math.PI, F:F3} 원주율을 소수점 3자리까지");
            bool  b = true;
            Console.WriteLine($"{(b ? "참" : "거짓")} 조건부 삼항 연산자(?:)도 소괄호로 묶어서 사용 가능!");
            Console.WriteLine($"{{}} 중괄호는 이렇게 두번 겹쳐서");
        }
    }
}
