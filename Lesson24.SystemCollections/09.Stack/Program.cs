using System.Collections;

// LIFO (Last In First Out)
var stack = new Stack();

stack.Push("First");
stack.Push("Second");
stack.Push("Third");
stack.Push("Fourth");

// Peek() - stekin yuxarısından elementi geri qaytarır və onu silmir
if (stack.Peek() is string)
{
    Console.WriteLine(stack.Pop());
}

// Count - say.
while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}

// Delay.
Console.ReadKey();