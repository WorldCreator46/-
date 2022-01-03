using System;
using System.Collections;
namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            // 기본은 Item + 인덱스 넘버(1 부터 시작)
            var t1 = ("a", "b", "c");
            Console.WriteLine(t1.Item1);
            // 사용자 지정도 가능
            (string A, string B, string C) t2 = ("a", "b", "c");
            Console.WriteLine(t2.A);
            // 오른쪽에서 한번에 지정도 가능
            var t3 = (A: "a", B: "b", C: "c");
            Console.WriteLine(t3.A);
            // 둘 다 사용시 충돌하여 왼쪽만 가능
            (string A, string B, string C) t4 = (One: "a", Two: "b", Three: "c");
            Console.WriteLine(t4.A);
            int[] a = new int[5] { 1, 5, 7, 9, 6 };
            // 여러개 리턴하는 것 처럼 보이지만 튜플 하나 반환 (파이썬도 이럼)
            var range = Range(a);
            Console.WriteLine($"Max: {range.Max}, Min: {range.Min}");
            // 튜플로 풀어서 받을 수도 있다.
            (int max, int min) = Range(a);
            Console.WriteLine($"Max: {max}, Min: {min}");
        }
        private static (int Max, int Min) Range(IEnumerable numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (int n in numbers)
            {
                min = (n < min) ? n : min;
                max = (n > max) ? n : max;
            }
            return (max, min);
        }
    }
}
