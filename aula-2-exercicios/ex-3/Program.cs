using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {   
            int num1,num2;
            Console.WriteLine("Digite o primeiro número: ");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2=int.Parse(Console.ReadLine());
            if(num1>num2){
                Console.WriteLine(num1);
            }
            else{
                Console.WriteLine(num2);
            }
        }
    }
}
