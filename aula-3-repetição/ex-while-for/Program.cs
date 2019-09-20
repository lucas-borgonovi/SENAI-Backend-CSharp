using System;

namespace aula_3
{
    class Program
    {
        static void Main(string[] args)
        {
             //LAÇO CONTADO-FOR-INCREMENTO(+)
            for(int cont1=1;cont<=100;cont++){
                
                // Verificamos se o número é diferente de par 
                if(cont1%2!=0){
                    Console.WriteLine("FOR 0-"+cont1);
                }
            }
            //LAÇO CONTADO-FOR-DECREMENTO(-)
            for(int cont2=100;cont>=0;cont--){
                
                // Verificamos se o número é diferente de par 
                if(cont2%2!=0){
                    Console.WriteLine("FOR 100-0-"+cont2);

                }
            } 
            //LAÇO CONDICIONAL-WHILE
            
             double nota=0,acumuladora=0;
            int cont3=0;
            string sair="";
            while(sair !="sim"){
                Console.WriteLine("Digite a nota de um aluno: ");
                nota=double.Parse(Console.ReadLine());
                    acumuladora+=nota;
                    cont3++;
                Console.WriteLine("Deseja sair da aplicação? sim/não");
                sair=Console.ReadLine().ToLower();
            }
            Console.WriteLine("Média das notas: "+(acumuladora/cont3));
        }
    }
}
