using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float vreais,vdolar,cot;
            Console.WriteLine("Qual o valor em real? ");
            vreais=float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a cotação do dolar? ");
            cot= float.Parse(Console.ReadLine());
            vdolar=vreais*cot;
            Console.WriteLine($"Esse valor em dolares é: {vdolar}");
        }
    }
}
