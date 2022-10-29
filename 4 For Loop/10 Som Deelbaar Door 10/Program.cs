int getal1, getal2, som;

getal1 = int.Parse(Console.ReadLine());
getal2 = int.Parse(Console.ReadLine());

som = 0;

for (int i = getal1; i <= getal2; i++)
{
    if (i % 10 == 0)
    {
        som += i;
    }
}

Console.WriteLine($"Som: {som}");