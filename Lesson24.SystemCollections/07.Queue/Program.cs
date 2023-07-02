using System.Collections;

var queue = new Queue();
queue.Enqueue("First");
queue.Enqueue("Second");
queue.Enqueue("Third");
queue.Enqueue("Fourth");

foreach (var item in queue)
{
    Console.WriteLine(item);
}

Console.WriteLine(queue.Count);

Console.WriteLine(new string('-', 80));

//foreach (var item in queue)
//{
//    Console.WriteLine(queue.Dequeue());
//}

//Console.WriteLine(queue.Count);

// Delay.
Console.ReadKey();