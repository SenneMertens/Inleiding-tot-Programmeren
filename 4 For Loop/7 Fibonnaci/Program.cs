int getal1, getal2, som;

getal1 = int.Parse(Console.ReadLine());


getal2 = getal1 + 1;

Console.WriteLine($"{getal1}\n{getal2}");

for (int i = 2; i <= 10; i++)
{
    som = getal1 + getal2;
    Console.WriteLine($"{som}");
    getal1 = getal2;
    getal2 = som;
}