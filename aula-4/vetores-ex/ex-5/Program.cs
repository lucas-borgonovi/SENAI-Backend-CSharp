using System;

namespace ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] vet=new int[10];
           for(int i=0;i<=9;i++){
               vet[i]=(i*2);
           }
           for(int i=0;i<=9;i++){
               Console.WriteLine(vet[i]);
           }
        }
    }
}
