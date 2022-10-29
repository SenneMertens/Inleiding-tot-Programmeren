int getal1, getal2, getal3, gemiddelde;

getal1 = int.Parse(Console.ReadLine());
getal2 = int.Parse(Console.ReadLine());
getal3 = int.Parse(Console.ReadLine());

gemiddelde = (getal1 + getal2 + getal3) / 3;

if (gemiddelde >= 50)
{
    Console.WriteLine($"{gemiddelde}, geslaagd");
}
else
{
    Console.WriteLine($"{gemiddelde}, niet geslaagd");
}