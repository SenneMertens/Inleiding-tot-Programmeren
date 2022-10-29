int getal;

getal = int.Parse(Console.ReadLine());

for (int i = getal; i >= 1; i--)
{
    Console.WriteLine($"{Math.Pow(i, 2)}");
}