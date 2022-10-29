int getal;
string dag;

getal = int.Parse(Console.ReadLine());

switch (getal)
{
    case 1:
        dag = "Maandag";
        break;
    case 2:
        dag = "Dinsdag";
        break;
    case 3:
        dag = "Woensdag";
        break;
    case 4:
        dag = "Donderdag";
        break;
    case 5:
        dag = "Vrijdag";
        break;
    case 6:
        dag = "Zaterdag";
        break;
    case 7:
        dag = "Zondag";
        break;
    default:
        dag = "Foutieve invoer";
        break;
}

Console.WriteLine($"{dag}");