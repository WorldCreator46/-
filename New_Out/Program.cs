using System;

namespace New_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            // 이제 변수선언을 한번에 가능
            TryParse(out int t, "123124");
            Console.WriteLine(t);
        }
        public static void TryParse(out int t, string s)
        {
            try
            {
                t = Int32.Parse(s);
                Console.WriteLine("변환 성공");
            }
            catch
            {
                t = 0;
                Console.WriteLine("변환 실패");
            }
        }
    }
}
