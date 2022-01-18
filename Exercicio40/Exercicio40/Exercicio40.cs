using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio40
{
    public class Exercicio40
    {
        public void Seguro()
        {

            Console.WriteLine("Informe o nome: ");
            Console.ReadLine();

            Console.WriteLine("Informe a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o grupo de risco: 1_Baixo, 2_Médio ou 3_Alto");
            int grupoRisco = int.Parse(Console.ReadLine());

            int categoria ;

            if (idade > 17 || idade < 20 && grupoRisco == 1)
            {
                
            }






        }




    }
}
