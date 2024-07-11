namespace PassagemManager.Models
{
    public class Cobrador
    {
        private readonly IPassagem passagem;

        public double ValorACobrar { get; private set; }

        public Cobrador(IPassagem passagem)
        {
            this.passagem = passagem;
            ValorACobrar = passagem.GetPreco();
        }
    }
}
