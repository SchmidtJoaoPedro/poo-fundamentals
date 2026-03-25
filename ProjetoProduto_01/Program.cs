using System;
using System.Collections.Generic;

namespace ProjetoProduto_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listaProdutos = new List<Produto>();
            int ok = 1;
            Produto P1;

            do
            {
                Console.Write("Nome do Produto: ");
                string nome = Console.ReadLine();

                Console.Write("Data de Validade (dia mês ano): ");
                string[] dataPartes = Console.ReadLine().Split(' ');
                TData dataValidade = new TData();

                P1 = new Produto(nome, dataValidade);

                Console.Write("Preço do Produto: ");
                P1.Preco = double.Parse(Console.ReadLine());

                Console.Write("Quantidade do Produto: ");
                P1.Estoque = int.Parse(Console.ReadLine());

                listaProdutos.Add(P1);

                Console.Write("Deseja Continuar?\n1 = Sim / 0 = Não: ");
                ok = int.Parse(Console.ReadLine());

            } while (ok == 1);

            foreach (Produto produto in listaProdutos)
            {
                Console.WriteLine("\nDados do Produto:");
                Console.WriteLine(produto.MostrarProduto());
                Console.WriteLine("Data de Validade: " + produto.DataValidade.DataShort());
            }
        }
    }
}
