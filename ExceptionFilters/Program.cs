using System;

namespace ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력 : ");
            string Temp = Console.ReadLine().Trim();
            int t;
            try
            {
                t = Convert.ToInt32(Temp);
                Console.WriteLine("int형 : "+t);
            }
            catch (Exception ex) when(Temp.Length > 1)// catch에 조건 가능
            {
                Console.WriteLine("1글자 이상 입력");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("string형 : "+Temp);
            }
        }
    }
}
