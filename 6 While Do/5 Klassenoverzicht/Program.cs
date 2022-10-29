string naam, resultaat, input;
double score, aantalStudenten, totaalPunten;

resultaat = string.Empty;
aantalStudenten = 0;
totaalPunten = 0;

Console.Write($"Naam: ");
naam = Console.ReadLine();

while (naam != string.Empty)
{
    do
    {
        Console.Write($"Score: ");
        input = Console.ReadLine();
    } while (!double.TryParse(input, out score));

    aantalStudenten++;
    totaalPunten += score;

    resultaat += $"\n{naam} ({score})";

    Console.Write($"Naam: ");
    naam = Console.ReadLine();
}

if (resultaat == string.Empty)
{
    resultaat = $"Geen aanwezigen";
}
else
{
    resultaat += $"\nGemiddelde {totaalPunten / aantalStudenten:0.##}";
}

Console.WriteLine($"{resultaat}");