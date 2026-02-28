using System;
using System.Globalization;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            int op2 = 0;
            string nomeProduto = "";
            double valorProduto = 0;
            string formaPagamento = "";

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Nome do Produto");
                Console.WriteLine("2 - Valor do Produto");
                Console.WriteLine("3 - Forma de Pagamento");
                Console.WriteLine("4 - Mostrar Dados da Compra");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Opção inválida.");
                    Console.ReadKey();
                    continue;
                }

                switch (op)
                {
                    case 1:
                        Console.Write("Digite o nome do produto: ");
                        nomeProduto = Console.ReadLine();
                        break;

                    case 2:
                        Console.Write("Digite o valor do produto: ");
                        if (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out valorProduto))
                        {
                            Console.WriteLine("Valor inválido.");
                            valorProduto = 0;
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("1 - Dinheiro");
                            Console.WriteLine("2 - Pix");
                            Console.WriteLine("3 - Cartão");
                            Console.WriteLine("4 - Voltar");
                            Console.Write("Escolha a forma de pagamento: ");

                            if (!int.TryParse(Console.ReadLine(), out op2))
                            {
                                Console.WriteLine("Opção inválida.");
                                Console.ReadKey();
                                continue;
                            }

                            switch (op2)
                            {
                                case 1:
                                    formaPagamento = "Dinheiro";
                                    break;
                                case 2:
                                    formaPagamento = "Pix";
                                    break;
                                case 3:
                                    formaPagamento = "Cartão";
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida.");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (op2 != 4);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("===== DADOS DA COMPRA =====");
                        Console.WriteLine($"Produto: {nomeProduto}");
                        Console.WriteLine($"Valor: R$ {valorProduto.ToString("F2", CultureInfo.InvariantCulture)}");
                        Console.WriteLine($"Forma de Pagamento: {formaPagamento}");
                        Console.WriteLine("===========================");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("Encerrando o sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        Console.ReadKey();
                        break;
                }

            } while (op != 5);
        }
    }
}