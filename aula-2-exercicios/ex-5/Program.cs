using System;

namespace ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;
            Console.Write("Digite o primeiro numero: ");
            num1=int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            num2=int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro numero: ");
            num3=int.Parse(Console.ReadLine());
            if(num1> num2 && num3<num2){
                Console.WriteLine(num1);
            }
            else if(num2>num3){
                Console.WriteLine(num2);
            }
            else{
                Console.WriteLine(num3);
            }
            
        }
    }
}
