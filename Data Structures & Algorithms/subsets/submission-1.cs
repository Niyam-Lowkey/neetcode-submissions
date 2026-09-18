public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        List<int> current = new List<int>();

        Backtrack(nums, 0, current, result);

        return result;
    }

    private void Backtrack(int[] nums, int index, List<int> current, List<List<int>> result) {
        // We have made a decision for every number
        if (index == nums.Length) {
            result.Add(new List<int>(current));
            return;
        }

        // TAKE the current number
        current.Add(nums[index]);

        Backtrack(nums, index + 1, current, result);

        // UNDO the choice
        current.RemoveAt(current.Count - 1);

        // DON'T TAKE the current number
        Backtrack(nums, index + 1, current, result);
    }
}
