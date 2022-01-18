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
            var funcionarios = new List<Entidades.Funcionario>();

            Console.WriteLine("Informe o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o salário: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            var funcionario = new Entidades.Funcionario();
            funcionario.nome = nome;
            funcionario.salario = salario;
            funcionarios.Add(funcionario);

            Calculo(salario, nome);

        }
        public void Calculo(decimal salario, string nome)
        {
            //salario minimo = 1210.00

            decimal salarioMinimo = salario / 1210m;
            decimal salarioReajustado = 0;

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

            Console.WriteLine("O funcionário " + nome + " (,receberá o reajuste de) e seu novo salário será de R$ " + salarioReajustado );

        }


    }
}
