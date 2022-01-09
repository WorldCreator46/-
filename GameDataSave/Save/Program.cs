using System;
using System.Collections.Generic;
using System.Numerics;
using System.IO;
using Newtonsoft.Json;
namespace Save
{
    class Program
    {
        public static string[] PropertyName = { "Cash", "Stock", "Furniture", "Jewelry", "NobleMetals", "RealEstate", "Car", "Bitcoin", "Accessories", "Etc" };
        Dictionary<string, BigInteger> Property = new Dictionary<string, BigInteger>();
        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader("TestJson.json"))
            {
                string json = r.ReadToEnd();
            }
        }
        void Do()
        {
            foreach (string Name in PropertyName)
            {
                Property[Name] = BigInteger.Zero;
            }
        }
    }
}
