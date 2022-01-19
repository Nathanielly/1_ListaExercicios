using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio31
{
    public class Exercicio31
    {
        public void ordemCrescente()
        {
            int numero = 0;

            List<int> ordemCrescente = new List<int>();

            while (numero <= 2)
            {
                Console.WriteLine("Informe quais são os números: ");
                ordemCrescente.Add(int.Parse(Console.ReadLine()));
                numero++;

            }

            ordemCrescente.Sort();

            Console.WriteLine("Os números em ordem crescente são: ");

            foreach( int num in ordemCrescente)
            {
                Console.WriteLine(num);

            }







        }



    }
}
