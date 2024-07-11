using System;
using FuncionarioManager.Models;

namespace FuncionarioManager
{
    public static class FuncionarioProgram
    {
        public static void Execute()
        {
            Funcionario gerente = new Gerente
            {
                Cpf = "111.222.333-44",
                Nome = "Carlos Silva",
                Departamento = "Administrativo",
                Salario = 12000.00m,
                Bonificacao = 3000.00m
            };

            Funcionario desenvolvedor = new Desenvolvedor
            {
                Cpf = "222.333.444-55",
                Nome = "Ana Pereira",
                Departamento = "Desenvolvimento",
                Salario = 8000.00m,
                LinguagemDeProgramacao = "C#"
            };

            Funcionario estagiario = new Estagiario
            {
                Cpf = "333.444.555-66",
                Nome = "João Souza",
                Departamento = "Marketing",
                Salario = 1500.00m,
                HorasPorSemana = 20
            };

            Console.WriteLine(gerente.ShowInfo());
            Console.WriteLine(desenvolvedor.ShowInfo());
            Console.WriteLine(estagiario.ShowInfo());
        }
    }
}
