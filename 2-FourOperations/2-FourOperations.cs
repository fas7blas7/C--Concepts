double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());

double sumResult = num1 + num2;
double subResult = num1 - num2;
double mulResult = num1 * num2;
double divResult = num1 / num2;

Console.WriteLine($"{num1:f2} + {num2:f2} = {sumResult:f2}");
Console.WriteLine($"{num1:f2} - {num2:f2} = {subResult:f2}");
Console.WriteLine($"{num1:f2} * {num2:f2} = {mulResult:f2}");
Console.WriteLine($"{num1:f2} / {num2:f2} = {divResult:f2}");