using System;

namespace ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero={0,1,9,8};
            Console.WriteLine(SomaVet(numero));
        }
        static int SomaVet(int[] num){
            int soma=0;
            for (int i = 0; i < num.Length; i++)
            {
                soma+=num[i];
            }
            return(soma);
        }
    }
}
