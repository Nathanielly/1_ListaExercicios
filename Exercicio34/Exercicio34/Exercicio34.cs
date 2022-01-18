using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio34
{
    public class Exercicio34
    {

        public void HoraAula()
        {
            Console.WriteLine("Informe seu nível: 1, 2 ou 3.");
            int nivel = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas/aula: ");
            decimal horas = decimal.Parse(Console.ReadLine());


            CalculoSalario(nivel, horas);
            

        }

        public void CalculoSalario(int nivel, decimal horas)
        {
            decimal salario;

            if (nivel == 1)
            {
                salario = 12m * horas;

                Console.WriteLine("O seu salário é de R$ "+salario);
            }
            else if (nivel == 2)
            {
                salario = 17m * horas;

                Console.WriteLine("O seu salário é de R$ " + salario);

            }
            else if (nivel == 3)
            {
                salario = 25m * horas;

                Console.WriteLine("O seu salário é de R$ " + salario);

            }

           


        }

      

    }
}
