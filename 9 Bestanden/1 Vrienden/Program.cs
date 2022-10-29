using System.IO;

string bestandsnaam, lijst;

lijst = $"Vrienden:\n";

do
{
    Console.Write($"Bestandsnaam: ");
    bestandsnaam = Console.ReadLine();
} while (string.IsNullOrEmpty(bestandsnaam));

LeesBestand(bestandsnaam: bestandsnaam, overzicht: ref lijst);

static void LeesBestand(string bestandsnaam, ref string overzicht)
{
    StreamReader teLezenBestand = new StreamReader(bestandsnaam);

    if (File.Exists(bestandsnaam))
    {
        while (! teLezenBestand.EndOfStream)
        {
            string record;

            record = teLezenBestand.ReadLine();

            overzicht += $"{record}\n";
        }

        teLezenBestand.Close();

        if (overzicht == $"Vrienden:\n")
        {
            overzicht = $"Geen vrienden";
        }
    }
    else
    {
        overzicht = $"Bestand bestaat niet";
    }

    Console.WriteLine($"{overzicht}");
}