using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome=new string[3];
            string[] cor=new string[3];
            double[] preco=new double[3];
            string[] tamanho=new string[3];

            for(int i=0;i<=2;i++){
                Console.WriteLine("Digite o nome do produto: ");
                nome[i]=Console.ReadLine();
                Console.WriteLine("Digite a cor do produto: ");
                cor[i]=Console.ReadLine();
                Console.WriteLine("Digite o preço do produto: ");
                preco[i]=double.Parse(Console.ReadLine());
                Console.WriteLine("Digite tamanho do produto: ");
                tamanho[i]=Console.ReadLine();
            }

            Console.WriteLine("--------------------");
            for(int i=0;i<=2;i++){
                Console.WriteLine($"Nome: {nome[i]}");
                Console.WriteLine($"Cor: {cor[i]}");
                Console.WriteLine($"Preço: {preco[i]}");
                Console.WriteLine($"Tamanho: {tamanho[i]}");
                Console.WriteLine();
                Console.WriteLine("----------------------");
                Console.WriteLine();
            }



        }
    }
}
