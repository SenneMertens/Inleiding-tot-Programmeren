int getal1, getal2, getal3, getal4, kleinsteGetal;

getal1 = int.Parse(Console.ReadLine());
kleinsteGetal = getal1;

getal2 = int.Parse(Console.ReadLine());
if (getal2 < kleinsteGetal)
{
    kleinsteGetal = getal2;
}

getal3 = int.Parse(Console.ReadLine());
if (getal3 < kleinsteGetal)
{
    kleinsteGetal = getal3;
}

getal4 = int.Parse(Console.ReadLine());
if (getal4 < kleinsteGetal)
{
    kleinsteGetal = getal4;
}

Console.WriteLine($"Kleinste getal: {kleinsteGetal}");