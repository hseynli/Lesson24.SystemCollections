﻿using System.Collections;

var sort = new SortedList();

sort["First"] = "1st";
sort["Second"] = "2nd";
sort["Third"] = "3rd";
sort["Fourth"] = "4th";
sort["fourth"] = "4th";
sort.Add("ten", "10th");

foreach (DictionaryEntry entry in sort)
{
    Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
}

// Delay.
Console.ReadKey();