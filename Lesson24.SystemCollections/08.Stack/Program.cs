using System.Collections;

// LIFO (Last In First Out)
Stack stack = new Stack();
stack.Push("An item");          // Push() - stekin sonuna element əlavə edir
Console.WriteLine(stack.Pop()); // Pop() - stekin birinci elementini geri qaytarır və onu silir

// Delay.
Console.ReadKey();