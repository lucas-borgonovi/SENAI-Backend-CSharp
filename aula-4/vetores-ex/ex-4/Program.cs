using System;

namespace ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet1=new string[15];
            string[] vet2=new string[15];
            string[] vet3=new string[30];
            for(int i=0;i<=14;i++){
                Console.Write("Digite uma palavra para o vetor 1: ");
                vet1[i]=Console.ReadLine();
                Console.Write("Digite uma palavra para o vetor 2: ");
                vet2[i]=Console.ReadLine();
            }
            for(int i=0;i<=14;i++){
                vet3[i]=vet1[i];
                vet3[i+15]=vet2[i];
            }
            for(int i=0;i<=29;i++){
                Console.Write(vet3[i]);
            }
        }
    }
}
