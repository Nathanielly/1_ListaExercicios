using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio35
{
    public class Exercicio35
    {
        public void Categorias()
        {
            Console.WriteLine("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Sua categoria é Infantil A.");
            }
           else if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Sua categoria é Infantil B.");
            }
            else if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Sua categoria é Juvenil A.");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Sua categoria é Juvenil B.");
            }
            else if (idade >= 18 && idade <= 25)
            {
                Console.WriteLine("Sua categoria é Sênior.");
            }

            else
                Console.WriteLine("Idade fora da faixa etária.");
        }



    }
}
