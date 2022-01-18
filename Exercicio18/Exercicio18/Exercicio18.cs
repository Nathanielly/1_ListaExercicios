using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    public class Exercicio18
    {
        public void MaiorMenorIdade()
        {
            int idade, contador = 1;

            while (contador <= 75)
            {
                Console.WriteLine("Informe a idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Clear();

                if (idade > 18)
                {
                    Console.WriteLine("Maior de idade");
                }

                if (idade< 18)
                {
                    Console.WriteLine("Menor de idade");
                }

                contador++;

            }



        }


    }
}
