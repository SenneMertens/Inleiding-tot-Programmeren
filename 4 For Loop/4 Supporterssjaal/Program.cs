string symbool1, symbool2, resultaat;
int lengte, breedte;

symbool1 = Console.ReadLine();
symbool2 = Console.ReadLine();
lengte = int.Parse(Console.ReadLine());
breedte = int.Parse(Console.ReadLine());

resultaat = "";

for (int i = 1; i <= lengte; i++)
{
    if (i % 2 != 0)
    {
        for (int j = 1; j <= breedte; j++)
        {
            resultaat += symbool1;
        }
    }
    else
    {
        for (int j = 1; j <= breedte; j++)
        {
            resultaat += symbool2;
        }
    }
    resultaat += "\n";
}

Console.WriteLine($"{resultaat}");