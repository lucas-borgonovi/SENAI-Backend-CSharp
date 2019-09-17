using System;

namespace aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // somente declaramos, sem atribuir valor
            int num1;
            //declaramos atribuindo valor
            int num2=5;
            // declaramos diversas variaveis do mesmo tipo
            int num3,num4,num5;
            // Variável do tipo decimal (real)
            float media;
            //Variável do tipo lógico(booleana)
            bool resultado=false;
            // variável do tipo texto(caracteres)
            string nomeAluno;
            //Escreve em uma linha quebrando-a
            Console.WriteLine("Bem vindos à nossa primeira aplicação!");
            //Continua escrevendo a mesma linha
            Console.Write("Digite");
            Console.Write(" seu nome: ");
            //Capturo o dado digitado pelo usuário e salvo na variável
            nomeAluno=Console.ReadLine();
            //Concatenação
            Console.WriteLine(nomeAluno + ", Agora digite sua primeira nota: ");
            num3=int.Parse(Console.ReadLine());
            // Interpolação 
            Console.WriteLine($"Sua primeira nota é {num3}");

            Console.WriteLine("Digite sua segunda nota: ");
            num4=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota: ");
            num5=int.Parse(Console.ReadLine());

            media=(num3+num4+num5)/3;

            Console.WriteLine($"Sua média é: {media}");
            










        }
    }
}
