Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("*".PadLeft(19, '*'));
Console.WriteLine("Formas de Pagamento");
Console.WriteLine("*".PadLeft(19, '*'));
Console.ResetColor();

returnone:
Console.WriteLine("Insira o valor: ");//Pedindo o Valor para o Desconto
if (double.TryParse(Console.ReadLine(), out double val) || val > 0)//Tentando converter o valor inserido pelo usuário para um número real. Se a tentativa de conversão for bem sucedida ele continuará o código. Senão retornará uma mensagem de erro e pedirá o usuário para digitar novamente
{
returntwo:
    Console.WriteLine("Digite a forma de pagamento: ");//Pedindo ao usuário para escolher um dos metódos de pagamento disponiveis
    Console.WriteLine("Dinheiro");
    Console.WriteLine("Cartão de Crédito");
    Console.WriteLine("Cartão de Débito");
    Console.WriteLine("crédito parcelado");

    string pagamento = Console.ReadLine().ToLower();//Ler a forma de pagamento inserida pelo usuário, convertendo tudo para minúsculas

    switch (pagamento)//Escolhendo o cálculo do pagamento dependendo da forma de pagamento escolhida pelo usuário
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
        default:
            Console.WriteLine("Forma de Pagamento inválida");
            goto returntwo;
    }

}
else
{
    Console.WriteLine("Valor Inválido");//Caso digite um valor inválido como uma palavra ou letra ou número menor igual a zero
    goto returnone;
}




