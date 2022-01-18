using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio39
{
    public class Exercicio39
    {
        public void ClassificacaoFinal(decimal NotaFinal)
        {

            Console.WriteLine("Informe a matrícula do aluno: ");
            int matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do aluno: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do trabalho de laboratório: ");
            decimal notaLab = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a nota da avaliação semestral: ");
            decimal notaAvSemestre = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a nota do exame final: ");
            decimal notaExameFinal = Convert.ToDecimal(Console.ReadLine());

            CalculoNotas(notaLab, notaAvSemestre, notaExameFinal);

            string classificacao;

            if (NotaFinal > 8 || NotaFinal < 10)
            {
                classificacao = "A";
            }

            else if (NotaFinal > 7 || NotaFinal < 8)
            {
                classificacao = "B";
            }

            else if (NotaFinal > 6 || NotaFinal < 7)
            {
                classificacao = "C";
            }

            else if (NotaFinal > 5 || NotaFinal < 6)
            {
                classificacao = "D";
            }

            else if (NotaFinal > 0 || NotaFinal < 5)
            {
                classificacao = "R";
            }

            Console.WriteLine(" A classificação do aluno " + Nome + ", com a matricula " + matricula + " alcançou a nota final "
                + NotaFinal + " e obteve a classificação " + classificacao);



        }


        public decimal CalculoNotas(decimal notaLab, decimal notaAvSemestre, decimal notaExameFinal )
        {
            decimal NotaFinal = ((notaLab * 2) + (notaAvSemestre * 3) + (notaExameFinal * 5)) / 10;

            return NotaFinal;


        }


    }
}
