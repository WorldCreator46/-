using System;
using System.Collections.Generic;
public class Solution
{
    static public void Main()
    {
        Console.WriteLine(string.Join(", ", solution(new string[] { "sun", "bed", "car" }, 1)));
        Console.WriteLine(string.Join(", ", solution(new string[] { "abce", "abcd", "cdx" }, 2)));
    }
    static public string[] solution(string[] strings, int n)
    {
        return strings.OrderBy(word => word).ToArray().OrderBy(word => word[n]).ToArray();
    }
}