string ploeg, symbool1, symbool2, sjaal;
int breedte, lengte;

sjaal = string.Empty;

PasSchermkleurenAan();
ploeg = LeesNaam(vraag: $"Welke ploeg? ", 4);
while (ploeg != $"*****")
{    
    DrukTitel(naam: ploeg);

    sjaal += $"\n{ploeg}\n";

    symbool1 = LeesSymbool(vraag: $"Symbool 1: ", vergelijkendSymbool: $"");
    symbool2 = LeesSymbool(vraag: $"Symbool 2: ", vergelijkendSymbool: symbool1);
    breedte = LeesGetal(vraagOnderdeel: $"breed", minimumWaarde: 2);
    lengte = LeesGetal(vraagOnderdeel: $"lang", minimumWaarde: 3);
    sjaal += MaakSjaal(symbool1: symbool1, symbool2: symbool2, breedte: breedte, lengte: lengte);
    ploeg = LeesNaam(vraag: $"\nNog een ploeg? ", 4);
}

if (sjaal != string.Empty)
{
    Console.WriteLine($"\n{sjaal}");
}
else
{
    Console.WriteLine($"\nGeen ploeg gekozen");
}

static void PasSchermkleurenAan()
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Title = $"7 Methodes - Oefening 2";
}

static string LeesNaam(string vraag, int lengte)
{
    string input;
    do
    {
        Console.Write($"{vraag}");
        input = Console.ReadLine();
    } while (string.IsNullOrEmpty(input) || input.Length < lengte);

    return input;
}

static void DrukTitel(string naam)
{
    string titel;

    titel = $"Supporterssjaal {naam}";

    Console.WriteLine($"{titel}\n{new string('*', titel.Length)}\n");
}

static string LeesSymbool(string vraag, string vergelijkendSymbool)
{
    string symbool;

    do
    {
        Console.Write($"{vraag}");
        symbool = Console.ReadLine();
    } while (string.IsNullOrEmpty(symbool) || symbool == vergelijkendSymbool);

    return symbool;
}

static int LeesGetal(string vraagOnderdeel, int minimumWaarde)
{
    string input;
    int waarde;

    do
    {
        Console.Write($"Hoe {vraagOnderdeel} moet de sjaal worden (Min. {minimumWaarde})? ");
        input = Console.ReadLine();
    } while (! int.TryParse(input, out waarde) || waarde < minimumWaarde);

    return waarde;
}

static string MaakSjaal(string symbool1, string symbool2, int breedte, int lengte)
{
    string sjaal;

    sjaal = string.Empty;

    for (int i = 1; i <= lengte; i++)
    {
        for (int j = 1; j <= breedte; j++)
        {
            if (i % 2 != 0)
            {
                sjaal += symbool1;
            }
            else
            {
                sjaal += symbool2;
            }
        }

        sjaal += $"\n";
    }

    return sjaal;
}