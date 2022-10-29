double prijs, btw;
string input, resultaat;

resultaat = string.Empty;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Artikel {i}");

    do
    {
        Console.Write($"Prijs (Exclusief BTW): ");
        input = Console.ReadLine();
    } while (! double.TryParse(input, out prijs) || prijs < 0);

    do
    {
        Console.Write($"BTW-percentage: ");
        input = Console.ReadLine();
    } while (! double.TryParse(input, out btw) || btw < 0);

    resultaat += $"Artikel {i}, Prijs inclusief BTW: {prijs * (btw / 100 + 1):0.00}\n";
}

Console.WriteLine($"{resultaat}");