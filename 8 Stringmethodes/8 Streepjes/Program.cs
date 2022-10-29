string woord, woordMetStreepjes;

woordMetStreepjes = string.Empty;

do
{
    Console.Write($"Geef een woord: ");
    woord = Console.ReadLine();
} while (string.IsNullOrEmpty(woord));

for (int i = 0; i < woord.Length; i++)
{
    if (i == 0)
    {
        woordMetStreepjes += $"{woord.Substring(i, 1)}";
    }
    else
    {
        woordMetStreepjes += $"-{woord.Substring(i, 1)}";
    }
    
}

Console.WriteLine($"Het nieuwe woord is {woordMetStreepjes}");