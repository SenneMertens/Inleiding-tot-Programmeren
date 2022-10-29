using System.IO;

PasSchermkleurenAan();

string bestandsnaam, uitvoer;

bestandsnaam = Console.ReadLine();

if (ControleerBestand(bestandsnaam))
{
    int correcteAntwoorden = BehandelBestand(bestandsnaam);
    uitvoer = $"Je scoorde {correcteAntwoorden} op 10";
}
else
{
    uitvoer = $"{bestandsnaam} bestaat niet";
}

Console.WriteLine(uitvoer);

static int BehandelBestand(string bestandsnaam)
{
    int correcteAntwoorden;

    correcteAntwoorden = 0;

    using (StreamReader reader = new StreamReader(bestandsnaam))
    {
        while (!reader.EndOfStream)
        {
            string record = reader.ReadLine();
            int oplossing = ToonOpgave(record);
            string antwoord = Console.ReadLine();
            BepaalJuistOfFout(oplossing, antwoord, ref correcteAntwoorden);
        }
    }

    return correcteAntwoorden;
}

static bool ControleerBestand(string bestandsnaam)
{
    return File.Exists(bestandsnaam);
}

static void BepaalJuistOfFout(int oplossing, string antwoord, ref int correcteAntwoorden)
{
    if (int.TryParse(antwoord, out int getalAntwoord))
    {
        if (getalAntwoord == oplossing)
        {
            correcteAntwoorden++;
        }    
    }
}

static int ToonOpgave(string record)
{
    string bewerkingsCode = record.Substring(0, 1);
    int positie1 = record.IndexOf(";");
    int positie2 = record.IndexOf(";", positie1 + 1);
    int getal1 = int.Parse(record.Substring(positie1 + 1, positie2 - positie1 - 1));
    int getal2 = int.Parse(record.Substring(positie2 + 1));

    Console.Write($"{getal1} {bewerkingsCode} {getal2} = ");

    return bewerkingsCode switch
    {
        "+" => getal1 + getal2,
        "-" => getal1 - getal2,
        "*" => getal1 * getal2,
        "/" => getal1 / getal2,
        _ => 0,
    };
}

static void PasSchermkleurenAan()
{
    Console.Title = "09 Bestanden - Oefening 05";
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.BackgroundColor = ConsoleColor.White;
}