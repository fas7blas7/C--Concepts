int pages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int hoursPerDay = pages / pagesPerHour;
int hoursToRead = hoursPerDay / days;

Console.WriteLine(hoursToRead);