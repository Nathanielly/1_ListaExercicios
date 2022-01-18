using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20
{
    public class Exercicio20
    {
        decimal ValorVeiculo, ValorDesconto, ValorPagar;
        int Ano;

        public void CarangoVelho()
        {

            var Veiculos = new List<Entidades.InformacoesVeiculo>();

            while (true)
            {
                Console.WriteLine("Informe o ano do veículo: ");
                Ano = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor do veículo: ");
                ValorVeiculo = Convert.ToDecimal(Console.ReadLine());

                var veiculo = new Entidades.InformacoesVeiculo();
                            veiculo.anoVeiculo = Ano;
                            veiculo.valorVeiculo = ValorVeiculo;
                            veiculo.valorDesconto = CalculoDesconto(veiculo.valorVeiculo);
                    Veiculos.Add(veiculo);


                Console.WriteLine("Aperte N para finalizar.");
                if (Console.ReadKey().Key == ConsoleKey.N)
                    break;
      
                

            }

            QuantidadeVeiculo(Veiculos);
        }


        public decimal CalculoDesconto(decimal ValorVeiculo)
        {
            if (Ano < 2000)
            {
                ValorDesconto = ValorVeiculo * 0.12m;
                ValorPagar = ValorVeiculo - ValorDesconto;

                return ValorPagar;
            }
            else
                ValorDesconto = ValorVeiculo * 0.07m;
            ValorPagar = ValorVeiculo - ValorDesconto;


            return ValorPagar;

        }

        public void QuantidadeVeiculo(List<Entidades.InformacoesVeiculo> Veiculos)
        {
            int TotalVeiculos = Veiculos.Count(), QuantidadeMenor2000 = 0;
            
            

            foreach (var veiculo in Veiculos)
            {
                if (veiculo.anoVeiculo < 2000) ;
                     QuantidadeMenor2000++;

            }

            ExibirResultadoCliente(TotalVeiculos, QuantidadeMenor2000);


        }

        public void ExibirResultadoCliente(int TotalVeiculos, int QuantidadeMenor2000)
        {
            Console.WriteLine("O desconto foi de " + ValorDesconto + "O total a pagar é de " + ValorPagar);
            Console.WriteLine("O total de veículos é " + TotalVeiculos + ", e o total de veiculos abaixo do ano 2000 é igual a: " + QuantidadeMenor2000);
        }

        
    }
}
