using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio21
{
    public class Exercicio21
    {
        public void DadosPessoas()
        {
            var servicoMilitar = new List<Entidades.ServicoMilitar>();

            string nome;
            int pessoa = 0, idade, saude, sexo;

            while (pessoa < 3)
            {

                Console.WriteLine("Informe o nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Informe a idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o sexo, sendo 1_Masculino ou 2_Feminino: ");
                sexo = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o estado de saúde, sendo 1_Bom estado ou 2_Mal estado:");
                saude = int.Parse(Console.ReadLine());

                Console.Clear();

                var candidato = new Entidades.ServicoMilitar();
                candidato.nome = nome;
                candidato.idade = idade;
                candidato.sexo = sexo;
                candidato.saude = saude;
                servicoMilitar.Add(candidato);

                pessoa++;

                if (idade >= 18 && sexo == 1 && saude == 1)
                {
                    Console.WriteLine("Apto para cumprir o serviço militar.");
                }
                else
                    Console.WriteLine("Não apto para cumprir o serviço militar.");

            }

                Console.WriteLine("\nO total de candidatos é: ");

                foreach (var qtdePessoas in servicoMilitar)
                {
                    Console.WriteLine(pessoa);
                }

            

        }

      


    }
}
