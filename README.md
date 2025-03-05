# 🚀 C# Beginner Tasks Repository

Welcome to my **C# Coding Tasks** repository! This repo contains small yet essential C# programs that help build a strong foundation in programming. More tasks will be added over time! 🎯

---

## 📌 Table of Contents
1️⃣ [💲 Currency Converter](#-currency-converter)
2️⃣ [🧮 Basic Math Operations](#-basic-math-operations)
3️⃣ [🥦 Grocery Cost Calculator](#-grocery-cost-calculator)

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

🔔 **More tasks are coming soon!** Stay tuned for updates. 🎉

