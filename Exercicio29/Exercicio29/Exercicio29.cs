using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio29
{
    public class Exercicio29
    {
        public void Mes()
        {
            Console.WriteLine("Informe o número do mês: ");
            int numeroMes = int.Parse(Console.ReadLine());

            if (numeroMes == 1)
            {
                Console.WriteLine("Janeiro");

            }

            else if (numeroMes == 2)
            {
                Console.WriteLine("Fevereiro");

            }
            else if (numeroMes == 3)
            {
                Console.WriteLine("Março");

            }
            else if (numeroMes == 4)
            {
                Console.WriteLine("Abril");

            }
            else if (numeroMes == 5)
            {
                Console.WriteLine("Maio");

            }
            else if (numeroMes == 6)
            {
                Console.WriteLine("Junho");

            }
            else if (numeroMes == 7)
            {
                Console.WriteLine("Julho");

            }
            else if (numeroMes == 8)
            {
                Console.WriteLine("Agosto");

            }
            else if (numeroMes == 9)
            {
                Console.WriteLine("Setembro");

            }
            else if (numeroMes == 10)
            {
                Console.WriteLine("Outubro");

            }
            else if (numeroMes == 11)
            {
                Console.WriteLine("Novembro");

            }
            else if (numeroMes == 12)
            {
                Console.WriteLine("Dezembro");

            }
            else
                Console.WriteLine("Mês inválido.\nTente novamente.");
        }
        




    }
}
