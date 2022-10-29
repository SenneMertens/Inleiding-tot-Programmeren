string titel, ploeg, symbool1, symbool2, resultaat, input;
int lengte, breedte;

resultaat = string.Empty;

do
{
    Console.Write($"Welke ploeg? ");
    ploeg = Console.ReadLine();
} while (string.IsNullOrEmpty(ploeg) || ploeg.Length < 5);

while (ploeg != "*****")
{
    titel = $"\nSupporterssjaal {ploeg}";

    Console.WriteLine($"{titel}\n{new string('*', titel.Length)}");

    do
    {
        Console.Write($"Symbool 1: ");
        symbool1 = Console.ReadLine();
    } while(string.IsNullOrEmpty(symbool1) || symbool1.Length != 1);

    do
    {
        Console.Write($"Symbool 2: ");
        symbool2 = Console.ReadLine();
    } while (string.IsNullOrEmpty(symbool2) || symbool2.Length != 1);

    do
    {
        Console.Write($"Lengte sjaal (Min 4): ");
        input = Console.ReadLine();
    } while (! int.TryParse(input, out lengte) || lengte < 4);

    do
    {
        Console.Write($"Breedte sjaal (Min 2): ");
        input = Console.ReadLine();
    } while (!int.TryParse(input, out breedte) || breedte < 2);

    for (int i = 1; i <= lengte; i++)
    {
        if (i % 2 != 0)
        {
            for (int j = 1; j <= breedte; j++)
            {
                resultaat += symbool1;
            }
        }
        else
        {
            for (int j = 1; j <= breedte; j++)
            {
                resultaat += symbool2;
            }
        }
        resultaat += $"\n";
    }

    do
    {
        Console.Write($"Nog een ploeg toevoegen? ");
        ploeg = Console.ReadLine();
    } while (string.IsNullOrEmpty(ploeg) || ploeg.Length < 5);
}

Console.WriteLine($"\n{resultaat}");