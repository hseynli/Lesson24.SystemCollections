using System.Collections.Specialized;
using System.Collections;

// HybridDictionary - Siyahının ölçüsünü əvvəlcədən müəyyən edə bilmədikdə istifadə etmək məsləhət görülür

var emailLookup = new HybridDictionary();

emailLookup["sbishop@contoso.com"] = "Bishop, Scott";
emailLookup["chess@contoso.com"] = "Hell, Christian";
emailLookup["djump@contoso.com"] = "Jump, Dan";

foreach (DictionaryEntry entry in emailLookup)
{
    Console.WriteLine(entry.Value);
}

// Delay.
Console.ReadKey();