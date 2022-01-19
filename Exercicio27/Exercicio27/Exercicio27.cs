using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista01
{
    public class Exercicio27
    {
        public void ConsercionariaCarango()
        {
            var veiculosInformados = new List<Entidades.Veiculo>();

            while (true)
            {
                var veiculoInformado = Perguntas();

                if(veiculoInformado == null)
                    break;

                veiculoInformado = CalculoDesconto(veiculoInformado);
                veiculosInformados.Add(veiculoInformado);
            }

            ExibirUsuario(veiculosInformados);
        }
        private Entidades.Veiculo Perguntas()
        {
            var veiculoInformado = new Entidades.Veiculo();

            Console.WriteLine("Informe o valor do veículo: R$ \nPara parar digite 0.");
            veiculoInformado.ValorVeiculo = decimal.Parse(Console.ReadLine());

            
            if (veiculoInformado.ValorVeiculo == 0)
                return null;

            Console.WriteLine("Informe o tipo de combustível: 1_álcool , 2_Gasolina ou 3_ Diesel");
            
            veiculoInformado.CombustivelVeiculo = int.Parse(Console.ReadLine());

            Console.Clear();
            return veiculoInformado;
        }

        private Entidades.Veiculo CalculoDesconto(Entidades.Veiculo veiculoInformado)
        {
            decimal valorDesconto = 0;

            if (veiculoInformado.CombustivelVeiculo == 1)
            {
                valorDesconto = 0.25m;
            }
            else if (veiculoInformado.CombustivelVeiculo == 2)
            {
                valorDesconto = 0.21m;
            }
            else if (veiculoInformado.CombustivelVeiculo == 3)
            {
                valorDesconto = 0.14m;
            }

            veiculoInformado.ValorDesconto = veiculoInformado.ValorVeiculo * valorDesconto;
            veiculoInformado.ValorTotal = veiculoInformado.ValorVeiculo - veiculoInformado.ValorDesconto;

            return veiculoInformado;
        }

        private void ExibirUsuario(List<Entidades.Veiculo> veiculosInformados)
        {
            decimal valorTotalDesconto = 0, valorTotalPagar = 0;
            foreach (var veiculo in veiculosInformados)
            {
  
                valorTotalDesconto += veiculo.ValorDesconto;
                valorTotalPagar = valorTotalPagar + veiculo.ValorTotal;
            }

            Console.WriteLine("\nO valor total do desconto é de R$" + valorTotalDesconto + "\nE o valor total a pagar é de R$" + valorTotalPagar);

        }
    }
}
