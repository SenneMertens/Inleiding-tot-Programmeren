int getal1, getal2;
string resultaat;

getal1 = int.Parse(Console.ReadLine());
getal2 = int.Parse(Console.ReadLine());

if (getal1 % 2 == 0)
{
    resultaat = $"{getal1}";
}
else
{
    resultaat = $"{getal1 - 1}";
}

for (int i = getal1 - 2; i >= getal2; i--)
{
    if (i % 2 == 0)
    {
        resultaat += $" * {i}";
    }
}

Console.WriteLine($"{resultaat}");