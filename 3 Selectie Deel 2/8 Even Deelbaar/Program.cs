int getal;
string resultaat;

getal = int.Parse(Console.ReadLine());

if (getal % 2 == 0)
{
    if (getal % 5 == 0)
    {
        resultaat = "Even, deelbaar door 5";
    }
    else
    {
        resultaat = "Even, niet deelbaar door 5";
    }
}
else
{
    if (getal % 7 == 0)
    {
        resultaat = "Oneven, deelbaar door 7";
    }
    else
    {
        resultaat = "Oneven, niet deelbaar door 7";
    }
}

Console.WriteLine($"{resultaat}");