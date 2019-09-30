using aula_8.Models;

namespace aula_8.Controllers
{
    public class CarrosEletricosConstroller:CarrosController
    {
        //Declarando objeto CarroEletricoModel
        CarroEletricoModel carroEletrico=new CarroEletricoModel();
        //Declarando objeto MotorModel
        MotorModel motor=new MotorModel();

        public void CarregarBateria(float carga){
            if(carroEletrico.Bateria<100){
                carroEletrico.Bateria+=carga;
            }else{
                System.Console.WriteLine("A bateria do carro já está completa! Pode viajar!");
            }
        }
        public float StatusBateria()
        {
            return carroEletrico.Bateria;
        }
    }
}