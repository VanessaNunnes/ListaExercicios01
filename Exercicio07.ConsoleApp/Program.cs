// Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de vendas.
// A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.
// salario total = salario base + (total de vendas * (comissao / 100)

namespace Exercicio07.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, informe o salário base");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor total das vendas");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o percentual da comissão");
            double comissao = Convert.ToDouble(Console.ReadLine());

            double salarioTotal = salarioBase + (totalVendas * (comissao / 100));

            Console.WriteLine("O salário total é de: " + salarioTotal + " R$");
            Console.ReadLine();
        }
    }
}
