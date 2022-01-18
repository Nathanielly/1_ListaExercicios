using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio24
{
    public class Exercicio24
    {

        public void Numeros()
        {

            Console.WriteLine("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O numero " + numero + " é positivo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("O numero " + numero + " é igual a zero");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O numero " + numero + " é negativo");
            }


        }


    }
}
