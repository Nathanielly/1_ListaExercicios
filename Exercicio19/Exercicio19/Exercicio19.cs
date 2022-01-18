using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    public class Exercicio19
    {
        public void NomeSexo()
        {
            int contador = 1, contagemNumerosHomens = 0, contagemNumerosMulher = 0;
            string Nome, Sexo;


            while(contador <= 56)
            {
                Console.WriteLine("Informe o nome: ");
                Nome = Console.ReadLine();

                Console.WriteLine("Informe o sexo: Homem ou Mulher");
                Sexo = Console.ReadLine();

                if (Sexo == "Homem")
                {
                    contagemNumerosHomens++;

                    Console.WriteLine("O " + Nome + " é " + Sexo);


                }

                if (Sexo == "Mulher")
                {
                    contagemNumerosMulher++;

                    Console.WriteLine("A " + Nome + " é " + Sexo);


                }

                contador++;
            }

            Console.WriteLine("A quantidade total de homens é: " + contagemNumerosHomens);
            Console.WriteLine("A quantidade total de mulheres é: " + contagemNumerosMulher);



        }   


    }
}
