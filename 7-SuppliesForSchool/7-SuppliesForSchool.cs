int numberOfPackagesOfPens = int.Parse(Console.ReadLine());
int numberOfPackagesOfMarkers = int.Parse(Console.ReadLine());
int litersOfBoardCleaner =  int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());
double priceOfPackageOfPens = 5.80;
double priceOfPackageOfMarkers = 7.20;
double priceOfLiterOfBoardCleaner = 1.20;

double totalCost = numberOfPackagesOfPens * priceOfPackageOfPens + numberOfPackagesOfMarkers * priceOfPackageOfMarkers + litersOfBoardCleaner * priceOfLiterOfBoardCleaner;
double discountedTotalCost = totalCost - totalCost * discount / 100;

Console.WriteLine($"{discountedTotalCost:F3}");