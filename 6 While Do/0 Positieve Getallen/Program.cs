int getal, som;
string input;

som = 0;

do
{
    input = Console.ReadLine();
} while (! int.TryParse(input, out getal));

while (getal > 0)
{
    som += getal;

    do
    {
        input = Console.ReadLine();
    } while (!int.TryParse(input, out getal));
}

Console.WriteLine($"Totaal: {som}");