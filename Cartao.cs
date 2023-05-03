using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace passed_rod_project
{
    public abstract class Cartao : Pagamento
    {
        // variaveis
        public string? Bandeira { get; set; }
        public string? NumeroCartao { get; set; }
        public string? Titular { get; set; }
        public string? Cvv { get; set; }

        // metodos
        public abstract void Pagar();
        public string SalvarCartao()
        {
            Console.WriteLine($"Informe a bandeira do cartão: ");
            Bandeira = Console.ReadLine()!;

            Console.WriteLine($"Informe o número do cartão: ");
            NumeroCartao = Console.ReadLine()!;

            Console.WriteLine($"Informe o nome do titular do cartão: ");
            Titular = Console.ReadLine()!;

            Console.WriteLine($"Informe o código de segurança: ");
            Cvv = Console.ReadLine()!;

            return @$"
            INFORMAÇÕES CARTAO SALVO
            Bandeira: {Bandeira}
            Num: {NumeroCartao}
            Titular: {Titular}
            CVV: {Cvv}
            ";
        }
    }
}