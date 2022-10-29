string woord, resultaat;

resultaat = string.Empty;

do
{
    Console.Write($"Geef een woord: ");
    woord = Console.ReadLine();
} while (string.IsNullOrEmpty(woord));

for (int i = 0; i < woord.Length; i++)
{
    if (i == 0)
    {
        resultaat += $"{woord.Substring(i, 1)}\n";
    }
    else
    {
        resultaat += $"{new string('_', i)}{woord.Substring(i, 1)}\n";
    }
}

for (int i = woord.Length - 1; i >= 0; i--)
{
    if (i != 0)
    {
        resultaat += $"{new string('_', i)}{woord.Substring(i, 1)}\n";
    }
    else
    {
        resultaat += $"{woord.Substring(i, 1)}";
    }
}

Console.WriteLine($"\n{resultaat}");