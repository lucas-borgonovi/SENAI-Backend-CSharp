using System;

namespace Aula_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Declaramos as notas que utilizamos
            float nota1,nota2,nota3,media;
            string resultado;

            //Capturamos a primeira nota
            Console.Write("Digite sua primeira nota: ");
            nota1=float.Parse(Console.ReadLine());
            //Capturamos a segunda nota
            Console.Write("Digite sua segunda nota: ");
            nota2=float.Parse(Console.ReadLine());
            //Capturamos a tereceira nota
            Console.Write("Digite sua terceira nota: ");
            nota3=float.Parse(Console.ReadLine());
            
            media=(nota1+nota2+nota3)/3;
            //Verificamos se a media do aluno é maior ou igual a 6//
            if(media>=6){
                resultado="Aprovado";
            }
            else if( media<6 && media>=4){
                    resultado="recuperação";
                }
                else{
                    resultado="reprovado";
                }
            Console.WriteLine($"Média : {media} - Aluno está {resultado}");
            }
        }
    }
