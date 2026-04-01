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

            Console.ReadKey();
        }

        static void Tabuada(int n)
        {
            for(int i=1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
