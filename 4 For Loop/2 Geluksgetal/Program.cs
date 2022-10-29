string naam, resultaat;
int geluksgetal;

naam = Console.ReadLine();
geluksgetal = int.Parse(Console.ReadLine());

resultaat = $"{geluksgetal}";

for (int i = 1; i <= geluksgetal; i++)
{
    resultaat += $" {naam}";
}

Console.WriteLine($"{resultaat}");