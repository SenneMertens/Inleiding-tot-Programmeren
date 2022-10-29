string titel, woord;

do
{
    Console.Write($"Geef een woord: ");
    woord = Console.ReadLine();
} while (string.IsNullOrEmpty(woord));

Console.WriteLine($"{new string('*', woord.Length).PadLeft(28)}");