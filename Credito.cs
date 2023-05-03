using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace passed_rod_project
{
    public class Credito : Cartao
    {
        float limite = 500;
        int parcelas;
        public override void Pagar()
        {
            // verificar se o limite atende
            // quantidade de parcelas
            //  a depender da quantidade de parcelas, temos um calculo do valor a ser pago
            // exibir o valor

            if (valor <= limite)
            {
                do
                {
                    Console.WriteLine($"Em quantas vezes deseja parcelar o valor?");
                    parcelas = int.Parse(Console.ReadLine()!);
                } while (parcelas > 12);

                if (parcelas <= 6)
                {
                    valorTotal = valor * 0.95f;
                }
                else
                {
                    valorTotal = valor * 0.92f;
                }
                float valorParcelas = valorTotal / parcelas;
                Console.WriteLine(@$"Compra de {valorTotal.ToString("C")} parcelada em {parcelas}x de {valorParcelas.ToString("C")} realizada com sucesso.
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