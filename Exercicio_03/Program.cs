using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetorNome = new string[5];
            double [] vetoresImc = new double[5];]
            double altura , peso;

            foreach (double str in vetoresNomes)
            {
                if(str < 18.5) 
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (str >= 18.5 && str < 25)
                {
                    Console.WriteLine("Peso normal");
                }
                else if (str >= 25 && str < 30)
                {
                    Console.WriteLine("Sobrepeso");
                }
                else if (str >= 30 && str < 35)
                {
                    Console.WriteLine("Obesidade grau I");
                }
                else if (str >= 35 && str < 40)
                {
                    Console.WriteLine("Obesidade grau II");
                }
                else
                {
                    Console.WriteLine("Obesidade grau III");
                }
            } 
        }
    }
}
