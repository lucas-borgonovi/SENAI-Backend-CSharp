using System;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor=0,porcentagem=0;

            Console.WriteLine("Digite o valor: ");
            valor=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem de desconto: ");
            porcentagem=double.Parse(Console.ReadLine());
            Console.WriteLine(Desconto(valor,porcentagem));
        }
        static double Desconto(double valor,double porcentagem){   
            return((valor-valor*(porcentagem/100)));
        }
    }   
}
