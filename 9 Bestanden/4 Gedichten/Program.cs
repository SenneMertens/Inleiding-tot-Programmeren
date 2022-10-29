using System.IO;


int aantalGedichten, keuze;
string menu;

aantalGedichten = 11;

PasSchermkleurenAan();
menu = StelMenuSamen(aantalGedichten);
keuze = LeesKeuze(menu, aantalGedichten);

while (keuze != 0)
{
    ToonGedicht(keuze);

    Console.WriteLine("Druk op enter om door te gaan");
    Console.ReadLine();

    keuze = LeesKeuze(menu, aantalGedichten);
}

Console.WriteLine("Druk op enter om af te sluiten");

static void ToonGedicht(int keuze)
{
    string bestandsnaam, uitvoer;

    bestandsnaam = $"gedicht-{keuze}.txt";
    uitvoer = string.Empty;

    if (! File.Exists(bestandsnaam))
    {
        uitvoer = $"Bestand \"{bestandsnaam}\" bestaat niet";
    }
    else
    {
        Console.Clear();
        DrukTitel($"Gedicht {keuze}");
        using (StreamReader reader = new StreamReader(bestandsnaam))
        {
            while (! reader.EndOfStream)
            {
                uitvoer += reader.ReadLine() + "\n";
            }
        }
    }

    Console.WriteLine(uitvoer);
}

static string StelMenuSamen(int aantalItems)
{
    string menu;

    menu = $"0. Stoppen";

    for (int i = 1; i <= aantalItems; i++)
    {
        menu += $"\n{i}. Gedicht {i}";
    }

    return menu;
}

static void DrukTitel(string titel)
{
    Console.WriteLine(titel);
    Console.WriteLine(new string('=', titel.Length));
}

static int LeesKeuze(string menu, int aantalKeuzes)
{
    string invoer;
    int keuze;

    Console.Clear();

    DrukTitel("Gedichten een wereld van ..");

    Console.WriteLine(menu);

    do
    {
        Console.Write("Maak je keuze: ");
        invoer = Console.ReadLine();
    } while (! int.TryParse(invoer, out keuze) || keuze < 0 || keuze > aantalKeuzes);

    return keuze;
}

static void PasSchermkleurenAan()
{
    Console.Title = "09 Bestanden - Oefening 04";
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.BackgroundColor = ConsoleColor.White;
    Console.Clear();
}