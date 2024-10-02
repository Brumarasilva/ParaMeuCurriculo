// Formas de Pagamento

Console.WriteLine("Insira o valor: ");
if (double.TryParse(Console.ReadLine(), out double val) || val <= 0)
{
    Console.WriteLine("Digite a forma de pagamento: ");
    Console.WriteLine("Dinheiro");
    Console.WriteLine("Cartão de Crédito");
    Console.WriteLine("Cartão de Débito");
    Console.WriteLine("crédito parcelado");

    string pagamento = Console.ReadLine().ToLower();
    switch (pagamento)
    {
        case "dinheiro":
            Console.WriteLine($"O valor do pagamento será: {val - (val * 0.25)}");
            break;
        case "cartão de crédito":
            Console.WriteLine($"O valor do pagamento será: {val - (val * 0.15)}");
            break;
        case "cartão de débito":
            Console.WriteLine($"O valor do pagamenrto será: {val - (val * 0.20)}");
            break;
        case "crédito parcelado":
            Console.WriteLine($"O valor do pagamento será: {val}");
            break;
    }
}


