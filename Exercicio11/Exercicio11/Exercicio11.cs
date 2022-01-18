using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    public class Exercicio11
    {
        public void VendaAcrescimo()
        {
            decimal ValorCusto, Acrescimo, ValorVenda;
            
            Console.WriteLine("Informe o valor de venda: ");
            ValorCusto = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o percentual de acréscimo: ");
            Acrescimo = Convert.ToDecimal(Console.ReadLine());

            ValorVenda = (ValorCusto * Acrescimo / 100) + ValorCusto;

            Console.WriteLine("O valor de venda é de R$ " + ValorVenda);

        }
    }
}
