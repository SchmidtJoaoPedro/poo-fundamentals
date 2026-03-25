using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        struct Funcionario
        {
            public string Nome;
            public double Salario;
        }
        static void GravarDados(ref Funcionario f)
        {
            Console.Write("Digite o nome do funcionário: ");
            f.Nome = Console.ReadLine();
            Console.Write("Digite o salário do funcionário: ");
            f.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDados gravados com sucesso!");
            Console.ReadKey();
        }
        static void ExibirDados(Funcionario a)
        {
            Console.WriteLine("\n--- Dados do Funcionário ---");
            Console.WriteLine($"Nome: {a.Nome}");
            Console.WriteLine($"Salário: {a.Salario:C2}");
            Console.ReadKey();
        }
        static void Main()
        {
            Funcionario f1;
            f1.Nome = null;
            f1.Salario = 0;
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Gravar Nome e Salário do Funcionário");
                Console.WriteLine("2. Mostrar Nome e Salário do Funcionário");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        GravarDados(ref f1);
                        break;
                    case 2:
                        ExibirDados(f1);
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Console.ReadKey();
                        break;

                }
            } while (op != 3);
        }
    }
}