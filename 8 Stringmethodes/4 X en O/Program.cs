string woord, nieuwWoord;

do
{
    Console.Write($"Geef een woord: ");
    woord = Console.ReadLine();
} while (string.IsNullOrEmpty(woord));

nieuwWoord = woord.ToLower().Replace('o', 'x');

Console.WriteLine($"\nHet nieuwe woord is: {nieuwWoord}");