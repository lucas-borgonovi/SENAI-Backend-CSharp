using System;
using System.IO;
using Aula7_POO.Models;

namespace Aula7_POO.Controllers
{
    public class ProdutosController
    {

        ProdutosModel produto=new ProdutosModel();
        public void CadastrarProduto(){
            try
            {
                Console.WriteLine("Digite o ID do Produto: ");
                produto.IdProduto=int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite o nome do produto: ");
                produto.NomeProduto=Console.ReadLine();

                System.Console.WriteLine("Digite a descrição do Produto: ");
                produto.Descricao=Console.ReadLine();

                System.Console.WriteLine("Digite o preço do produto: ");
                produto.Preco=double.Parse(Console.ReadLine());

                
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Desculpe :( Houve um erro na aplicação");
                SalvarErros(ex);
            }
   
        }
        public void ExibirProduto(){

            System.Console.WriteLine(produto.IdProduto);
            System.Console.WriteLine(produto.NomeProduto);
            System.Console.WriteLine(produto.Preco);
        }

        private void SalvarErros(Exception ex){
            StreamWriter txt=new StreamWriter("Error_log_txt",true);

            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());
            txt.WriteLine(ex);
            txt.WriteLine();

            txt.Close();
        }
    }
}