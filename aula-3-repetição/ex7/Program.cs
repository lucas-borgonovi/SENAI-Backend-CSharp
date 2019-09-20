using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double s=0,p=1;
            int num;
            for(int i =1;i<=100;i++){
                Console.Write("Digite um numero: ");
                num=int.Parse(Console.ReadLine());
                if(num>0){
                    if(num%2!=0){
                    s+=i;
                }
                else if(num%3==0){
                    p=p*i;            
                }
                }
                else{
                    Console.WriteLine("Erro");
                }         
            }
            Console.WriteLine($"A soma dos números ímpares é:{s}");
            Console.WriteLine($"O produto dos múltiplos de 3 é:{p}");
        }
    }
}
