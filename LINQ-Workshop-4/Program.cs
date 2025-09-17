// See https://aka.ms/new-console-template for more information

// Exercise 4

var data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9,20};
var moreData = new List<int> { 10, 12, 15, 11, 14, 13 };

// Combine and sort the data and moreData lists in ascending order.
var combined = data.Concat(moreData);
var orderedData = combined.OrderBy(w => w).ToList();
Console.WriteLine("Ordered data: " + string.Join(", ", orderedData));

// Calculate the sum of all even numbers in the data list.

var sumEvenListData = data.Where(d =>d % 2 == 0).Sum();
Console.WriteLine("Sum of even list: " + string.Join(", ", sumEvenListData));

//Find the largest number in the data list.
var largestNumber = data.OrderByDescending(d => d).First();
Console.WriteLine("Largest: " + largestNumber);

//Join the data and moreData lists, eliminating duplicate elements.
var joinData = data.Union(moreData);
Console.WriteLine("Joining data: " + string.Join(", ", joinData));

// Calculate the average of the moreData list and select the numbers in data that are
// greater than that average.

var averageData = moreData.Average();
Console.WriteLine("Average: " + averageData);
var whereGreaterThanData = data.Where(d=>d> averageData);
Console.WriteLine("Where greater than average data: " + string.Join(", ", whereGreaterThanData));

// Count how many numbers in the moreData list are prime numbers (I recommend creating
// a separate function that validates whether the number is prime or not, then that works
// pass it to the appropriate LINQ method).

var sumOdenListData = moreData.Count(d => d % 2 != 0);
Console.WriteLine("Sum of oden list: " + string.Join(", ", sumOdenListData));