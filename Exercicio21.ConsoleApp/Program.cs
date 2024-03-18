//Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B.
//Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

namespace Exercicio21.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor A");
            int valorA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor B");
            int valorB = Convert.ToInt32(Console.ReadLine());

            int valorC = 0;

            if (valorA == valorB)
            {
                valorC = valorA + valorB;
                Console.WriteLine("Os valores são iguais, a soma deles é de: " + valorC);
            }
            else
            {
                valorC = valorA * valorB;
                Console.WriteLine("Os valores são diferentes, a multiplicação deles é de: " + valorC);
            }
            Console.ReadLine();
        }
    }
}
