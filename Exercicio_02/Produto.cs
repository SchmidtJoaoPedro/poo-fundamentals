namespace ProjetoProduto
{
    internal class produto
    {
        public produto(string name)
        {
            this.name = name;
        }

        private string name;
        private double valor;
        private int estoque;


        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }
        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }

        public void GravarProduto()
        {

        }
        public void MostrarProduto()
        {

        }
        public double CalcularValorTotal()
        {
            return valor * estoque;
        }

    }
}
