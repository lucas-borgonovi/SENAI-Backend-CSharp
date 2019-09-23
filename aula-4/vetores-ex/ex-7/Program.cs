using System;

namespace ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet=new int[10];
            int ac=0,ind=0;
            for(int i=0;i<=9;i++){
                Console.WriteLine("Digite um valor: ");
                vet[i]=int.Parse(Console.ReadLine());
            }
            for(int i=0;i<=9;i++){
                if(vet[i]>ac){
                    ac=vet[i];
                    ind=i;
                }
            }
            Console.Write($"O maior valor é: {ac} e está no índice: {ind} e está na posição: {ind+1}");

            
        }
    }
}
