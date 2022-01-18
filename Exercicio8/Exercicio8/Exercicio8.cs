using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    public class Exercicio8
    {
        public void ConversaoDolar()
        {
            decimal Cotacao, Real, Conversao;

            Console.WriteLine("Informe o valor da cotação do dólar US$: ");
            Cotacao = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a quantia a ser convertida em Real: ");
            Real = Convert.ToDecimal(Console.ReadLine());

            Conversao = Cotacao * Real;

            Console.WriteLine("O resultado da conversão é " + Conversao + " reais.");
        }


    }
}
