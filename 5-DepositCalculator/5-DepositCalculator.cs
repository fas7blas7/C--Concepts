double deposit = double.Parse(Console.ReadLine());
int monthsTerm = int.Parse(Console.ReadLine());
double interestRate = double.Parse(Console.ReadLine());
double interestRateConverted = interestRate *= 0.01;
double interest = deposit + monthsTerm * (deposit * interestRateConverted) / 12;
Console.WriteLine($"{interest:f2}");