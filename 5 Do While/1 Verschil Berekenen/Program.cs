int getal1, getal2;
string input;

do
{
    Console.Write($"1ste getal: ");
    input = Console.ReadLine();
} while (! int.TryParse(input, out getal1));

do
{
    Console.Write($"2de getal: ");
    input = Console.ReadLine();
} while (!int.TryParse(input, out getal2));

if (getal1 > getal2)
{
    Console.WriteLine($"{getal1} - {getal2} = {getal1 - getal2}");
}
else
{
    Console.WriteLine($"{getal2} - {getal1} = {getal2 - getal1}");
}