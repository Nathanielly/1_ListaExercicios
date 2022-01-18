using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio32
{
    public class Exercicio32
    {
        public void Operacao()
        {
            Console.WriteLine("Informe os números: ");
            decimal n1 = decimal.Parse(Console.ReadLine());
            decimal n2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o operador: +, -, / ou *");
            string operador = Console.ReadLine();


            decimal result = 0;

            if (operador == "+")
            {
                 result = n1 + n2;
            }
            else if (operador == "-")
            {
                 result = n1 - n2;
            }
            else if (operador == "/")
            {
                 result = n1 / n2;

                if (n1 == 0 | n2 == 0)
                {
                    Console.WriteLine("Não é possivel dividir zero.");
                }


            }
            else if (operador == "*")
            {
                 result = n1 * n2;
            }

            else
                Console.WriteLine("Operador inválido.\nTente novamente.");


            Console.WriteLine("Operação: "+ n1 + operador + n2 + "\nresultado: " + result);












        }


    }
}
