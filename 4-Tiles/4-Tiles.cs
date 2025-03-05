double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeigth = double.Parse(Console.ReadLine());
double bathroomArea = width * height;
double bathroomAreaTotalSurplus= bathroomArea *= 1.1;
double tileArea = tileWidth * tileHeigth;
double tilesNeeded = bathroomAreaTotalSurplus / tileArea;

Console.WriteLine(Math.Round(tilesNeeded));