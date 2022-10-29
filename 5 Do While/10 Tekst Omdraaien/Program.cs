string input, resultaat;

resultaat = string.Empty;

do
{
    do
    {
        input = Console.ReadLine();
    } while (string.IsNullOrEmpty(input));

    resultaat += resultaat.Insert(0, input);
} while (input.ToLower() != "stop");

Console.WriteLine($"{resultaat}");