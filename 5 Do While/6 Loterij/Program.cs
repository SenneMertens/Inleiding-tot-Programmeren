int getal, antwoord, pogingen;
string input;

pogingen = 0;

do
{
    Console.Write($"Te zoeken getal: ");
    input = Console.ReadLine();
} while (!int.TryParse(input, out getal) || getal > 100);

Console.WriteLine($"Het te zoeken getal ligt tussen {getal - 5} en {getal + 5}\n");

do
{
    Console.Write($"Raad getal: ");
    input = Console.ReadLine();
    pogingen++;
} while (! int.TryParse(input, out antwoord) || antwoord != getal);

Console.WriteLine($"\nJe hebt {pogingen} keer geraden");