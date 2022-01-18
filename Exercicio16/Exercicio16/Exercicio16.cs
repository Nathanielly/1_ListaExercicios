using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    public class Exercicio16
    {
        public void ResultadoAluno()
        {
            string NomeAluno;
            double nota1, nota2, nota3, Media;

            Console.WriteLine("Informe o nome do aluno: ");
            NomeAluno = Console.ReadLine();

            Console.WriteLine("Informe as notas: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            nota2 = Convert.ToDouble(Console.ReadLine());
            nota3 = Convert.ToDouble(Console.ReadLine());

            Media = (nota1 + nota2 + nota3) / 3;

            if (Media >= 7)
            {
                Console.WriteLine("O Aluno " + NomeAluno + " foi aprovado.");
            }

            else if (Media <= 5)
            {
                Console.WriteLine("O Aluno " + NomeAluno + " foi reprovado.");
            }

            else if (Media >= 5.1 & Media <= 6.9)
            {
                Console.WriteLine("O Aluno " + NomeAluno + " está em recuperação.");
            }

        }
    }
}
