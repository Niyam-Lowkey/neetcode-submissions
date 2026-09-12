public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], int> maxHeap = new PriorityQueue<int[],int>(
                Comparer<int>.Create((a,b) => b.CompareTo(a))
        );

        foreach(int[] point in points){
            int x = point[0];
            int y = point[1];
            int distance = x*x + y*y;

            maxHeap.Enqueue(point, distance);

            if(maxHeap.Count > k){
                maxHeap.Dequeue();
            }
        }

        int[][] result = new int[k][];

        for(int i = 0; i < k; i++){
            result[i] = maxHeap.Dequeue();
        }

        return result; 
    }
}
