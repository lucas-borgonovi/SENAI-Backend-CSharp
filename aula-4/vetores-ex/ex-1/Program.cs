using System;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num= new int[10];
            for(int i=0;i<=9;i++){
                Console.Write("Digite um número: ");
                num[i]=int.Parse(Console.ReadLine());
            }
            for(int i=0;i<=9;i++){
                Console.WriteLine(num[i]);
            }
            Console.WriteLine(num[9]*5);
        }
    }
}
