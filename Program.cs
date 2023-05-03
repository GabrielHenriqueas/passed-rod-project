using passed_rod_project;

Pagamento p = new Pagamento();
Credito c = new Credito();
Debito d = new Debito();
Boleto b = new Boleto();

string opcao;
do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($@"
============================================
Escolha a sua forma de pagamento:
[1] - Cartão de crédito.
[2] - Cartão de débito.
[3] - Boleto.
[0] - Cancelar operação.
=============================================
");
    Console.ResetColor();
    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "0":
            p.Cancelar();
            break;
        case "1":
            Console.WriteLine($"Informe o valor da compra: ");
            c.valor = int.Parse(Console.ReadLine()!);
            c.SalvarCartao();
            c.Pagar();
            break;
        case "2":
            Console.WriteLine($"Informe o valor da compra: ");
            d.valor = int.Parse(Console.ReadLine()!);
            d.SalvarCartao();
            d.Pagar();
            break;
        case "3":
            Console.WriteLine($"Informe o valor da compra: ");
            b.valor = int.Parse(Console.ReadLine()!);
            b.Registrar();
            b.Cancelar();
            break;
        default:
            Console.WriteLine($"Opção inválida.");
            break;
    }
} while (opcao != "0");
