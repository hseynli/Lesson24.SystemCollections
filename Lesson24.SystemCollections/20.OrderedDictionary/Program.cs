using System.Collections.Specialized;
using System.Collections;

// OrderedDictionary - Elementlərin saxlanılması onların siyahıya əlavə edilməsi ardıcıllığı ilə yadda saxlanılır.

var emailLookup = new OrderedDictionary
                                  {
                                      {"sbishop@contoso.com", "Bishop, Scott"},
                                      {"chess@contoso.com", "Hell, Christian"},
                                      {"djump@contoso.com", "Jump, Dan"}
                                  };

foreach (DictionaryEntry entry in emailLookup)
{
    Console.WriteLine(entry.Value);
}

// Delay
Console.ReadKey();