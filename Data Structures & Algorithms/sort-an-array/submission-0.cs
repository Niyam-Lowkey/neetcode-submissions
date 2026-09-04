public class Solution {

    // Heapify Sorting concept

    public int[] SortArray(int[] nums) {
        HeapSort(nums);
        return nums;
    }

    private void Heapify(int[] arr, int n, int i) {
        int l = (i << 1) + 1;
        int r = (i << 1) + 2;
        int largestNode = i;

        if (l < n && arr[l] > arr[largestNode]) {
            largestNode = l;
        }

        if (r < n && arr[r] > arr[largestNode]) {
            largestNode = r;
        }

        if (largestNode != i) {
            Swap(arr, i, largestNode);
            Heapify(arr, n, largestNode);
        }
    }

    private void HeapSort(int[] arr) {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--) {
            Heapify(arr, n, i);
        }

        for (int i = n - 1; i > 0; i--) {
            Swap(arr, 0, i);
            Heapify(arr, i, 0);
        }
    }

    private void Swap(int[] arr, int i, int j) {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}