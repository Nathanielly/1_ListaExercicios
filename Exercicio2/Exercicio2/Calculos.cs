using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Calculo
    {
        public void Excercicio2()
        {
            double n1, n2, resultado1, resultado2, resultado3, resultado4;

            Console.WriteLine("Digite os valores a serem calculados: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());

            resultado1 = n1 + n2;
            resultado2 = n1 - n2;
            resultado3 = n1 * n2;
            resultado4 = n1 / n2;

            Console.WriteLine("Os resultados são: adição = " + resultado1);
            Console.WriteLine("Os resultados são: subtração = " + resultado2);
            Console.WriteLine("Os resultados são: multiplicação = " + resultado3);
            Console.WriteLine("Os resultados são: divisão = " + resultado4);



        }
       

    }
}
