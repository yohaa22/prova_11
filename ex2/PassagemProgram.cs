using System;
using PassagemManager.Models;

namespace PassagemManager
{
    public static class PassagemProgram
    {
        public static void Execute()
        {
            IPassagem passagemUnitario = new TremUnitario();
            ((TremUnitario)passagemUnitario).SetPreco(5.00);

            IPassagem passagemGrupo = new TremGrupo();
            ((TremGrupo)passagemGrupo).SetPreco(4.00);
            ((TremGrupo)passagemGrupo).SetQtdPassagem(10);

            Cobrador cobradorUnitario = new Cobrador(passagemUnitario);
            Cobrador cobradorGrupo = new Cobrador(passagemGrupo);

            Console.WriteLine($"Valor a cobrar (Unitário): {cobradorUnitario.ValorACobrar:C}");
            Console.WriteLine($"Valor a cobrar (Grupo): {cobradorGrupo.ValorACobrar:C}");
        }
    }
}
