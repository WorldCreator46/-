using System;

namespace Expression_bodied_members
{
    class Program
    {
        static void Main(string[] args)
        {
            test1 t1 = new test1("f", "l");
            test2 t2 = new test2("f l");
            t1.DisplayName();
            Console.WriteLine(t2.Name);
        }
    }
    public class test1
    {
        public test1(string f, string l)
        {
            fname = f;
            lname = l;
        }
        public string fname;
        public string lname;
        // =>를 통해 읽기전용 속성이나 메서드를 간단하게 정의할 수 있다.({} 제거)
        public override string ToString() => $"{fname} {lname}".Trim();
        public void DisplayName() => Console.WriteLine(ToString());
    }
    public class test2
    {
        private string locationName;
        public test2(string name)
        {
            locationName = name;
        }
        // PropertyType PropertyName => expression;
        public string Name => locationName;
    }

}
