﻿using System.Collections;

// Reqistrdan asılı olmayan kolleksiya yaradırıq
var dehash = new Hashtable(new InsensitiveComparer());

dehash["First"] = "1st";
dehash["Second"] = "2nd";
dehash["Third"] = "3rd";
dehash["Fourth"] = "4th";
dehash["fourth"] = "4TH!!!";

Console.WriteLine(dehash.Count);

// Delay.
Console.ReadKey();


public class InsensitiveComparer : IEqualityComparer
{
    readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

    public int GetHashCode(object obj)
    {
        return obj.ToString().ToLowerInvariant().GetHashCode();
    }

    public new bool Equals(object x, object y)
    {
        return comparer.Compare(x, y) == 0;
    }
}