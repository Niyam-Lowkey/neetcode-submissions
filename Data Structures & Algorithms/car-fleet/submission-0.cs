public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        int n = position.Length;

        int[][] cars = new int[n][];

        for (int i = 0; i < n; i++)
        {
            cars[i] = new int[] { position[i], speed[i] };
        }

        QuickSort(cars, 0, n - 1);

        Stack<double> stack = new Stack<double>();

        for (int i = n - 1; i >= 0; i--)
        {
            int pos = cars[i][0];
            int spd = cars[i][1];

            double time = (double)(target - pos) / spd;           

            if (stack.Count == 0 || time > stack.Peek())
            {
                stack.Push(time);
            }
        }

        return stack.Count;
    }    

    void QuickSort(int[][] cars, int left, int right)
    {
        if (left >= right)
            return;

        int pivotIndex = Partition(cars, left, right);

        QuickSort(cars, left, pivotIndex - 1);

        QuickSort(cars, pivotIndex + 1, right);
    }


    int Partition(int[][] cars, int left, int right)
    {
        int pivot = cars[right][0];

        int i = left;

        for (int j = left; j < right; j++)
        {
            if (cars[j][0] < pivot)
            {
                Swap(cars, i, j);
                i++;
            }
        }

        Swap(cars, i, right);

        return i;
    }


    void Swap(int[][] cars, int i, int j)
    {
        int[] temp = cars[i];
        cars[i] = cars[j];
        cars[j] = temp;
    }
}