using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float preco;
            Console.WriteLine("Qual o preço? ");
            preco=float.Parse(Console.ReadLine());
            if(preco>100){
                preco=preco-25;
            }
            Console.WriteLine(preco);
        }
    }
}
