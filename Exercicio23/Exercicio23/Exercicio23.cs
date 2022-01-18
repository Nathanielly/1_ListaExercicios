using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio23
{
    public class Exercicio23
    {
        public void Numeros()
        {
            Console.WriteLine("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 80)
            {
                Console.WriteLine("O número informado é maior que 80.");
            }
            else if (numero < 25)
            {
                Console.WriteLine("O número informado é menor que 25.");
            }
            else if (numero == 40)
            {
                Console.WriteLine("O número informado é igual a 40.");

            }

            else Console.WriteLine("O numero informado é " + numero);
        }

    }
}
