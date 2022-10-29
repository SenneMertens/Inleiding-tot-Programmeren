int getal;
string resultaat;

getal = int.Parse(Console.ReadLine());

resultaat = "";

for (int i = 0; i <= 10; i++)
{
    resultaat += $"{getal} x {i} = {getal * i}\n";
}

Console.WriteLine($"{resultaat}");