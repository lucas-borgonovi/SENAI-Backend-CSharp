using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("digite um número: ");
            num=int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++){
                Console.WriteLine($"{num}x{i}={num*i}");
            }
        }
    }
}
