using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    public class Exercicio10
    {
        public void Parcelas()
        {
            decimal ValorVenda, Parcelamento;

            Console.WriteLine("Informe o valor da venda: ");
            ValorVenda = Convert.ToDecimal(Console.ReadLine());

            Parcelamento = ValorVenda / 5;

            Console.WriteLine("Suas parcelas serão no valor de R$: " + Parcelamento);


        }


    }
}
