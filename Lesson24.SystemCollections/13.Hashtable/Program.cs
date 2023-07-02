using System.Collections;

var duplicates = new Hashtable();

var key1 = new Fish("Herring");
var key2 = new Fish("Herring");

duplicates[key1] = "Hello";
duplicates[key2] = "Hello2";


// 2 obyekt, çünki hər bir obyektin ayrı hash-kodu var
Console.WriteLine(duplicates.Count);

// Delay.
Console.ReadKey();

public class Fish
{
    public string name;

    public Fish(string name)
    {
        this.name = name;
    }
}