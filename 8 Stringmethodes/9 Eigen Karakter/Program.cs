string woord, woordMetTekens, teken;

woordMetTekens = string.Empty;

do
{
    Console.Write($"Geef een woord: ");
    woord = Console.ReadLine();
} while (string.IsNullOrEmpty(woord));

do
{
    Console.Write($"Teken: ");
    teken = Console.ReadLine();
} while (string.IsNullOrEmpty(teken) || teken.Length > 1);

for (int i = 0; i < woord.Length; i++)
{
    if (i == 0)
    {
        woordMetTekens += $"{woord.Substring(i, 1)}";
    }
    else
    {
        woordMetTekens += $"{teken}{woord.Substring(i, 1)}";
    }

}

Console.WriteLine($"Het nieuwe woord is {woordMetTekens}\n{new string('*', woordMetTekens.Length).PadLeft(35)}");