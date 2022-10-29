string evenement, naam, lijst, input;

do
{
    Console.Write($"Naam evenement: ");
    evenement = Console.ReadLine();
} while (String.IsNullOrEmpty(evenement));

do
{
    Console.Write($"Persoon Toevoegen: ");
    input = Console.ReadLine();
} while (String.IsNullOrEmpty(input) && (input.ToLower() != "ja" || input.ToLower() != "nee"));

if (input.ToLower() == "nee")
{
    lijst = $"\nEr zijn nog geen aanwezigen";
}
else
{
    lijst = $"\nAanwezigen:\n";

    do
    {
        Console.Write($"Naam Persoon: ");
        naam = Console.ReadLine();
    } while (String.IsNullOrEmpty(input));

    lijst += $"{naam}\n";
}

while (input.ToLower() != "nee")
{
    do
    {
        Console.Write($"Nog een persoon Toevoegen: ");
        input = Console.ReadLine();
    } while (String.IsNullOrEmpty(input) && (input.ToLower() != "ja" || input.ToLower() != "nee"));

    if (input.ToLower() == "ja")
    {
        do
        {
            Console.Write($"Naam Persoon: ");
            naam = Console.ReadLine();
        } while (String.IsNullOrEmpty(input));
        lijst += $"{naam}\n";
    }
}

Console.WriteLine($"{lijst}");