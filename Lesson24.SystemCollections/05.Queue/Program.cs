using System.Collections;

//FIFO (First In First Out)
var queue = new Queue();
queue.Enqueue("An item");           // Enqueue() - Sıranın sonuna yeni element əlavə edir
Console.WriteLine(queue.Dequeue()); // Dequeue() - Sırada olan birinci elementi geri qaytarır və onu silir

// Delay.
Console.ReadKey();