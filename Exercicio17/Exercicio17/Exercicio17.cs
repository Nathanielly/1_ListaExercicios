using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    public class Exercicio17
    {
        public void Intervalo()
        {
            int contador = 1, contagemNumeros = 0, numero;

            while (contador <= 80)
            {
                Console.WriteLine("Digite o número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 10 && numero <= 150)
                {
                    contagemNumeros++;
                }

                contador++;

            }

            Console.WriteLine("A quantidade de numeros entre 10 e 150 é: " + contagemNumeros);


        }


    }
}
