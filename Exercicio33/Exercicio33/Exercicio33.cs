using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio33
{
    public class Exercicio33
    {
        public void Triangulo()
        {

            Console.WriteLine("Informe as três medidas do triângulo: ");
            decimal med1 = decimal.Parse(Console.ReadLine());
            decimal med2 = decimal.Parse(Console.ReadLine());
            decimal med3 = decimal.Parse(Console.ReadLine());

            decimal validarTriangulo1 = med1 + med2;
            decimal validarTriangulo2 = med2 + med3;
            decimal validarTriangulo3 = med1 + med3;


            if (med3 > validarTriangulo1 | med1 > validarTriangulo2 | med2 > validarTriangulo3)
            {
                Console.WriteLine("As medidas informadas não são de um triângulo.");
            }

            else if (med1 == med2 && med2 == med3)
            {
                Console.WriteLine("É um triângulo equilátero.");
            }

            else if (med1 == med2 || med2 == med3 || med3 == med1)
            {
                Console.WriteLine("É um triângulo isóscele.");

            }

            else if (med1 != med2 && med2 != med3 && med3 != med1)
            {
                Console.WriteLine("É um triângulo escaleno.");

            }

        }


    }
}
