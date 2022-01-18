using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            decimal n1, n2;

            Console.WriteLine("Digite os valores a serem somados: ");
            n1 = Convert.ToDecimal(Console.ReadLine());
            n2 = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

      
            Console.WriteLine("O total da soma é = " + (n1 + n2) );


        }

    }
}
