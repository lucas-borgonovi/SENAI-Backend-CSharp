using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,i=1;
            double ac=0,sal;
            Console.Write("Digite o número de funcionários: ");
            x=int.Parse(Console.ReadLine());
            while(i<=x){
                Console.Write($"Digite o salário do {i}º funcionário: ");
                sal=float.Parse(Console.ReadLine());
                ac+=sal;
                i++;
            }
            Console.WriteLine(ac/x);
        }
    }
}
