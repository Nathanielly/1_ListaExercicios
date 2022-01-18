using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Aula4
    {
       public void Exercicio4()
        {
            string NomeVendedor;
            decimal SalarioFixo, TotalVendas, SalarioFinal;

            Console.WriteLine("Qual o nome do vendedor ? ");
            NomeVendedor = Console.ReadLine();
            Console.Clear();

            Console.Write("Qual seu salario fixo ?\nR$ ");
            SalarioFixo = Convert.ToDecimal(Console.ReadLine());
            Console.Clear(); 

            Console.Write("Qual o valor do total das vendas ?\nR$ ");
            TotalVendas = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();


            SalarioFinal = (TotalVendas * 0.15m) + SalarioFixo;


            Console.WriteLine("O Vendedor " + NomeVendedor + " recebe o salário de R$ " + SalarioFixo + ", neste mês vendeu R$ " + TotalVendas + ", então seu salário fixo somado a comissão será igual a R$ " + SalarioFinal + ".");

        }




    }
}
