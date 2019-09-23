using System;

namespace aula_4_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] media=new double[10];
            for(int i=0;i<=9;i++){
                Console.Write("Digite uma media: ");
                media[i]=double.Parse(Console.ReadLine());
            }
            Console.WriteLine(media[3]);

            for(int i=0;i<=media.Length-1;i++){
                Console.WriteLine("Média :"+media[i]);
            }
        }
    }
}
