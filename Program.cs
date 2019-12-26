using System;

namespace BinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            var heap = new BinaryHeap(1);
            heap.Insert(3);
            heap.Insert(1);
            heap.Insert(6);
            heap.Insert(5);
            heap.Insert(2);
            heap.Insert(4);
            Console.WriteLine(heap.FindMin());
        }
    }
}
