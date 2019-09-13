using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
             float pcusto,percentual,pfinal;
            Console.WriteLine("Digite o preço de custo: ");
            pcusto=float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o percentual? ");
            percentual=float.Parse(Console.ReadLine());
            pfinal=pcusto+((percentual/100)*pcusto);
            Console.WriteLine($"O preço final é: {pfinal}");
        }
    }
}
