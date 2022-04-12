using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] a = new int[7] { 1, 5, 2, 6, 3, 7, 4 };
            int[,] c = new int[3,3] { { 2, 5, 3}, { 4, 4, 1}, { 1, 7, 3} };
            Console.WriteLine(s.solution(a, c)[0]);
            Console.WriteLine(s.solution(a, c)[1]);
            Console.WriteLine(s.solution(a, c)[2]);
        }
    }
    public class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            List<int> answer = new List<int>();
            List<int> Temp = new List<int>();
            List<int> A = new List<int>(array);
            int i, j, k;
            for (int idx = 0; idx < commands.GetLength(0); idx++)
            {
                i = commands[idx, 0] - 1;
                j = (commands[idx, 1] - commands[idx, 0])+1;
                k = commands[idx, 2] - 1;
                Temp = A.GetRange(i, j);
                Temp.Sort();
                answer.Add(Temp[k]);
            }
            return answer.ToArray();
        }
    }
}
