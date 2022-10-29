int getal1, getal2;
string input;

do
{
    Console.Write($"Eerste getal: ");
    input = Console.ReadLine();
} while (! int.TryParse(input, out getal1));

do
{
    Console.Write($"Tweede getal: ");
    input = Console.ReadLine();
} while (!int.TryParse(input, out getal2));

while (getal1 != getal2)
{
    if (getal1 > getal2)
    {
        getal1 -= getal2;
    }
    else
    {
        getal2 -= getal1;
    }
}

Console.WriteLine($"\nDe grootste gemeenschappelijke deler is {getal1}");