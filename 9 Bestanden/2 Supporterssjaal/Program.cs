using System.IO;

string bestandsnaam = Console.ReadLine();
BehandelBestand(bestandsnaam);

static void BehandelBestand(string bestandsnaam)
{
    if (File.Exists(bestandsnaam) == false)
    {
        Console.WriteLine($"{bestandsnaam} bestaat niet");
    }
    else
    {
        bool isBestandLeeg;
        isBestandLeeg = true;

        using (StreamReader lezer = new StreamReader(bestandsnaam))
        {
            while (! lezer.EndOfStream)
            {
                isBestandLeeg = false;
                string regel = lezer.ReadLine();
                BehandelRecord(regel);
            }
        }

        if (isBestandLeeg == true)
        {
            Console.WriteLine($"{bestandsnaam} bevat geen gegevens");
        }
    }
}

static void BehandelRecord(string record)
{
    int positie = record.IndexOf(';');
    string ploegnaam = record.Substring(0, positie);
    record = record.Substring(positie + 1);

    positie = record.IndexOf(';');
    string symbool1 = record.Substring(0, positie);
    record = record.Substring(positie + 1);

    positie = record.IndexOf(';');
    string symbool2 = record.Substring(0, positie);
    record = record.Substring(positie + 1);

    positie = record.IndexOf(';');
    int leng = int.Parse(record.Substring(0, positie));
    int breedte = int.Parse(record.Substring(positie + 1));

    DrukTitel(ploegnaam);
    DrukSjaal(new string(char.Parse(symbool1), breedte), new string(char.Parse(symbool2), breedte), leng);
}

static void DrukSjaal(string streep1, string streep2, int lengte)
{
    string lijn;

    lijn = string.Empty;

    for (int i = 1; i <= lengte; i++)
    {
        if (i % 2 == 0)
        {
            lijn += streep2;
        }
        else
        {
            lijn += streep1;
        }
        lijn += "\n";
    }

    Console.WriteLine(lijn);
}

static void DrukTitel(string ploeg)
{
    string titel = "Sjaal ";
    Console.WriteLine($"{titel} {ploeg}");
    Console.WriteLine($"{new string('*', titel.Length + ploeg.Length)}");
}