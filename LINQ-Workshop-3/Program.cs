// See https://aka.ms/new-console-template for more information

// Exercise 3

var words = new List<string> { "blueberry","apple", "banana", "cherry", "date", "elderberry" };

// Check if all the words in the words list are more than 3 characters.

var checkWords = words.Where(w => w.Length >3).ToList();
Console.WriteLine("Check words: " + string.Join(", ", checkWords));

//Find and display the first word in the words list that begins with the letter 'b'.
var findB = words.FirstOrDefault(w => w.StartsWith('b'));
Console.WriteLine("Find words: " + string.Join(", ", findB));

//Count how many words in the words list contain the letter 'e'.
var countHowWords = words.Count(w => w.Contains('e'));
Console.WriteLine("Count how words with contain 'e': " + countHowWords);

// Select all the words in the words list and convert them to uppercase.
var convertUppercase = words.ConvertAll(w => w.ToUpper());
Console.WriteLine("Converting uppercase words: " + string.Join(", ", convertUppercase));

//Check if any words in the words list end with the letter 'y'.
var checkIfEndY = words.Where(w => w.EndsWith('y')).ToList();
Console.WriteLine("Check if end 'y' words: " + string.Join(", ", checkIfEndY));
