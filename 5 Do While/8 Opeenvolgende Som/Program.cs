int getal, nummer, som;
string input;

nummer = 0;
som = 0;

do
{
    Console.Write($"Geef een getal: ");
    input = Console.ReadLine();
} while (! int.TryParse(input, out getal) || getal < 0);

do
{
    nummer++;
    som += nummer;
} while (som < getal);

Console.WriteLine($"\nEr zijn {nummer} getallen nodig");