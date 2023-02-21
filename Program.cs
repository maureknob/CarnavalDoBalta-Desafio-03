// See https://aka.ms/new-console-template for more information
Console.Write("Digite o valor do alcool: ");

double.TryParse(Console.ReadLine(), out double alcohol);

Console.Write("\nDigite o valor da gasolina: ");

double.TryParse(Console.ReadLine(), out double gas);

var result = Math.Floor((alcohol / gas) * 100);

if (result <= 72)
{
    Console.WriteLine($"Vantagem econômica de {result}% a favor do alcool.");
}
else
{
    Console.WriteLine("Use gasolina");
}
