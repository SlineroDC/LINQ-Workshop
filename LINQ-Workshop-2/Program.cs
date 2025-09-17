// See https://aka.ms/new-console-template for more information

// exercise 2 
var names = new List<string> {"Bob", "Charlie Wonka David Perceval", "David","Eve", "Alice", "Alan", "Andrew"};

//  Order names alphabetically
var orderedNames = names.OrderBy(n => n).ToList();
Console.WriteLine("Ordered Names: " + string.Join(", ", orderedNames));

// Select names in list names that start with letter 'A'
var selectNamesWhichA = names.Where(n=> n.StartsWith("A")).ToList();
Console.WriteLine("Names staring which A: "  + string.Join(", ", selectNamesWhichA));

// Count how many names have lenght more five
var namesHighest5 = names.Count(n => n.Length > 5);
Console.WriteLine("Highest 5: " + string.Join(", ", namesHighest5));

//Here are a couple of ways to concatenate all the names in a list into a single string separated by spaces

var namesConcatenate = string.Join(" ", names);
Console.WriteLine("Names concatenate: " + namesConcatenate);

// Search and view the name highest in the list

var nameHighest = names.OrderByDescending(n => n.Length).First();
Console.WriteLine("Highest name is: " + nameHighest);