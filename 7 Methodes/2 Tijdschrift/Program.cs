string resultaat, voornaam, achternaam;
int keuze;

resultaat = string.Empty;

PasSchermkleurenAan();
DrukTitel();
voornaam = LeesNaam(vraag: $"Voornaam: ");
achternaam = LeesNaam(vraag: $"Achternaam: ");
keuze = LeesKeuze($"Welke hobby {achternaam.ToLower()} {voornaam.ToUpper()}? ");

while (keuze != 8)
{
    resultaat += BepaalSuggestie(keuze: keuze);
    keuze = LeesKeuze($"Nog een hobby {achternaam.ToLower()} {voornaam.ToUpper()}? ");
}

if (resultaat == string.Empty)
{
    Console.WriteLine($"\nGeen hobby gekozen");
}
else
{
    Console.WriteLine($"\n{resultaat}");
}

static void PasSchermkleurenAan()
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Title = $"7 Methodes - Oefening 2";
}

static void DrukTitel()
{
    string titel;

    titel = $"Opvragen algemene informatie";

    Console.WriteLine($"{titel}\n{new string('*', titel.Length)}\n");
}

static string LeesNaam(string vraag)
{
    string input;

    do
    {
        Console.Write($"{vraag}");
        input = Console.ReadLine();
    } while (string.IsNullOrEmpty(input));

    return input;
}

static int LeesKeuze(string vraag)
{
    string input;
    int keuze;

    do
    {
        Console.Write($"{vraag}");
        input = Console.ReadLine();
    } while (!int.TryParse(input, out keuze) && (keuze < 1 || keuze > 8));

    return keuze;
}

static string BepaalSuggestie(int keuze)
{
    string magazine;

    magazine = $"Wij raden \"";

    switch (keuze)
    {
        case 1:
            magazine += $"Anna";
            break;
        case 2:
            magazine += $"Knippie";
            break;
        case 3:
            magazine += $"VTWonen";
            break;
        case 4:
            magazine += $"Voetbal International";
            break;
        case 5:
            magazine += $"Wandelen & Fietsen";
            break;
        case 6:
            magazine += $"Zoom NL";
            break;
        case 7:
            magazine += $"Runners";
            break;
    }

    magazine += $"\" aan.\n";
    return magazine;
}