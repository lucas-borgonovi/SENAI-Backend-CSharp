using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            float vtotal;
            int pessoas;
            Console.WriteLine("Quantos passageiros? ");
            pessoas=int.Parse(Console.ReadLine());
            vtotal=pessoas*4.30f;
            Console.WriteLine($"O valor total arrecadado é: {vtotal}");
        }
    }
}
