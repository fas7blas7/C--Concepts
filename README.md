# 🚀 C# Beginner Tasks Repository

Welcome to my **C# Coding Tasks** repository! This repo contains small yet essential C# programs that help build a strong foundation in programming. More tasks will be added over time! 🎯

---

## 📌 Table of Contents
1️⃣ [💲 Currency Converter](#-currency-converter)
2️⃣ [🧮 Basic Math Operations](#-basic-math-operations)
3️⃣ [🥦 Grocery Cost Calculator](#-grocery-cost-calculator)
4️⃣ [🛁 Tile Calculator](#-tile-calculator)
5️⃣ [🏦 Bank Deposit Interest](#-bank-deposit-interest)
6️⃣ [📖 Book Reading Time](#-book-reading-time)
7️⃣ [🖊️ School Supplies Cost](#-school-supplies-cost)

---

## 1️⃣ 💲 Currency Converter
**Task:** Convert dollars to euros.
```csharp
// Read dollar amount from user
double dollar = double.Parse(Console.ReadLine());

// Convert to euros (1 USD = 0.88 EUR)
double euro = dollar * 0.88;

// Print result with two decimal places
Console.WriteLine($"{euro:F2}");
```

---

## 2️⃣ 🧮 Basic Math Operations
**Task:** Perform addition, subtraction, multiplication, and division.
```csharp
// Read two numbers from user
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());

// Perform calculations
double sumResult = num1 + num2;
double subResult = num1 - num2;
double mulResult = num1 * num2;
double divResult = num1 / num2;

// Print formatted results
Console.WriteLine($"{num1:f2} + {num2:f2} = {sumResult:f2}");
Console.WriteLine($"{num1:f2} - {num2:f2} = {subResult:f2}");
Console.WriteLine($"{num1:f2} * {num2:f2} = {mulResult:f2}");
Console.WriteLine($"{num1:f2} / {num2:f2} = {divResult:f2}");
```

---

## 3️⃣ 🥦 Grocery Cost Calculator
**Task:** Calculate total cost of tomatoes and cucumbers.
```csharp
// Read prices and weights
double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoWeight = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberWeight = double.Parse(Console.ReadLine());

// Compute costs
double potatoCost = tomatoPrice * tomatoWeight;
double cucumberCost = cucumberPrice * cucumberWeight;
double totalCost = potatoCost + cucumberCost;

// Print the total cost
Console.WriteLine($"{totalCost:f2}");
```

---

## 4️⃣ 🛁 Tile Calculator
**Task:** Calculate how many tiles are needed for a bathroom.
```csharp
// Read bathroom and tile dimensions
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeigth = double.Parse(Console.ReadLine());

double bathroomArea = width * height;
double bathroomAreaTotalSurplus = bathroomArea * 1.1;
double tileArea = tileWidth * tileHeigth;
double tilesNeeded = bathroomAreaTotalSurplus / tileArea;

// Print rounded tiles needed
Console.WriteLine(Math.Round(tilesNeeded));
```

---

## 5️⃣ 🏦 Bank Deposit Interest
**Task:** Calculate the final deposit amount after interest.
```csharp
// Read deposit details
double deposit = double.Parse(Console.ReadLine());
int monthsTerm = int.Parse(Console.ReadLine());
double interestRate = double.Parse(Console.ReadLine());

double interestRateConverted = interestRate * 0.01;
double interest = deposit + monthsTerm * (deposit * interestRateConverted) / 12;

// Print the final amount
Console.WriteLine($"{interest:f2}");
```

---

## 6️⃣ 📖 Book Reading Time
**Task:** Calculate the required reading hours per day.
```csharp
// Read book details
int pages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int hoursPerDay = pages / pagesPerHour;
int hoursToRead = hoursPerDay / days;

// Print hours per day needed
Console.WriteLine(hoursToRead);
```

---

## 7️⃣ 🖊️ School Supplies Cost
**Task:** Calculate the total cost of school supplies after discount.
```csharp
// Read input values
int numberOfPackagesOfPens = int.Parse(Console.ReadLine());
int numberOfPackagesOfMarkers = int.Parse(Console.ReadLine());
int litersOfBoardCleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double priceOfPackageOfPens = 5.80;
double priceOfPackageOfMarkers = 7.20;
double priceOfLiterOfBoardCleaner = 1.20;

double totalCost = numberOfPackagesOfPens * priceOfPackageOfPens + numberOfPackagesOfMarkers * priceOfPackageOfMarkers + litersOfBoardCleaner * priceOfLiterOfBoardCleaner;
double discountedTotalCost = totalCost - totalCost * discount / 100;

// Print the final discounted total cost
Console.WriteLine($"{discountedTotalCost:F3}");
```

---
