int getal1, getal2, getal3;
string lettercode;

getal1 = int.Parse(Console.ReadLine());
getal2 = int.Parse(Console.ReadLine());
getal3 = int.Parse(Console.ReadLine());
lettercode = Console.ReadLine();

switch (lettercode.ToUpper())
{
    case "A":
        {
            Console.WriteLine($"Som: {getal1 + getal2 + getal3}");
        }
        break;
    case "B":
        {
            Console.WriteLine($"Product: {getal1 * getal3}");
        }
        break;
    case "C":
        {
            Console.WriteLine($"Verschil: {getal3 - getal2}");
        }
        break;
    case "D":
        {
            if (getal1 > 0)
            {
                Console.WriteLine($"{Math.Pow(getal1, 2)}");
            }
            else
            {
                Console.WriteLine($"Foutieve invoer");
            }
        }
        break;
    default:
        {
            Console.WriteLine($"{Math.Max(Math.Max(getal1, getal2), getal3)}");
        }
        break;
}