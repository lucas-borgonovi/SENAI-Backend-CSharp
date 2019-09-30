using System;
using aula_8.Controllers;

namespace aula_8
{
    class Program
    {
        static void Main(string[] args)
        {
            CarrosController carros=new CarrosController();
            CarrosEletricosConstroller CarroEletrico=new CarrosEletricosConstroller();

            CarroEletrico.Ligar();
           

            CarroEletrico.CarregarBateria(100);
            CarroEletrico.CarregarBateria(15);
            System.Console.WriteLine("Carga do carro: "+ CarroEletrico.StatusBateria());
        }
    }
}
