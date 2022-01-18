using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    public class Exercicio15
    {
        public void Intervalo()
        {
            int n1;

            Console.WriteLine("Informe o número: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 >100 && n1 <200)
            {
                Console.WriteLine("O valor está no intervalo entre 100 a 200.");
            }
            
            else
            {
                Console.WriteLine("O valor não está entre o intervalo de 100 a 200.");
            }




        }

    }
}
