int getal1, getal2, getal3, cijfercode;
string lettercode;

getal1 = int.Parse(Console.ReadLine());
getal2 = int.Parse(Console.ReadLine());
getal3 = int.Parse(Console.ReadLine());
lettercode = Console.ReadLine();
cijfercode = int.Parse(Console.ReadLine());

switch (lettercode.ToUpper())
{
    case "A":
        switch (cijfercode)
        {
            case 1:
                Console.WriteLine($"{getal1} + {getal2} = {getal1 + getal2}");
                break;
            case 2:
                Console.WriteLine($"{getal2} + {getal3} = {getal2 + getal3}");
                break;
            case 3:
                Console.WriteLine($"{getal1} + {getal3} = {getal1 + getal3}");
                break;
        }
        break;
    case "B":
        switch (cijfercode)
        {
            case 1:
                Console.WriteLine($"{getal1} - {getal2} = {getal1 - getal2}");
                break;
            case 2:
                Console.WriteLine($"{getal2} - {getal3} = {getal2 - getal3}");
                break;
            case 3:
                Console.WriteLine($"{getal1} - {getal3} = {getal1 - getal3}");
                break;
        }
        break;
    default:
        Console.WriteLine($"Ongeldige invoer");
        break;
}