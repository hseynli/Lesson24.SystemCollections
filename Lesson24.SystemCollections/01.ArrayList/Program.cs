using System.Collections;

var list = new ArrayList();

// Əlavə etmək.
string s = "Hello";
list.Add(s);
list.Add("hi");
list.Add(50);
list.Add(new object());

// Birdən çox elementin əlavə edilməsi
var anArray = new[] { "more", "or", "less" };
list.AddRange(anArray);

var anotherArray = new[] { new object(), new ArrayList() };
list.AddRange(anotherArray);

// Qeyd olunan aralığa yeni elementin əlavə edilməsi
list.Insert(3, "Hey All");

// Birdən çox elementin qeyd olunan aralığa əlavə edilməsi
var moreString = new[] { "goodnight", "see ya" };
list.InsertRange(4, moreString);

// İndeksator vasitəsilə qeyd olunan indeksdəki elementin yeni dəyər ilə əvəz edilməsi
list[3] = "Hey All 2";

// Elementin siyahıdan silinməsi
list.Add("Hello");
list.Remove("Hello");

// Qeyd olunan aralıqda elementin silinəsi
list.RemoveAt(0);

// Qeyd olunan aralıqda elementin toplu silinəsi
list.RemoveRange(0, 4);

string myString = "My String";

if (list.Contains(myString))
{
    int index = list.IndexOf(myString);
    list.RemoveAt(index);
}
else
{
    list.Clear();
}