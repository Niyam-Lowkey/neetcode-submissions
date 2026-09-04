public class Solution {
    public bool hasDuplicate(int[] nums) {
         Dictionary<int,int> dicnums = new Dictionary<int,int>();

         for(int i = 0 ; i < nums.Length; i++){
            
            if(dicnums.ContainsValue(nums[i])){
                return true;
            }
            dicnums.Add(i,nums[i]);

         }
         return false;
    }
}