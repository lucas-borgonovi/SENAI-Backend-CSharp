using System;

namespace ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero={-5,-2,7,0};
            Console.WriteLine(Maior(numero));
        }
        static int Maior(int[] num){
            int ac=0;

        if(num[0]<=0){
            ac=num[0];
        }

        for (int i = 0; i < num.Length; i++)
        {
            if(num[i]>ac){
                ac=num[i];
            }
        }
            
        return (ac);
            
        }
    }
}
