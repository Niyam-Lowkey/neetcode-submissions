public class MedianFinder
{
    // Smaller half
    private PriorityQueue<int, int> maxHeap;

    // Larger half
    private PriorityQueue<int, int> minHeap;

    public MedianFinder()
    {
        maxHeap = new PriorityQueue<int, int>(
            Comparer<int>.Create((a, b) => b.CompareTo(a))
        );

        minHeap = new PriorityQueue<int, int>();
    }

    public void AddNum(int num)
    {
        // Step 1: Put number into Max Heap
        maxHeap.Enqueue(num, num);

        // Step 2: Make sure every number
        // in maxHeap <= every number in minHeap
        if (minHeap.Count > 0 &&
            maxHeap.Peek() > minHeap.Peek())
        {
            int maxValue = maxHeap.Dequeue();
            int minValue = minHeap.Dequeue();

            maxHeap.Enqueue(minValue, minValue);
            minHeap.Enqueue(maxValue, maxValue);
        }

        // Step 3: Balance the sizes
        if (maxHeap.Count > minHeap.Count + 1)
        {
            int value = maxHeap.Dequeue();
            minHeap.Enqueue(value, value);
        }
        else if (minHeap.Count > maxHeap.Count)
        {
            int value = minHeap.Dequeue();
            maxHeap.Enqueue(value, value);
        }
    }

    public double FindMedian()
    {
        // Odd number of elements
        if (maxHeap.Count > minHeap.Count)
        {
            return maxHeap.Peek();
        }

        // Even number of elements
        return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
    }
}