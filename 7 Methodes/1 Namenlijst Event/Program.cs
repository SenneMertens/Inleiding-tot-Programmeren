string evenement, naam, lijst, input;

lijst = $"\nAanwezigen:\n";

PasSchermkleurenAan();
evenement = LeesEvenement(vraag: "Naam evenement: ");
input = JaNeeInlezen();

while (input.ToLower() == "ja")
{
    lijst += PersoonToevoegen();
    input = JaNeeInlezen();
}

OverzichtAfdrukken(overzicht: lijst);

static void PasSchermkleurenAan()
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Title = $"7 Methodes - Oefening 1";
}

static string LeesEvenement(string vraag)
{
    string input;

    do
    {
        Console.Write($"{vraag}");
        input = Console.ReadLine();
    } while (string.IsNullOrEmpty(input));

    return input;
}

static string JaNeeInlezen()
{
    string input;

    do
    {
        Console.Write($"Persoon toevoegen? ");
        input = Console.ReadLine();
    } while (string.IsNullOrEmpty(input) && (input.ToLower() != "ja" || input.ToLower() != "nee"));

    return input;
}

static string PersoonToevoegen()
{
    string antwoord, input;

    do
    {
        Console.Write($"Naam persoon: ");
        input = Console.ReadLine();
    } while (string.IsNullOrEmpty(input));

    return $"{input}\n";
}

static void OverzichtAfdrukken(string overzicht)
{
    if (overzicht == "\nAanwezigen:\n")
    {
        Console.WriteLine($"\nEr zijn nog geen aanwezigen");
    }
    else
    {
        Console.WriteLine($"{overzicht}");
    }
}