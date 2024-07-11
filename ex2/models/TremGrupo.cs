namespace PassagemManager.Models
{
    public class TremGrupo : IPassagem
    {
        private int qtdPassagem;
        private double preco;

        public void SetPreco(double preco)
        {
            this.preco = preco;
        }

        public void SetQtdPassagem(int qtdPassagem)
        {
            this.qtdPassagem = qtdPassagem;
        }

        public double GetPreco()
        {
            return qtdPassagem * preco;
        }
    }
}
