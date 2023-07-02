using System.Collections.Specialized;
using System.Collections;

//ListDictionary - az sayda elementləri saxlamaq üçün uyğun gəlir, çünki adi massiv əsasında qurulub

var emailLookup = new ListDictionary();

emailLookup["sbishop@contoso.com"] = "Bishop, Scott";
emailLookup["chess@contoso.com"] = "Hell, Christian";
emailLookup["djump@contoso.com"] = "Jump, Dan";

foreach (DictionaryEntry entry in emailLookup)
{
    Console.WriteLine(entry.Value);
}

// Delay.
Console.ReadKey();