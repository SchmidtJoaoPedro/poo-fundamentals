using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGeometria
{
    public class Geometria
    {
        public double Base;
        public double Altura;

        public void GravarDados()
        {
            Console.Write("\nDigite a base: ");
            Base = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDados gravados com sucesso!");

        }

        public void MostrarArea()
        {
            double area = (Base * Altura) /2;
            Console.WriteLine("\n--- Área do Triangulo ---");
            Console.WriteLine($"Base: {Base}");
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine($"Área: {area}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Geometria g1 = new Geometria();
            Geometria g2 = new Geometria();

            g1.GravarDados();
            g1.MostrarArea();

            g2.GravarDados();
            g2.MostrarArea();

            Console.ReadKey();
        }
    }
}
