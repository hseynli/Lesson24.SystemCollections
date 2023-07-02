using System.Collections;

var list = new ArrayList();

list.Add(2);
list.Add(3);
list.Add(1);

// QuickSort
list.Sort();

foreach (int item in list)
{
    Console.WriteLine(item);
}

// Delay.
Console.ReadKey();