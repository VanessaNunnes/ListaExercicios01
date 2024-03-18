//Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

namespace Exercicio18.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor 1");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor 2");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor 3");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            if (valor1 >= valor2 && valor1 >= valor3)
            {
                Console.WriteLine(valor1);

                if (valor2 >= valor3)
                {
                    Console.WriteLine(valor2);
                    Console.WriteLine(valor3);
                }
                else
                {
                    Console.WriteLine(valor3);
                    Console.WriteLine(valor2);
                }
            }
            else if (valor2 >= valor1 &&  valor2 >= valor3)
            {
                Console.WriteLine(valor2);

                if (valor1 >= valor3)
                {
                    Console.WriteLine(valor1);
                    Console.WriteLine(valor3);
                }
                else
                {
                    Console.WriteLine(valor3);
                    Console.WriteLine(valor1);
                }
            }

            else if (valor3 >= valor1 && valor3 >= valor2)
            {
                Console.WriteLine(valor3);

                if (valor1 >= valor2)
                {
                    Console.WriteLine(valor1);
                    Console.WriteLine(valor2);
                }
                else
                {
                    Console.WriteLine(valor2);
                    Console.WriteLine(valor1);
                }
            }
            Console.ReadLine();
        }
    }
}
