using System.Collections;

var list = new ArrayList { 2, 3, 1 };

list.Sort(new DescendingComparer());

foreach (int item in list)
    Console.WriteLine(item);

// Delay.
Console.ReadKey();

public class DescendingComparer : IComparer
{
    // Reqistrı iqnor edərək iki obyektin bərabərliyini yoxlayır
    readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

    public int Compare(object x, object y)
    {
        // Əksdən başlayaraq sort edəcəkdir
        // Müqayisə üçün verilən obyektlər yerlərini dəyişəcəklər
        int result = comparer.Compare(y, x);

        //int result = (int)x - (int)y;

        return result;
    }
}