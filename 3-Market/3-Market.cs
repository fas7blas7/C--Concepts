double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoWeight = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberWeight = double.Parse(Console.ReadLine());

double potatoCost = tomatoPrice * tomatoWeight;
double cucumberCost = cucumberPrice * cucumberWeight;
double totalCost = potatoCost + cucumberCost;

Console.WriteLine($"{totalCost:f2}");