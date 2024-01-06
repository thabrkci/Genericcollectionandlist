using System;
using System.Collections.Generic;

Console.WriteLine("Generic Collection!");

// Creating a List of integers
List<int> valueList = new List<int>();
valueList.Add(23);  // Adding elements to the list
valueList.Add(5);
valueList.Add(12);
valueList.Add(18);
valueList.Add(1);

// Creating a List of strings
List<string> colors = new List<string>();
colors.Add("Red");
colors.Add("Blue");
colors.Add("Yellow");
colors.Add("Black");

// Displaying the count of elements in the lists
Console.WriteLine($"Number of elements in 'colors': {colors.Count}");
Console.WriteLine($"Number of elements in 'valueList': {valueList.Count}");

// Iterating through the 'colors' list using foreach
Console.WriteLine("Colors:");
foreach (var color in colors)
{
    Console.WriteLine(color);
}

// Iterating through the 'valueList' list using foreach
Console.WriteLine("Values:");
foreach (var value in valueList)
{
    Console.WriteLine(value);
}

// Using ForEach method to print elements in 'valueList'
valueList.ForEach(value => Console.WriteLine(value));

// Removing elements from the lists
valueList.Remove(1);
colors.Remove("Red");

// Displaying elements in 'valueList' after removal
valueList.ForEach(value => Console.WriteLine(value));

// Displaying elements in 'colors' after removal
colors.ForEach(color => Console.WriteLine(color));

// Searching for an element in 'valueList'
if (valueList.Contains(1))
    Console.WriteLine("1 is found in the list.");
else
    Console.WriteLine("1 is not found.");

// Searching for an element in 'colors'
Console.WriteLine($"Index of 'Black' in 'colors': {colors.BinarySearch("Black")}"); // Returns a negative value if not found

// Clearing the entire list
colors.Clear();
