using System;
using System.Collections.Generic; // Dictionary 사용

namespace IndexInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 구버전에 비해 인덱서 구문이 키와 값을 확실하게 구별해주어 코드 파악이 쉬워짐.
            Dictionary<int, string> old_version = new Dictionary<int, string>
            {
                { 123, "1"}, { 456, "2"}, { 789, "3"}
            };
            Dictionary<int, string> new_version = new Dictionary<int, string>
            {
                [123] = "1", [456] = "2", [789] = "3"
            };
        }
    }
}
