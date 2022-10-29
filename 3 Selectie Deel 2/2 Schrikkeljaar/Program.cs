int jaar;

jaar = int.Parse(Console.ReadLine());

switch (jaar)
{
    case <= 1582:
        {
            if (jaar % 4 == 0)
            {
                Console.WriteLine($"{jaar} is een schrikkeljaar");
            }
            else
            {
                Console.WriteLine($"{jaar} is geen schrikkeljaar");
            }
        }
        break;
    case > 1582:
        {
            if (jaar % 4000 == 0)
            {
                Console.WriteLine($"{jaar} is geen schrikkeljaar");
            }
            else if (jaar % 400 == 0)
            {
                Console.WriteLine($"{jaar} is een schrikkeljaar");
            }
            else if (jaar % 100 == 0)
            {
                Console.WriteLine($"{jaar} is geen schrikkeljaar");
            }
            else if (jaar % 4 == 0)
            {
                Console.WriteLine($"{jaar} is een schrikkeljaar");
            }
        }
        break;
}