using System;

namespace Null_conditional_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Truncate("ABCDEFGHI", 25));
            // ?.  | 멤버에 접근하기 전 체크       
            // ?[] | 인덱스 작업을 수행하기 전 체크 
            // 왼쪽 피연산자의 값을 검사 후 null이 아닌 경우에만 연산자 오른쪽의 표현식 실행.
            // null이라면 null을 반환
        }
        public static string Truncate(string value, int length)
        {
            /*
                string result = value;
                if (value != null)
                {
                    result = value.Substring(0, Math.Min(value.Length, length));
                }
                return result;
            */
            return value?.Substring(0, Math.Min(value.Length, length));
        }
    }
}
