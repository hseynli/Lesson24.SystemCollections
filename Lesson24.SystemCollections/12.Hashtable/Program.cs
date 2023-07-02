using System.Collections;

var duplicates = new Hashtable();

duplicates["First"] = "1st";
duplicates["First"] = "the first";

Console.WriteLine(duplicates.Count);

// Delay.
Console.ReadKey();