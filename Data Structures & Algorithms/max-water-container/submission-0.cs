public class Solution {
    public int MaxArea(int[] heights) {
        int n = heights.Length;
        int left = 0;
        int right = n-1;
        int maxArea = 0;
        while(left < right){

           int width = right - left;
            
           int area = width * 
           Math.Min(heights[left],heights[right]);

           maxArea = Math.Max(maxArea,area);

           if(heights[left] < heights[right])
                    left++;
           else
                    right--;
            
        }

        return maxArea;    
        
    }
}
