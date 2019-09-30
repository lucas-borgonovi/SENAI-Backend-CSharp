using System;
using ex_1.Controller;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
           PessoaController pessoa1=new PessoaController();

           pessoa1.Receber();
           pessoa1.Mostrar();
           pessoa1.Imc();

        }
    }
}
