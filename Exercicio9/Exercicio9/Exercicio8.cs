using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    public class Exercicio8
    {
        public void ValorRendimento()
        {
            decimal Deposito, Rendimento, ValorTotal;

            Console.WriteLine("Informe o valor depositado na conta: ");
            Deposito = Convert.ToDecimal(Console.ReadLine());

            Rendimento = Deposito * 0.007m;
            ValorTotal = Deposito + Rendimento;

            Console.WriteLine("O valor total da sua conta é de R$ " + ValorTotal);

        }

    }
}
