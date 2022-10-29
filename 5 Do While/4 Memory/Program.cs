string titel, oplossing, antwoord, resultaat;
int pogingen;

titel = $"Bestudeer aandachtig!";
oplossing = $"Op de stoel ligt een zonnehoed en peperkoek";
pogingen = 0;
resultaat = $"Je had";

Console.Write($"{titel}\n{new string('*', titel.Length)}\n{oplossing}");
Console.ReadKey();
Console.Clear();
Console.WriteLine($"Geef de zin in!\n");

do
{
    pogingen++;
    Console.Write($"Poging {pogingen}: ");
    antwoord = Console.ReadLine();
} while (antwoord.ToLower() != oplossing.ToLower());

if (pogingen == 1)
{
    resultaat += $" {pogingen} poging nodig";
}
else
{
    resultaat += $" {pogingen} pogingen nodig";
}

Console.WriteLine($"{resultaat}");