using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio25
{
    public class Exercicio25
    {
        public void Numeros()
        {
            int n1, n2;

            Console.WriteLine("Informe dois números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());


            if (n1 != n2)
            {
                Console.WriteLine("Os números são diferentes.");
            }

           else if (n1 == n2)
            {
                Console.WriteLine("Os números são iguais.");
            }



        }



    }
}
