class Solution
{
    public static int[] p;
    public static void Main(string[] args)
    {
        Console.WriteLine(solution(9, new int[,] { { 1, 3 }, { 2, 3 }, { 3, 4 }, { 4, 5 }, { 4, 6 }, { 4, 7 }, { 7, 8 }, { 7, 9 } }));
    }
    public static int solution(int n, int[,] wires)
    {
        int answer = 100;
        p = new int[n + 1];
        for(int idx = 0; idx < n-1; idx++)
        {
            for (int i = 0; i < n + 1; i++) p[i] = i;
            for (int i = 0; i < wires.GetLength(0); i++)
            {
                if (idx == i) continue;
                int a = wires[i, 0], b = wires[i, 1];
                union(a, b);
            }
            int t = 0;
            for (int i = 1; i < n + 1; i++) if (find(p[i]) == 1) t++;
            answer = Math.Min(Math.Abs(n - 2 * t), answer);
        }
        return answer;
    }
    public static void union(int x, int y)
    {
        int a = find(x), b = find(y);
        if(a > b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }
        if (a != b) p[b] = a;
    }
    public static int find(int x)
    {
        return p[x] == x ? x : find(p[x]);
    }
}