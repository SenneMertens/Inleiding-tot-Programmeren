int btwTarief;
double bedrag, btw, totaal;

btw = 0;

btwTarief = int.Parse(Console.ReadLine());
bedrag = double.Parse(Console.ReadLine());

if (btwTarief == 1)
{
    btw = 0;
}
else if (btwTarief == 2)
{
    btw = 6;
}
else if (btwTarief == 3)
{
    btw = 12;
}
else if (btwTarief == 4)
{
    btw = 21;
}

totaal = bedrag * (btw / 100 + 1);

Console.WriteLine($"{btw}, Totaal: {totaal:0.##}");