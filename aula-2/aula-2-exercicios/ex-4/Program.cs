using System;

namespace ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float preco;
            Console.WriteLine("Digite o preço: ");
            preco=float.Parse(Console.ReadLine());
            if((preco>=100) && (preco<=1000)){
                preco=preco*0.85f;
            }
            Console.WriteLine(preco);

        }
    }
}
