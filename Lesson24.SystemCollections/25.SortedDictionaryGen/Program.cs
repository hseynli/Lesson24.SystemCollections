﻿var sortedDict = new SortedDictionary<string, int>();
sortedDict["One"] = 1;
sortedDict["Two"] = 2;
sortedDict["Three"] = 3;

foreach (KeyValuePair<string, int> i in sortedDict)
{
    Console.WriteLine(i);
}

// Delay.
Console.ReadKey();