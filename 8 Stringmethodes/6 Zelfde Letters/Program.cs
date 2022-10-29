string woord1, woord2, resultaat, kortsteWoord;

resultaat = string.Empty;

do
{
    Console.Write($"Geef woord 1: ");
    woord1 = Console.ReadLine();
} while (string.IsNullOrEmpty(woord1));

do
{
    Console.Write($"Geef woord 2: ");
    woord2 = Console.ReadLine();
} while (string.IsNullOrEmpty(woord2));

if (woord1.Length <= woord2.Length)
{
    kortsteWoord = woord1;
}
else
{
    kortsteWoord = woord2;
}

for (int i = 0; i < kortsteWoord.Length; i++)
{
    if (woord1.ToLower().Substring(i, 1) == woord2.ToLower().Substring(i, 1))
    {
        resultaat += $"_";
    }
    else
    {
        resultaat += $" ";
    }
}

Console.WriteLine($"{resultaat.PadLeft(20)}");