double celsius, fahrenheit;

celsius = double.Parse(Console.ReadLine());

fahrenheit = (celsius * 9 / 5 + 32);

Console.WriteLine($"Fahrenheit: {fahrenheit:0.00}");