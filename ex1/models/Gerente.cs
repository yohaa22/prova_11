namespace FuncionarioManager.Models
{
    public class Gerente : Funcionario
    {
        public decimal Bonificacao { get; set; }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}, Bonificação: {Bonificacao:C}";
        }
    }
}
