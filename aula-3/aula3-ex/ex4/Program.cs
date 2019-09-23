using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1,num,ac=0,n=0;
            do{
                Console.Write("Digite um número: ");
                num=int.Parse(Console.ReadLine());
                if(num<0){
                    ac=ac+(num*(-1));
                    n=n+1;
                }
                else{
                    Console.WriteLine(num);
                }
                i++;
            }while(i<=20);
            Console.WriteLine($"O valor da média é:{ac/n}");
        }
    }
}
