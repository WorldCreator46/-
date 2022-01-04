using System;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStars(null);
        }
        public static void PrintStars(object o)
        {
            /*
                if (o is null) return; // o 가 상수 패턴 "null" 이냐?
                if (!(o is int i)) return; // o 가 타입 패턴 "int i"가 아니냐?
            */
            // o 가 타입 패턴 "int i" 거나 타입 패턴 "string s" 이면서 int로 형변환이 가능하냐?
            if (o is int i || o is string s && int.TryParse(s, out i))
                Console.WriteLine(new string('*', i));
        }
    }
}
