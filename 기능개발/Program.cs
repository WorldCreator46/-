
public class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(", ", (solution(new int[] { 93, 30, 55 }, new int[] { 1, 30, 5 }))));
        Console.WriteLine(string.Join(", ", (solution(new int[] { 95, 90, 99, 99, 80, 99 }, new int[] { 1, 1, 1, 1, 1, 1 }))));
    }
    static public int[] solution(int[] progresses, int[] speeds)
    {
        Dictionary<int, int> pro = new Dictionary<int, int>();
        List<int> answer = new List<int>();
        for (int i = 0; i < progresses.Length; i++) pro.Add(i, progresses[i]);
        while (pro.Count > 0)
        {
            int temp = 0;
            foreach (int i in pro.Keys)
            {
                if (pro[i] >= 100)
                {
                    temp++;
                    pro.Remove(i);
                }
                else break;
            }
            if (temp > 0) answer.Add(temp);
            foreach (int i in pro.Keys) pro[i] += speeds[i];
        }
        return answer.ToArray();
    }
}