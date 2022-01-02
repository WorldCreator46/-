using System;

namespace nameofOperator
{
    class Program
    {
        private static DateTime Today = DateTime.Now;
        public string Name { get; set; }
        static void Main(string[] args)
        {
        // nameof 연산자는 변수나 자료형, 멤버의 이름에 해당하는 문자열을 가져온다.
        // 매개변수의 유효성을 검사하거나, PropertyChanged 이벤트를 처리하거나,
        // 로깅에 사용하거나, 열거자 이름을 가져오는 등 생각보다 다양한 곳에서 유용하게 사용할 수 있다. 

            var localTime = DateTime.Now.ToLocalTime();

            Console.WriteLine(nameof(localTime)); // "localTime"
            Console.WriteLine(nameof(args)); // "args"
            Console.WriteLine(nameof(System.IO)); // "IO"
            Console.WriteLine(nameof(Main)); // "Main"
            Console.WriteLine(nameof(Program)); // "Program"
            Console.WriteLine(nameof(Program.Today)); // "Today"
            Console.WriteLine(nameof(Program.Name)); // "Name"
        }
    }
}
