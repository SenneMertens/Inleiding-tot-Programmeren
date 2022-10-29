int getal1, getal2, grootsteGetal, kleinsteGetal;

getal1 = int.Parse(Console.ReadLine());
getal2 = int.Parse(Console.ReadLine());

if (getal1 > getal2)
{
    grootsteGetal = getal1;
    kleinsteGetal = getal2;
}
else
{
    grootsteGetal = getal2;
    kleinsteGetal = getal1;
}

Console.WriteLine($"{grootsteGetal} - {kleinsteGetal} = {grootsteGetal - kleinsteGetal}");