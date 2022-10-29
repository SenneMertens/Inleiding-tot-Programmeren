using System.IO;

string bestandsnaam;
int som;

som = 0;

do
{
    Console.Write($"Bestandsnaam: ");
    bestandsnaam = Console.ReadLine();
} while (string.IsNullOrEmpty(bestandsnaam));

if (File.Exists(bestandsnaam))
{
    StreamReader teLezenBestand = new StreamReader(bestandsnaam);

    while (! teLezenBestand.EndOfStream)
    {
        int record;

        record = int.Parse(teLezenBestand.ReadLine());

        som += record;
    }

    teLezenBestand.Close();

    Console.WriteLine($"Som: {som}");
}
else
{
    Console.WriteLine($"{bestandsnaam} bestaat niet");
}