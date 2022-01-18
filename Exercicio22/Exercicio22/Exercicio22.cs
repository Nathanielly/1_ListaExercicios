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
            decimal valorCusto = 0, valorVenda = 0;

            var listaProdutos = new List<Entidades.Produto>();

            while (true)
            {
                Console.WriteLine("Informe o preço de custo: ");
                valorCusto = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor de venda: ");
                valorVenda = Convert.ToDecimal(Console.ReadLine());

                var produto = new Entidades.Produto();
                produto.precoCusto = valorCusto;
                produto.precoVenda = valorVenda;

                listaProdutos.Add(produto);

                if (valorCusto < valorVenda)
                {
                    Console.WriteLine("Venda com lucro.");

                }
                else if (valorCusto == valorVenda)
                {
                    Console.WriteLine("Não houve lucro e nem prejuízo.");

                }
                else if (valorCusto > valorVenda)
                {
                    Console.WriteLine("Venda com prejuízo.");

                }

                


            }


           

        }




    }
}
