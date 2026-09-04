public class Solution {
    public bool hasDuplicate(int[] nums) {
        int length = nums.Length;
        for(int i=0; i < length; i++){
            
            for(int j=0; j < length; j++){
                
                if(i != j && nums[j] == nums[i]){

                    return true;
                }

            }
        }
        return false;
    }
}