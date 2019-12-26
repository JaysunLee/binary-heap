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

    }
}