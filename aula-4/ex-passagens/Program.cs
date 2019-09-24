using System;

namespace ex_passagens
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Ok = true;
            int Saida_Cadastro = 0;
            int Entrada;
            string Saida;
            string[] Nome = new string[5];
            string[] Origem = new string[5];
            string[] Destino = new string[5];
            string[] Data = new string[5];
            DateTime[] Data_Ida = new DateTime[5];
            DateTime[] Data_Volta = new DateTime[5];
            int Quantidade_De_Passagens_Cadastrada = 0;

            while(Ok) {
                Console.WriteLine("========= Bem Vindo =========");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\tOpções do Menu\n ( 1 - Cadastrar Passagem ) / ( 2 - Listar Passanges ) / ( 0 -  Sair )");
                Entrada = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                switch(Entrada) {
                    case 0:
                        Ok = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nSaindo do Menu......\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    break;    
                    case 1:
                        while(Saida_Cadastro <= 4 ) {
                            Console.WriteLine("====== Cadastrar Passagem ======");
                            
                            if (string.IsNullOrEmpty(Nome[Saida_Cadastro])) {
                                Console.Write("Informe o nome do passageiro: ");
                                Nome[Saida_Cadastro] = Console.ReadLine();

                                Console.Write("\nInforme a origem: ");
                                Origem[Saida_Cadastro] = Console.ReadLine();

                                Console.Write("\nInforme o destino: ");
                                Destino[Saida_Cadastro] = Console.ReadLine();

                                Console.Write("\nInforme a data do voo: ");
                                Data[Saida_Cadastro] = Console.ReadLine();
                            
                                Quantidade_De_Passagens_Cadastrada++;

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nPassageiro Cadastrado Com Sucesso\n");
                                Console.ForegroundColor = ConsoleColor.White;

                            } else {
                                int Cont = 0;
                                for(int i = 0; i < Nome.Length; i++) {
                                    if(!string.IsNullOrEmpty(Nome[i])) {
                                        Cont++;
                                    }
                                }

                                Console.Write("Informe o nome do passageiro: ");
                                Nome[Cont] = Console.ReadLine();

                                Console.Write("\nInforme a origem: ");
                                Origem[Cont] = Console.ReadLine();

                                Console.Write("\nInforme o destino: ");
                                Destino[Cont] = Console.ReadLine();

                                Console.Write("\nInforme a data do voo: ");
                                Data[Cont] = Console.ReadLine();
                            
                                Quantidade_De_Passagens_Cadastrada++;

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nPassageiro Cadastrado Com Sucesso\n");
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            
                            Console.WriteLine("Deseja Cadastrar uma nova passagem? ( S / N )");
                            Saida =Console.ReadLine();

                            if(Saida == "n" || Saida == "N") {
                               break;
                            } 

                            Saida_Cadastro++;
                        }
                    break;    
                    case 2:
                        if(!string.IsNullOrEmpty(Nome[0])) {
                            Console.WriteLine("===== Lista de Passagens ======");
                            for(int i = 0; i < Quantidade_De_Passagens_Cadastrada; i++) {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"\nNome: {Nome[i]} \nOrigem: {Origem[i]} \nDestino: {Destino[i]} \nData do Voo: {Data[i]}\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        } else {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nNão existem passagens cadastradas!!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    break;
                    default: 
                        Console.WriteLine("Opção Inválida");
                        break;    
                }
            }
        }
    }
}
        
    

