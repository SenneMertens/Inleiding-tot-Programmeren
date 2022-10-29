int getal;
string resultaat;

getal = int.Parse(Console.ReadLine());

resultaat = "";

for (int i = 1; i <= 10; i++)
{
    resultaat += $"{getal + i}\n";
}

Console.WriteLine($"{resultaat}");