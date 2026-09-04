public class Solution {
    public int MajorityElement(int[] nums) {
        
        Dictionary<int,int> dict = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++){

            if(!dict.ContainsKey(nums[i])){
                    dict[nums[i]] = 1;
            }
            else{
                dict[nums[i]] ++;
            }

        } 

        int k = 0; int j=0; 
        foreach(int item in dict.Keys){
            
            if( k < dict[item]){
                k = dict[item];
                j = item;               
            }
                
        }            
        return j;

    }
}