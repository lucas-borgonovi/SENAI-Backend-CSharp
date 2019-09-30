using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome,sobrenome;
            double peso,altura;
            
            MostraInfo();
            
            Console.Write("Digite o seu nome: ");
            nome=Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            sobrenome=Console.ReadLine();
            MostraInfo(nome,sobrenome);

            Console.WriteLine("Digite sua idade: ");
            idade=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso: ");
            peso=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura: ");
            altura=double.Parse(Console.ReadLine());
            MostraInfo(idade,peso,altura);
        }
        static void MostraInfo(){
            Console.WriteLine("Servico Nacional de Aprendizagem Industrial");
        }
        static void MostraInfo(string nome,string sobrenome){
            Console.WriteLine($"{nome} {sobrenome}");
        }
        static void MostraInfo(int idade,double peso,double altura){
            Console.Write($"Idade: {idade}, Peso:{peso}, Altura: {altura}");
        }

    }
}
