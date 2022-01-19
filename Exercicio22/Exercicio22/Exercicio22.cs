using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio22
{
    public class Exercicio22
    {
        public void Produtos()
        {
            decimal valorCusto = 0, valorVenda = 0, somaCusto =0, totalCusto = 0, somaVenda = 0, totalVenda = 0, somaCustoTotal =0, somaVendaTotal = 0;

            

            for (int i = 0; i < 40; i ++)
            {
                Console.WriteLine("Informe o preço de custo: ");
                valorCusto = decimal.Parse(Console.ReadLine());
                somaCusto += valorCusto;
                totalCusto = totalCusto + 1;

                Console.WriteLine("Informe o valor de venda: ");
                valorVenda = Convert.ToDecimal(Console.ReadLine());
                somaVenda += valorVenda;
                totalVenda = totalVenda + 1;


                if (valorCusto < valorVenda)
                {
                    Console.WriteLine("Venda com lucro.\n");

                }
                else if (valorCusto == valorVenda)
                {
                    Console.WriteLine("Não houve lucro e nem prejuízo.\n");

                }
                else if (valorCusto > valorVenda)
                {
                    Console.WriteLine("Venda com prejuízo.\n");

                }

                

            }
            

            somaCustoTotal = somaCusto / totalCusto;
            somaVendaTotal = somaVenda / totalVenda;

            Console.WriteLine("\nA média do preço de custo é R$ " + somaCustoTotal);
            Console.WriteLine("\nA média do preço de venda é R$ " + somaVendaTotal);

            

        }




    }
}
