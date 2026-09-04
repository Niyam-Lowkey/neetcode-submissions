public class Solution {
    public void SortColors(int[] nums) {
        // Counting Concept
        int red = 0;
        int white = 0;
        int blue = 0;

        foreach(int num in nums){
            if(num == 0)
                red++;
            else if(num == 1)
                white++;
            else
                blue++;        
        }

        int i = 0;

        while(red-- > 0)
            nums[i++] = 0;

        while(white-- > 0)
            nums[i++] = 1;

        while(blue-- > 0)
            nums[i++] = 2;            

    }

    
}