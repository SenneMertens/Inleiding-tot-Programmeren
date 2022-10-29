int getal1, getal2, getal3, middelsteNummer;

getal1 = int.Parse(Console.ReadLine());
getal2 = int.Parse(Console.ReadLine());
getal3 = int.Parse(Console.ReadLine());

if ((getal1 < getal2 && getal2 < getal3) || (getal3 < getal2 && getal2 < getal1))
{
    middelsteNummer = getal2;
}
else if ((getal2 < getal1 && getal1 < getal3) || (getal3 < getal1 && getal1 < getal2))
{
    middelsteNummer = getal1;
}
else
{
    middelsteNummer = getal3;
}

Console.WriteLine($"Middelste getal: {middelsteNummer}");