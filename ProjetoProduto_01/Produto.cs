using System;

namespace ProjetoProduto_01
{
    internal class Produto
    {
        private string nome;
        private double preco;
        private int estoque;
        private TData dataValidade;

        public Produto(string nome, TData dataValidade)
        {
            this.nome = nome;
            this.dataValidade = dataValidade;
        }

        public double Preco { get => preco; set => preco = value; }
        public int Estoque { get => estoque; set => estoque = value; }
        public TData DataValidade { get => dataValidade; set => dataValidade = value; }
        public string MostrarProduto()
        {
            return $"Nome: {nome}\nPreço: {preco}\nEstoque: {estoque}";
        }
        public double CalcularEstoque()
        {
            return preco * estoque;
        }
    }
    class TCPF
    {
        private string cpf;
        public string Cpf
        {
            get { return cpf; }
        }

        public bool ValidaCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

            if (cpf.EndsWith(digito) == true)
                this.cpf = cpf;

            return cpf.EndsWith(digito);
        }

        public string MostraCPF()
        {
            string msg = "";
            long auxCPF = long.Parse(cpf);
            string CPFFormatado = String.Format(@"{0:000\.000\.000\-00}", auxCPF);
            msg = CPFFormatado;
            return msg;
        }

    }

    internal class TData
    {
        private int dia;
        private int mes;
        private int ano;


        public int Dia
        {
            get { return dia; }
            set { dia = (value >= 1 && value <= 31) ? value : 0; }
        }

        public int Mes
        {
            get { return mes; }
            set { mes = (value >= 1 && value <= 12) ? value : 0; }
        }

        public int Ano { get => ano; set => ano = value; }

        public string DataShort()
        {
            string msg = (dia < 10) ? "0" + dia + "/" : dia + "/";
            msg += (mes < 10) ? "0" + mes + "/" : mes + "/";
            msg += ano.ToString();
            return msg;

        }

        public string DataLong()
        {
            string[] meses = { "janeiro", "fevereiro", "março", "abril" };
            string msg = (dia < 10) ? "0" + dia + " de " : dia + " de ";
            msg += meses[mes] + " de " + ano;
            return msg;

        }
    }

}
