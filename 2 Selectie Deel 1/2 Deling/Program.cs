double getal1, getal2;

getal1 = double.Parse(Console.ReadLine());
getal2 = double.Parse(Console.ReadLine());

if (getal2 != 0)
{
    Console.WriteLine($"{getal1} / {getal2} = {getal1 / getal2}");
}
else
{
    Console.WriteLine($"{getal1} is niet deelbaar door 0");
}