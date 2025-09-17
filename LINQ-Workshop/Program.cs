// See https://aka.ms/new-console-template for more information

//Firsts numbers even with LINQ
var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

//Second sum all numbers odden in list numbers
var sumOddNumbers = numbers.Where(n => n % 2 != 0).Sum();
Console.WriteLine("Sum of Odd Numbers: " + sumOddNumbers);

//Third order by descending numbers highest to 5
var topNumbersHighestTo5 = numbers.OrderByDescending(n => n).Take(5).ToList();
Console.WriteLine("Highest Numbers to 5: " + string.Join(", ", topNumbersHighestTo5));

// Fourth count numbers that lower o equal to 3 in list numbers
var countNumbersLowerOrEqualTo3 = numbers.Count(n => n <=3);
Console.WriteLine("Count of Numbers <= 3: " + countNumbersLowerOrEqualTo3);

// Fifth select each number multiply by 2
var multipliedBy2 = numbers.Select (n => n * 2).ToList();
Console.WriteLine("Numbers Multiplied by 2: " + string.Join(", ", multipliedBy2));