using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio28
{
    public class Exercicio28
    {
        public void ReajusteSalarial()
        {
            string nome;
            decimal salario, somaSalario = 0, salarioReajustado = 0, reajuste, salarioMin;
            
            int i;

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Informe o nome do funcionário: ");
                nome = Console.ReadLine();

                Console.WriteLine("Informe o salário minimo da empresa: ");
                salarioMin = decimal.Parse(Console.ReadLine());


                Console.WriteLine("Informe o salário: ");
                salario = decimal.Parse(Console.ReadLine());
                


                decimal salarioMinimo = salario / salarioMin;

                if (salarioMinimo < 3)
                {
                    salarioReajustado = salario * 1.50m;

                }
                else if (salarioMinimo > 3 || salarioMinimo < 10)
                {
                    salarioReajustado = salario * 1.20m;
                }
                else if (salarioMinimo > 10 || salarioMinimo < 20)
                {
                    salarioReajustado = salario * 1.20m;
                }
                else if (salarioMinimo > 20)
                {
                    salarioReajustado = salario * 1.10m;
                }

                

            }

            

        }


          

        


    }
}
