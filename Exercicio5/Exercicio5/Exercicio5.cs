using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Exercicio5
    {
        public void MediaAluno() 
        {
            string NomeAluno;
            double n1, n2, n3, MediaFinal;

            Console.WriteLine("Informe o nome do Aluno: ");
            NomeAluno = Console.ReadLine();

            Console.WriteLine("Informe as notas das provas: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());

            MediaFinal = (n1 + n2 + n3) / 3;

            Console.WriteLine("O aluno " + NomeAluno + " obteve a média final de " + MediaFinal + " pontos.");

        }

       


    }
}
