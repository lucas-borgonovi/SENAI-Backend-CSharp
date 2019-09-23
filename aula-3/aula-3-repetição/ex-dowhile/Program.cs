using System;

namespace ex_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont=1,num,ac=0;
             do{
                Console.WriteLine("Digite um número: ");
                num=int.Parse(Console.ReadLine());
                if(num%3==0){
                    ac++;
                }
                cont++;
            }while(cont<=20);
            Console.Write(ac); 
        }
    }
}
