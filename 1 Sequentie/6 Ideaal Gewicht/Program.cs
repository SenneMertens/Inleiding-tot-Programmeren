double lengte, polsomtrek, ideaalGewicht;

lengte = double.Parse(Console.ReadLine());
polsomtrek = double.Parse(Console.ReadLine());

ideaalGewicht = (lengte + 4 * polsomtrek - 100) / 2;

Console.WriteLine($"Ideaal gewicht: {ideaalGewicht:0} kilo");