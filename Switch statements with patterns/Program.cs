using System;

namespace Switch_statements_with_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rectangle((0,0), (2,3));
            switch (r)
            {
                // 이게 직사각형보다 나중에 검사하면 정사각형이지만 직사각형이라고 출력됨
                case Rectangle when r.Width == r.Height:
                    Console.WriteLine($"{r.Width} x {r.Height} 정사각형");
                    break;
                case Rectangle:
                    Console.WriteLine($"{r.Width} x {r.Height} 직사각형");
                    break;
                default:
                    Console.WriteLine("<알 수 없는 모양>");
                    break;
                // 얘가 default보다 먼저 처리됨 default는 항상 마지막
                // 어차피 암시적 null 검사해서 도달하지 못함
                case null:
                    throw new ArgumentNullException(nameof(r));
            }
        }
    }
    public class Rectangle
    {
        private (int x, int y) f;
        private (int x, int y) l;
        public Rectangle((int x, int y) f, (int x, int y) l)
        {
            this.f = f;
            this.l = l;
        }
        public int Width
        {
            get { return Math.Abs(f.x - l.x); }
        }
        public int Height
        {
            get { return Math.Abs(f.y - l.y); }
        }
        public int Area
        {
            get { return Width * Height; }
        }
        public int Circumference
        {
            get { return (Width + Height) * 2; }
        }
    }
}
