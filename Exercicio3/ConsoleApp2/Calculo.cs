using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Calculo
    {
        public void Exercicio3()
        {
            int escolha;

            Console.WriteLine("Escolha uma opção:\n 1_Consumo Médio\n 2_Km Maximo\n 3_Distancia Percorrida");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    ConsumoMedio();
                    break;

                case 2:
                    KmMaximo(0.0);
                    break;

                case 3:
                    double DistanciaPercorrida = ConsumoMedio();
                    KmMaximo(DistanciaPercorrida);
                    break;

            }

  
        }

        public double ConsumoMedio()
        {
            double km, LitrosConsumidos, ConsumoMedio;

            Console.WriteLine("Informe a distancia total percorrida: ");
            km = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o consumo de gasolina: ");
            LitrosConsumidos = Convert.ToDouble(Console.ReadLine());

            ConsumoMedio = km / LitrosConsumidos;

            Console.WriteLine("O consumo médio do seu veículo é de " + ConsumoMedio + "km/l");

            return ConsumoMedio;
        }
        public double KmMaximo(double ConsumoMedio)
        {
            double LitrosAbastecidos, KmMaximo;

            if (ConsumoMedio == 0)
            {
                Console.WriteLine("Informe a eficîência do seu veículo: ");
                ConsumoMedio = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Informe a quantidade de combustivel abastecido: ");
            LitrosAbastecidos = Convert.ToDouble(Console.ReadLine());

            KmMaximo = ConsumoMedio * LitrosAbastecidos;

            Console.WriteLine("O seu veículo percorrerá: " + KmMaximo + "km.");

            return KmMaximo(ConsumoMedio);

        }






        

       
    }
}
