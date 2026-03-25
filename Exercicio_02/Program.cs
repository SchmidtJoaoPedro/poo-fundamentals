using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            produto P1 = new produto("Sabonete");
            P1.GravarProduto();
            Console.WriteLine("Digite o valor do produto: ");
            P1.MostrarProduto();
            Console.WriteLine("Digite a quantidade em estoque: ");
            Console.WriteLine("Total do valor do estoque: " + P1.CalcularValorTotal());
            Console.ReadKey();
        }
    }
}