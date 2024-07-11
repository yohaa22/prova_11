namespace PassagemManager.Models
{
    public class TremUnitario : IPassagem
    {
        private double preco;

        public void SetPreco(double preco)
        {
            this.preco = preco;
        }

        public double GetPreco()
        {
            return preco;
        }
    }
}
