using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFuncionario
{
    public class Funcionario
    {
        public string Nome;
        public double Salario;

        public void GravarDados()
        {
            Console.Write("Digite o nome do funcionário: ");
            Nome = Console.ReadLine();
            Console.Write("Digite o salário do funcionário: ");
            Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDados gravados com sucesso!");
            Console.ReadKey();
        }
        public void ExibirDados()
        {
            Console.WriteLine("\n--- Dados do Funcionário ---");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salário: {Salario:C2}");
            Console.ReadKey();
        }
    }
}
