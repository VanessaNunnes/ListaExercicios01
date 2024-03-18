// Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui. Considere sempre anos completos,
// e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.

namespace Exercicio14.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe quantos anos de idade você tem");
            int idade = Convert.ToInt32(Console.ReadLine());

            int dias_de_vida = idade * 365;

            Console.WriteLine(nome + ", você ja viveu " + dias_de_vida + " dias");
            Console.ReadLine();
        }
    }
}
