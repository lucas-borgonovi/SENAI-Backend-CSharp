using System;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float sal,desp,saldo;
            Console.WriteLine("Digite seu salário: ");
            sal=float.Parse(Console.ReadLine());
            Console.WriteLine("Digite suas despesas: ");
            desp=float.Parse(Console.ReadLine());
            saldo=sal-desp;
            if(saldo>=0){
                Console.WriteLine("superávit");
            }
            else{
                Console.WriteLine("déficit");
            }
        }
    }
}
