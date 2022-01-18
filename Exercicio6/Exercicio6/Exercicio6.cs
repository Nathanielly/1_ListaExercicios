using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public class Exercicio6
    {
        public void TrocaVariaveis()
        {
            decimal a, b;

            Console.WriteLine("Informe os valores das variaveis: ");
            a = Convert.ToDecimal(Console.ReadLine());
            b = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Variaveis antes da troca: a = " + a + " e b = " + b);
            Console.WriteLine("Variaveis após a troca: a = " + b + " e b = " + a);


        }
        public void TrocaValores()
        {
            int a = 15;
            int b = 25;
            int c;

            ///preserva o valor de a
            c = a
            a = b;
            b = c;

        }


            

    }
}
