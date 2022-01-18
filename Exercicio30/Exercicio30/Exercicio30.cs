using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio30
{
    public class Exercicio30
    {
        public void Funcionario()
        {

            Console.WriteLine("Informe o nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu sexo: ");
            bool sexo = bool.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu salario fixo: ");
            decimal salarioFixo = decimal.Parse(Console.ReadLine());


            if (sexo == true && idade >= 30)
            {

                decimal salarioLiquido = salarioFixo + 100m;

                Console.WriteLine("O salário liquido de " + nome + " será de R$ " + salarioLiquido);
            }

            else if (sexo == true && idade < 30)
            {
                decimal salarioLiquido = salarioFixo + 50m;

                Console.WriteLine("O salário liquido de " + nome + " será de R$ " + salarioLiquido);

            }
            else if (sexo == false && idade >= 30)
            {
                decimal salarioLiquido = salarioFixo + 200m;

                Console.WriteLine("O salário liquido de " + nome + " será de R$ " + salarioLiquido);

            }
            else if (sexo == false && idade < 30)
            {
                decimal salarioLiquido = salarioFixo + 80m;

                Console.WriteLine("O salário liquido de " + nome + " será de R$ " + salarioLiquido);

            }
        }


    }
}
