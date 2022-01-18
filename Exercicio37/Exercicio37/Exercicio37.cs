using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio37
{
    public class Exercicio37
    {
        public void PesoIdeal()
        {

            Console.WriteLine("Informe seu nome: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Informe seu sexo: 1_Masculino ou 2_Feminino.");
            int Sexo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade: ");
            int Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura: ");
            decimal Altura = decimal.Parse(Console.ReadLine());


            Calculo( Nome,  Sexo,  Idade,  Altura);

        }

        public void Calculo(string Nome, int Sexo, int Idade, decimal Altura)
        {
            
            decimal peso = 0;


            if (Sexo == 1 && Idade <= 20 && Altura > 1.70m)
            {
                 peso = (72.7m * Altura) - 58;

            }
            else if (Sexo == 1 && Idade >= 21 || Idade <= 39 && Altura > 1.70m)
            {
                 peso = (72.7m * Altura) - 53;

            }
            else if (Sexo == 1 && Idade >= 40 && Altura > 1.70m)
            {
                 peso = (72.7m * Altura) - 45;

            }
            else if (Sexo == 1 && Idade <= 40 && Altura <= 1.70m)
            {
                 peso = (72.7m * Altura) - 50;

            }
            else if (Sexo == 1 && Idade > 40 && Altura <= 1.70m)
            {
                 peso = (72.7m * Altura) - 50;

            }
            else if (Sexo == 2 && Altura > 1.50m)
            {
                 peso = (62.1m * Altura) - 44.7m;

            }
            else if (Sexo == 2 && Idade >=35 && Altura <= 1.50m)
            {
                peso = (62.1m * Altura) - 45;

            }
            else if (Sexo == 2 && Idade < 35 && Altura <= 1.50m)
            {
                peso = (62.1m * Altura) - 49;

                
            }


            ExibirUsuario(peso, Nome);



        }
        public void ExibirUsuario(decimal peso, string Nome)
        {
            
            Console.WriteLine("O peso ideal de " + Nome + " é de  " + peso + " kg.");

        }
        


    }
}
