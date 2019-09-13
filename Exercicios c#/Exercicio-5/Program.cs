using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float sfixo,nvendas,sfinal;
            string nome;
            Console.WriteLine("Qual o seu nome? ");
            nome=Console.ReadLine();
            Console.WriteLine("Qual o seu salário fixo? ");
            sfixo=float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o total de vendas? ");
            nvendas=float.Parse(Console.ReadLine());
            sfinal=sfixo+(nvendas*1.1f);
            Console.WriteLine($"{nome} posui um salario fixo de {sfixo} e um salário total de {sfinal}");

        }
    }
}
