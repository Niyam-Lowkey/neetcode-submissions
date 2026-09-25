public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums)
{
    Array.Sort(nums);

    List<List<int>> result = new List<List<int>>();
    List<int> current = new List<int>();

    Backtrack(0);

    return result;

    void Backtrack(int start)
    {
        result.Add(new List<int>(current));

        for (int i = start; i < nums.Length; i++)
        {
            if (i > start && nums[i] == nums[i - 1])
                continue;

            current.Add(nums[i]);

            Backtrack(i + 1);

            current.RemoveAt(current.Count - 1);
        }
    }
}
}
