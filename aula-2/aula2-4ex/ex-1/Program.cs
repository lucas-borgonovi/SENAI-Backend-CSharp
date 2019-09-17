using System;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pedido;
            string resposta;
            Console.WriteLine("Digite o número do seu pedido: ");
            pedido=int.Parse(Console.ReadLine());

            switch(pedido){
                case 1:
                resposta="Hamburguer";
                break;
                case 2:
                resposta="Cheese Salada";
                break;
                case 3:
                resposta="Cheese burguer";
                break;
                case 4:
                resposta="Cheese bacon";
                break;
                default:
                resposta="Opção inválida";
                break;
                
            }
            Console.Write(resposta);
        }
    }
}
