using System.IO;

int laagsteScore, hoogsteScore;
double gemiddelde;

laagsteScore = 0;
hoogsteScore = 0;
gemiddelde = 0;

PasSchermkleurenAan();
DrukMenu();
int keuze = LeesGetal("Maak een keuze uit het menu: ", 1, 3);
int klas = LeesGetal("Kies een klas: ", 1, 6);
BerekenScores(klas, ref laagsteScore, ref hoogsteScore, ref gemiddelde);
ToonResultaat(keuze, laagsteScore, hoogsteScore, gemiddelde);

static void ToonResultaat(int keuze, int laagsteScore, int hoogsteScore, double gemiddelde)
{
    string resultaat = string.Empty;

    switch (keuze)
    {
        case 1:
            resultaat = $"Het gemiddelde is {gemiddelde}";
            break;
        case 2:
            resultaat = $"De hoogste score is {hoogsteScore}";
            break;
        case 3:
            resultaat = $"De laagste score is {laagsteScore}";
            break;
    }

    Console.WriteLine($"{resultaat}");
}

static void BerekenScores(int klas, ref int laagsteScore, ref int hoogsteScore, ref double gemiddelde)
{
    double totaal, aantalScores;

    totaal = 0;
    aantalScores = 0;

    using (StreamReader reader = new StreamReader($"studenten-{klas}.txt"))
    {
        while (!reader.EndOfStream)
        {
            int punt = int.Parse(reader.ReadLine());
            if (laagsteScore > punt)
            {
                laagsteScore = punt;
            }
            if (hoogsteScore < punt)
            {
                hoogsteScore = punt;
            }

            aantalScores++;
            totaal += punt;
        }
    }

    gemiddelde = totaal / aantalScores;
}

static int LeesGetal(string vraag, int min, int max)
{
    string invoer;
    int keuze;

    do
    {
        Console.Write($"{vraag} ({min} - {max}): ");
        invoer = Console.ReadLine();
    } while (!int.TryParse(invoer, out keuze) || keuze < min || keuze > max);

    return keuze;
}

static void DrukMenu()
{
    Console.WriteLine("Menu");

    using (StreamReader reader = new StreamReader("menu.txt"))
    {
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string nummer = line.Substring(0, 1);
            string optie = line.Substring(2);

            Console.WriteLine($"Voor {optie.ToLower()} kies {nummer}");
        }
    }
}

static void PasSchermkleurenAan()
{
    Console.Title = "09 Bestanden - Oefening 03";
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.BackgroundColor = ConsoleColor.White;
}