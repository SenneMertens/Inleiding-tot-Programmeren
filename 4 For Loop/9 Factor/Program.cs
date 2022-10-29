int getal, som;

getal = int.Parse(Console.ReadLine());

som = 1;

for (int i = getal; i >= 1; i--)
{
    som *= i;
}

Console.WriteLine($"{som}");