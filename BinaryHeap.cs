using System;

namespace BinaryHeap
{
    // This is a min-heap.
    class BinaryHeap
    {
        private int[] heap { get; set; }
        private int size { get; set; }

        public BinaryHeap(int maximumSize)
        {
            heap = new int[maximumSize + 1];
            size = 0;
        }

        public int FindMin()
        {
            return heap[1];
        }

        public void Insert(int value)
        {
            if (size == heap.Length - 1)
            {
                DoubleMaximumSize();
            }

            size++;
            int cursor = size;

            // Percolate up
            while (cursor > 1 && value < heap[cursor / 2])
            {
                heap[cursor] = heap[cursor / 2];
                cursor = cursor / 2;
            }
            heap[cursor] = value;
        }

        private void DoubleMaximumSize()
        {
            int newSize = heap.Length * 2;
            int[] newHeap = new int[newSize];
            Array.Copy(heap, newHeap, heap.Length);
            heap = newHeap;
        }
    }
}