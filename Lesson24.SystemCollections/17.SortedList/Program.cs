using System.Collections;

var sort = new SortedList(new DescendingComparer());

sort["First"] = "1st";
sort["Second"] = "2nd";
sort["Third"] = "3rd";
sort["Fourth"] = "4th";
sort["fourth"] = "44th";

foreach (DictionaryEntry entry in sort)
{
    Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
}

// Delay.
Console.ReadKey();

public class DescendingComparer : IComparer
{
    CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

    public int Compare(object x, object y)
    {
        // Əksinə sort eləmək üçün
        int result = comparer.Compare(y, x);
        return result;
    }
}