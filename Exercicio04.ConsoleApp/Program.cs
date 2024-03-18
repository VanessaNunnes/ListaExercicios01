//Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem Inicial e
//Final do Percurso do Veículo. Deverá ser informado o Consumo de Combustível.
//consumo = (quilometragem Inicial - quilometragem Final) / consumo de combústivel
namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, informe a quilometragem inicial");
            double quilometragemInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a quilometragem final");
            double quilometragemFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe o consumo de combustível");
            double consumoCombustível = Convert.ToDouble(Console.ReadLine());

            double consumo =  (quilometragemFinal - quilometragemInicial) / consumoCombustível;
            Console.WriteLine("O consumo foi de " + consumo.ToString("N3") + "Km/l");
            Console.ReadLine();
        }
    }
}
