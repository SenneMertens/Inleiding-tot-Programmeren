int getal, som;

som = 0;

for (int i = 1; i <= 10; i++)
{
    getal = int.Parse(Console.ReadLine());
    som += getal;
}

Console.WriteLine($"Som: {som}");