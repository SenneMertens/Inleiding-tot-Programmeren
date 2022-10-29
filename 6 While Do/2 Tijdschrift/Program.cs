string titel, voornaam, achternaam, input, resultaat;
int nummer;

resultaat = string.Empty;
titel = $"Opvragen Algemene Informatie";

Console.Write($"{titel}\n{new string('*', titel.Length)}\n");

do
{
    Console.Write($"Voornaam: ");
    voornaam = Console.ReadLine();
} while (string.IsNullOrEmpty(voornaam));

do
{
    Console.Write($"Achternaam: ");
    achternaam = Console.ReadLine();
} while (string.IsNullOrEmpty(achternaam));

Console.WriteLine();

do
{
    Console.Write($"Welke hobby {voornaam.ToLower()} {achternaam.ToUpper()}? ");
    input = Console.ReadLine();
} while (! int.TryParse(input, out nummer) || nummer < 1 || nummer > 8);

while (nummer >= 1 && nummer <= 7)
{
    resultaat += "Wij raden \"";

    switch (nummer)
    {
        case 1:
            resultaat += "Anna";
            break;
        case 2:
            resultaat += "Knippie";
            break;
        case 3:
            resultaat += "VTWonen";
            break;
        case 4:
            resultaat += "Voetbal International";
            break;
        case 5:
            resultaat += "Wandelen & Fietsen";
            break;
        case 6:
            resultaat += "Zoom NL";
            break;
        case 7:
            resultaat += "Runners";
            break;
    }

    resultaat += $"\" aan.\n";

    do
    {
        Console.Write($"Welke hobby {voornaam.ToLower()} {achternaam.ToUpper()}? ");
        input = Console.ReadLine();
    } while (!int.TryParse(input, out nummer) || nummer < 1 || nummer > 8);
}

if (resultaat == String.Empty)
{
    resultaat = $"Geen hobby gekozen";
}

Console.WriteLine($"{resultaat}");