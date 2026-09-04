public class Solution {
    public int RemoveElement(int[] nums, int val) {

        int k = 0;
        //int[] array = new int[nums.Length];

        for (int i = 0 ; i < nums.Length; i++){

            if(nums[i] != val){
                nums[k] = nums[i];
                k++;
            }
        }
        //Console.WriteLine();
        //nums = array;
        return k;
    }
}