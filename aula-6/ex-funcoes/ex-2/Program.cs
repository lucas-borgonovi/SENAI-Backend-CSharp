using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Data();
        }
        static void Data(){
            Console.WriteLine(DateTime.Now.DayOfWeek.ToString());
        }
    }
}
