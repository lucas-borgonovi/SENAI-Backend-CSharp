using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float sfixo,vfinal,nvendas;
            Console.WriteLine("Qual é o salário fixo: ");
            sfixo=float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o número total de vendas: ");
            nvendas=float.Parse(Console.ReadLine());
            vfinal=sfixo+(nvendas*1.05f);
            Console.WriteLine($"O valor final é: {vfinal}");
        }
    }
}
