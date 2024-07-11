using System;
using FuncionarioManager;
using PassagemManager;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escolha o exercício para executar:");
        Console.WriteLine("1 - Sistema de Gerenciamento de Funcionários");
        Console.WriteLine("2 - Sistema de Cobrança de Passagens");
        Console.Write("Digite o número do exercício: ");
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                FuncionarioProgram.Execute();
                break;
            case "2":
                PassagemProgram.Execute();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
