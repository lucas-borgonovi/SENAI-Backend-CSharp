using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float sfixo,divida,resto;
            Console.Write("Salário fixo: ");
            sfixo=float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a dívida? ");
            divida=float.Parse(Console.ReadLine());
            resto=sfixo-divida;
            Console.WriteLine($"O Saldo final é: {resto}");

        }
    }
}
