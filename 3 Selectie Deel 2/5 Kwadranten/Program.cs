int xCoördinaat, yCoördinaat;
string resultaat;

xCoördinaat = int.Parse(Console.ReadLine());
yCoördinaat = int.Parse(Console.ReadLine());

resultaat = "Dit punt ligt in het ";

switch (xCoördinaat)
{
    case < 0:
        switch (yCoördinaat)
        {
            case < 0:
                resultaat += "3de kwadrant";
                break;
            case 0:
                resultaat += "3de kwadrant";
                break;
            case > 0:
                resultaat += "2de kwadrant";
                break;
        }
        break;
    case 0:
        switch (yCoördinaat)
        {
            case < 0:
                resultaat += "4de kwadrant";
                break;
            case 0:
                resultaat += "midden";
                break;
            case > 0:
                resultaat += "2de kwadrant";
                break;
        }
        break;
    case > 0:
        switch (yCoördinaat)
        {
            case < 0:
                resultaat += "4de kwadrant";
                break;
            case 0:
                resultaat += "1ste kwadrant";
                break;
            case > 0:
                resultaat += "1ste kwadrant";
                break;
        }
        break;
}

Console.WriteLine($"{resultaat}");