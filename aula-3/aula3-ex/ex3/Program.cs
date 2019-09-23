using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont=1,n;
            Console.WriteLine("Digite um número: ");
            n=int.Parse(Console.ReadLine());
            while(cont<=n){
                if(cont%5==0){
                    Console.WriteLine(cont);
                }
                cont++;
            }
            
        }
    }
}
