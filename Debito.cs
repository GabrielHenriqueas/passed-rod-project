using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace passed_rod_project
{
    public class Debito : Cartao
    {
        float saldo = 800;
        public override void Pagar()
        {
            if (valor <= saldo)
            {
                Console.WriteLine(@$"Compra de {valor.ToString("C")} paga com sucesso.
Data da compra: {data}
                ");
            }
            else
            {
                Console.WriteLine($"Saldo indisponível.");
            }
        }
    }
}