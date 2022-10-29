string woord, woordOmgekeerd;

woordOmgekeerd = string.Empty;

do
{
    Console.Write($"Geef een woord: ");
    woord = Console.ReadLine();
} while (string.IsNullOrEmpty(woord));

for (int i = woord.Length - 1; i >= 0; i--)
{
    woordOmgekeerd += woord[i];
}

if (woord.ToLower() == woordOmgekeerd.ToLower())
{
    Console.WriteLine($"\n{woord} is een palindroom");
}
else
{
    Console.WriteLine($"\n{woord} is geen palindroom");
}