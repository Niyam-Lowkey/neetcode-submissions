public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<int> current = new List<int>();
        List<List<int>> result = new List<List<int>>();

        BackTracking(nums, 0, current, result, target);

        return result;
    }

    
    public void BackTracking(int[] nums,int index, List<int> current
        ,List<List<int>> result, int target)
    {
        if(target == 0){
            result.Add(new List<int>(current));            
        }

        if(target < 0)
            return;

        for(int i = index; i < nums.Length; i++){
            current.Add(nums[i]);

            BackTracking(nums, i, current, result, target - nums[i]);

            current.RemoveAt(current.Count - 1);
        }
    }
}
