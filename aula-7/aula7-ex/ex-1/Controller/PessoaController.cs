using System;
using System.IO;
using ex_1.Model; 

namespace ex_1.Controller
{
    public class PessoaController
    {
       PessoaModel pessoa=new PessoaModel();

       public void Receber(){
           System.Console.WriteLine("Digite seu nome: ");
           pessoa.Nome=Console.ReadLine();
           System.Console.WriteLine("Digite sua idade: ");
           pessoa.idade=int.Parse(Console.ReadLine());
           System.Console.WriteLine("Digite seu peso: ");
           pessoa.peso=double.Parse(Console.ReadLine());
           System.Console.WriteLine("Digite sua altura: ");
           pessoa.altura=double.Parse(Console.ReadLine());
       } 
       public void Mostrar(){
           System.Console.WriteLine($"Nome: {pessoa.Nome}");
           System.Console.WriteLine($"Idade: {pessoa.idade}");
           System.Console.WriteLine($"Peso: {pessoa.peso}");
           System.Console.WriteLine($"Altura: {pessoa.altura}");
       }
       public void Imc(){
           double imc=0;
           imc=pessoa.peso/Math.Pow(pessoa.altura,2);
           Console.WriteLine($"Seu IMC é: {imc}");
       }
    }
}