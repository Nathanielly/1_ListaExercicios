using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    public class Exercicio14
    {
        public void DoisValores()
        {
            int Num1, Num2;

            Console.WriteLine("Informe o número: ");
            Num1 = int.Parse(Console.ReadLine());
            Num2 = int.Parse(Console.ReadLine());

            if (Num1 > Num2)
            {
                Console.WriteLine("O número maior é: "+Num1);
            }

            else if (Num2 > Num1)
            {
                Console.WriteLine("O número maior é: " + Num2);
            }



        }


    }
}
