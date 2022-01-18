using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio38
{
    public class Exercicio38
    {
        public void notaFinal()
        {

            Console.WriteLine("Informe a nota do trabalho de laboratório: ");
            decimal notaLab = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a nota da avaliação semestral: ");
            decimal notaAvSemestre = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a nota do exame final: ");
            decimal notaExameFinal = Convert.ToDecimal(Console.ReadLine());

            CalculoNotas(notaLab, notaAvSemestre, notaExameFinal);

          

        }

        public void CalculoNotas(decimal notaLab, decimal notaAvSemestre, decimal notaExameFinal)
        {
            decimal NotaFinal = ((notaLab * 2) + (notaAvSemestre * 3) + (notaExameFinal * 5)) / 10 ;

            Console.WriteLine("Sua média final é: " + NotaFinal);
        }


    }
}
