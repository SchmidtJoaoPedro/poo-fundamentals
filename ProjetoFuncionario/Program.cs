using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        static void Main()
        {
            Funcionario f1 = new Funcionario();
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
                        f1.GravarDados();
                        break;
                    case 2:
                        f1.ExibirDados();
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