using System;

namespace Auto_property_initializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Old_version t1 = new Old_version();
            New_version t2 = new New_version();
            Console.WriteLine(t1.Sample);
            Console.WriteLine(t2.Sample);
        }
    }
    class Old_version
    {
        private string sample = "old_version";
        public string Sample {
            get { return sample; }
            set { sample = value; } 
        }
    }
    class New_version
    {
        public string Sample { get; set; } = "new_version";
    }
}
