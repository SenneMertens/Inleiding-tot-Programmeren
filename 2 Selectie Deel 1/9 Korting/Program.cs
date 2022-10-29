double bedrag, korting;
int dag;

Console.Write($"Bedrag: ");
bedrag = double.Parse(Console.ReadLine());
Console.Write($"Dag: ");
dag = int.Parse(Console.ReadLine());

if (dag % 2 != 0)
{
    if (dag == 1 || dag == 3)
    {
        korting = 0.825;
    }
    else
    {
        korting = 0.8;
    }
}
else
{
    if (dag == 2)
    {
        korting = 0.875;
    }
    else
    {
        korting = 0.9;
    }
}

Console.WriteLine($"Totaal: {bedrag * korting:0.00}");