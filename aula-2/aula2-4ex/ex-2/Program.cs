using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            float peso,peso_plan=0;
            string nome_plan="Terra";
            Console.WriteLine("Digite seu peso: ");
            peso=float.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número:  ");
            num=int.Parse(Console.ReadLine());
            switch(num){
                case 1:
                nome_plan="Mercúrio";
                peso_plan=(peso/10)*0.37f;
                break;
                case 2:
                nome_plan="Vênus";
                peso_plan=(peso/10)*0.88f;
                break;
                case 3:
                nome_plan="Marte";
                peso_plan=(peso/10)*0.38f;
                break;
                case 4:
                nome_plan="Júpiter";
                peso_plan=(peso/10)*2.64f;
                break;
                case 5:
                nome_plan="Saturno";
                peso_plan=(peso/10)*1.15f;
                break;
                case 6:
                nome_plan="Urano";
                peso_plan=(peso/10)*1.17f;
                break;
                default:
                peso_plan=peso;
                break;
            }
            Console.WriteLine($"O seu peso no planeta {nome_plan} é: {peso_plan}");

           
        }
    }
}
