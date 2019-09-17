using System;

namespace ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Qual a sua idade? ");
            idade=int.Parse(Console.ReadLine());
            if(idade<=3){
                Console.WriteLine("Early Childhood");
            }
            else if(idade>=10 && idade<13){
                Console.WriteLine("Everyone 10+");
            }
            else if(idade>=13 && idade<17){
                Console.WriteLine("Teen");
            }
            else if(idade>=17 && idade<18){
                Console.WriteLine("Mature 17+");
            }
            else if(idade>=18){
                Console.WriteLine("Mature 18+");
            }
            else{
                Console.WriteLine("Everyone");
            }
        }
    }
}
