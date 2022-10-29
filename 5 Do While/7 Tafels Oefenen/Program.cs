int getal, antwoord, score;
string input;

score = 0;

do
{
    Console.Write($"Geef de tafel in: ");
    input = Console.ReadLine();
} while (! int.TryParse(input, out getal));

for (int i = 0; i <= 10; i++)
{
    do
    {
        Console.Write($"{getal} x {i} = ");
        input = Console.ReadLine();
    } while (! int.TryParse(input, out antwoord));

    if (antwoord == getal * i)
    {
        score++;
    }
}

Console.WriteLine($"\nU heeft {score}/10 behaald");