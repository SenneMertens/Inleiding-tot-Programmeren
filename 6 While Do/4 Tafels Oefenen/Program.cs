string input, resultaat;
int getal;

resultaat = string.Empty;

do
{
    Console.Write($"Tafel: ");
    input = Console.ReadLine();
} while (! int.TryParse(input, out getal));

while (getal != 0)
{
    for (int i = 1; i <= 10; i++)
    {
        resultaat += $"\n{getal} x {i} = {getal * i}";
    }

    resultaat += $"\n";

    do
    {
        Console.Write($"Tafel: ");
        input = Console.ReadLine();
    } while (!int.TryParse(input, out getal));
}

Console.WriteLine($"{resultaat}");