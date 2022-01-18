using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio36
{
    public class Exercicio36
    {
        public void ContaLuz()
        {

            Console.WriteLine("Informe seu tipo: 1_Residência\n2_Comércio\n3_Indústria");
            int tipoCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de KW/h utilizado: ");
            decimal KWh = decimal.Parse(Console.ReadLine());

            if (tipoCliente == 1)
            {
                var valorContaLuz = KWh * 0.60m;

                Console.WriteLine("O valor da conta de luz é R$ "+valorContaLuz);
            }

            else if (tipoCliente == 2)
            {
                var valorContaLuz = KWh * 0.48m;

                Console.WriteLine("O valor da conta de luz é R$ " + valorContaLuz);
            }

            else if (tipoCliente == 3)
            {
                var valorContaLuz = KWh * 1.29m;

                Console.WriteLine("O valor da conta de luz é R$ " + valorContaLuz);
            }

        }



        





    }
}
