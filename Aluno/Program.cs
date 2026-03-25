using System;

namespace Aluno
{
    internal class class_Aluno
    {
        private string nome;
        private int matricula;
        private string CPF;
        private string curso;
        private double[] notas;

        public class_Aluno()
        {
            notas = new double[3];
        }
        public void GravarDados()
        {
            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a matrícula do aluno: ");
            matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CPF do aluno: ");
            CPF = Console.ReadLine();
            Console.WriteLine("Digite o curso do aluno: ");
            curso = Console.ReadLine();
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Digite a nota {i + 1} do aluno: ");
                notas[i] = double.Parse(Console.ReadLine());
            }
        }
        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Matrícula: {matricula}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Curso: {curso}");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {notas[i]}");
            }
            Console.WriteLine("Média: " + CalcularMedia());
        }
        public double CalcularMedia()
        {
            double soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }
            return soma / notas.Length;
        }
        public string Situacao
        {
            get
            {
            return ((notas[0] + notas[1] + notas[2]) / 3) < 6 ? "reprovado" : "aprovado";
            }
        }
        public string mostrar()
        {
            string agua = nome + " - " + matricula + " - " + Situacao;
            return agua;
        }
    }
}