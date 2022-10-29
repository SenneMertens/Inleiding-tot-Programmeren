int getal1, getal2;
string resultaat;

getal1 = int.Parse(Console.ReadLine());
getal2 = int.Parse(Console.ReadLine());

resultaat = $"{getal1}";

for (int i = getal1 - 1; i >= getal2; i--)
{
    resultaat += $" * {i}";
}

Console.WriteLine($"{resultaat}");