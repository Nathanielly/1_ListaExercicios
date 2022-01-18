using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    public class Exercicio13
    {

        public void NumeroMaior()
        {
            double n1;

            Console.WriteLine("Informe o número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            if (n1 > 10)
            {
                Console.WriteLine("O número é " + n1);

            }

        }

    }
}
