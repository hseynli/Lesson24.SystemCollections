using System.Collections;

var queue = new Queue();
queue.Enqueue("First");
queue.Enqueue("Second");
queue.Enqueue("Third");
queue.Enqueue("Fourth");

// Peek() - Sırada olan birinic elementi geri qaytarır və onu sıradan silmir
object element = queue.Peek();
Console.WriteLine(element as string); //First

Console.WriteLine(new string('-', 10));

if (element is string)
{
    Console.WriteLine(queue.Dequeue());  // First.
}



// Count - Sırada olan elementlərin sayını geri qaytarır
while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue()); // Second, Third, Fourth.
}

// Delay.
Console.ReadKey();