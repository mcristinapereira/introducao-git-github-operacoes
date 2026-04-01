using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Digite um número inteiro superior a 1: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero <= 1);

            Console.WriteLine($"\nTabuada de {numero}");
            Tabuada(numero);

            Console.Write($"\nDivisores de {numero}: ");
            Divisores(numero);

            Console.WriteLine($"\n\nO número {numero} é " + ParImpar(numero));

            Console.ReadKey();
        }

        static void Tabuada(int n)
        {
            for(int i=1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        static void Divisores(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write($"{i} ");
            }
        }

        static string ParImpar(int n)
        {
            string valor;

            if (n % 2 == 0)
                valor = "par";
            else
                valor = "ímpar";

            return valor;
        }
    }
}
