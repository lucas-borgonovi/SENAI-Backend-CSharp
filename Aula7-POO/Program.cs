using System;
using Aula7_POO.Controllers;

namespace Aula7_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosController produto1=new ProdutosController();

            produto1.CadastrarProduto();
            produto1.ExibirProduto();
        }
    }
}
