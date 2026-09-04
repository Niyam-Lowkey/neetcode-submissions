public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int [] result = new int[nums.Length];
        
        int i = 0;
        int j = 1;
        int cal = 1;
        while(nums.Length > i){

            if (i != j){
                cal = cal * nums[j];
            }
            j++; 

            if(j == nums.Length){
                result[i] = cal;
                i++;
                j = 0;
                cal = 1;
            }    
        }
        return result;
    }
}
