using System;

namespace ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet1=new int[10];
            int[] vet2=new int[10];
            int[] vet3=new int[10];

            for(int i=0;i<=9;i++){
                Console.WriteLine("Digite um número para o vetor 1: ");
                vet1[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um número para o vetor 2: ");
                vet2[i]=int.Parse(Console.ReadLine());
            }
            for(int i=0;i<=9;i++){
                vet3[i]=vet1[i]+vet2[i];
                Console.WriteLine(vet3[i]);
            }
            
            
        }
    }
}
