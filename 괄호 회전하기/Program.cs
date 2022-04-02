using System;
using System.Text;

namespace 괄호_회전하기
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution("[](){}"));
        }
    }
    public class Solution
    {
        public int solution(string s)
        {
            int answer = 0;
            for (int i = 0; i < s.Length; i++)
            {
                StringBuilder braket = new StringBuilder(s);
                for(int j = 0; j < i; j++)
                {
                    char temp = braket.ToString()[0];
                    braket.Remove(0, 1);
                    braket.Append(temp);
                }
                while (braket.ToString().Contains("()") || braket.ToString().Contains("{}") || braket.ToString().Contains("[]"))
                {
                    braket.Replace("()", "");
                    braket.Replace("{}", "");
                    braket.Replace("[]", "");
                }
                if (braket.ToString() == "")
                {
                    answer++;
                }
            }
            return answer;
        }
    }
}
