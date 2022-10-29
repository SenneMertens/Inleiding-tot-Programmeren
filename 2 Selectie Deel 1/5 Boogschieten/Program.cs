int pijl, punten;

pijl = int.Parse(Console.ReadLine());

punten = 0;

if (pijl == 1)
{
    punten = 0;
}
else if (pijl == 2)
{
    punten = 20;
}
else if (pijl == 3)
{
    punten = 50;
}
else if (pijl == 4)
{
    punten = 100;
}

Console.WriteLine($"{punten} punten");