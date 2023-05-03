using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace passed_rod_project
{
    public class Boleto : Pagamento
    {
        // metodos
        public void Registrar()
        {
            valorTotal = valor * 0.88f;

            Random codigoBarra = new Random();
            
            Console.WriteLine(@$"Valor a ser pago: {valorTotal.ToString("C")}");
            Console.WriteLine($"Data da compra: {data}");
            
            
            Console.WriteLine($"");
            Console.WriteLine(@$"||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine($"{codigoBarra.Next(99999)}. {codigoBarra.Next(99999)}. {codigoBarra.Next(999999)} {codigoBarra.Next(99999)}. {codigoBarra.Next(999999999)} {codigoBarra.Next(9)} {codigoBarra.Next(999999999)}");
            Console.WriteLine($"");
        }
    }


}