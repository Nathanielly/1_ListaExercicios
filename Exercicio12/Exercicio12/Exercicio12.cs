using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    public class Exercicio12
    {
        public void CustoCarroNovo()
        {

            decimal CustoFabrica, CustoImpostos, CustoDistribuidor;

            Console.WriteLine("Informe o custo de fábrica do veículo R$ ");
            CustoFabrica =  Convert.ToDecimal(Console.ReadLine());

            CustoImpostos = (CustoFabrica * 0.45m) + CustoFabrica;

            CustoDistribuidor = (CustoImpostos * 0.28m) + CustoImpostos;

            Console.WriteLine("O custo de um carro novo é de R$ " + CustoDistribuidor);


        }

    }
}
