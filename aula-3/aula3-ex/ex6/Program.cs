using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1=1,n2=0,atual=0;
            for(int i=1;i<=20;i++){
                Console.Write($"{n2},");
                atual=n1+n2;
                n1=n2;
                n2=atual;   
           }
        }
    }
}
