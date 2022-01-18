using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    public class Exercicio7
    {
        public void ConversaoTemperatura()
        {
            decimal Temperatura, Conversao;

            Console.WriteLine("Informe a temperatura em ºC: ");
            Temperatura = Convert.ToDecimal(Console.ReadLine());

            /// Formula para conversão -> F=(9*C+160)/5.
            /// F = Fahrenheit e C = Celsius

            Conversao = (9 * Temperatura + 160) / 5;

            Console.WriteLine("A temperatura informada convertida para graus Fahrenheit é igual a: " + Conversao + "ºF.");

        }





    }
}
