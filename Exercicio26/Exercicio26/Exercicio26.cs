using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio26
{
    public class Exercicio26
    {
        public void PorExtenso()
        {
            Console.WriteLine("Informe um numero de 1 a 5.");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("Número informado: um");

            }
           else if (numero == 2)
            {
                Console.WriteLine("Número informado: dois");

            }
            else if (numero == 3)
            {
                Console.WriteLine("Número informado: três");

            }
            else if (numero == 4)
            {
                Console.WriteLine("Número informado: quatro");

            }
            else if (numero == 5)
            {
                Console.WriteLine("Número informado: cinco");

            }

            else
                Console.WriteLine("Número inválido\nTente novamente.");




        }



    }
}
