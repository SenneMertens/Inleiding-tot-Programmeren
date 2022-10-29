int pijl, score;
string input;

score = 0;

for (int i = 1; i <= 3; i++)
{
    do
    {
        Console.WriteLine($"Pijl {i}\n");
        Console.Write($"Waar? ");
        input = Console.ReadLine();
        
        if (i != 3)
        {
            Console.Clear();
        }

    } while (! int.TryParse(input, out pijl) || pijl < 1 || pijl > 5);

    switch (pijl)
    {
        case 1:
            score += 0;
            break;
        case 2:
            score += 20;
            break;
        case 3:
            score += 50;
            break;
        case 4:
            score += 100;
            break;
    }
}

Console.WriteLine($"\nU hebt {score} punten behaald");