namespace FuncionarioManager.Models
{
    public class Funcionario
    {
        public string? Cpf { get; set; }
        public string? Nome { get; set; }
        public string? Departamento { get; set; }
        public decimal Salario { get; set; }

        public virtual string ShowInfo()
        {
            return $"CPF: {Cpf}, Nome: {Nome}, Departamento: {Departamento}, Salário: {Salario:C}";
        }
    }
}
