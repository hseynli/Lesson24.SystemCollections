using System.Collections;

var emailLookup = new Hashtable();

// Add metodu iki arqument qəbul edir key və value
emailLookup.Add("sbishop@contoso.com", "Bishop, Scott");

// Hashtable-da artıq olan key-i yenidən əlavə etmək olmur
//emailLookup.Add("sbishop@contoso.com", "Bishop, Scott2");

// İndeksatorların özəlliyi.

// Əgər indeksatora verdiyimiz key mövcud deyilsə, onda yeni element əlavə ediləcək
emailLookup["s.bishop@contoso.com"] = "Bishop, Scott";

// Əgər belə indek mövcud olsa, onda sadəcə dəyər dəyişiləcəkdir
emailLookup["sbishop@contoso.com"] = "-------------";


Console.WriteLine(emailLookup["sbishop@contoso.com"]);
Console.WriteLine(emailLookup["s.bishop@contoso.com"]);