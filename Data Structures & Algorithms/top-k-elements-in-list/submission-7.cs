public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        if(nums.Length == 1 || nums.Length == k){
            return nums;
        }

        Dictionary<int, int> dict= new Dictionary<int,int>();        

        
    foreach (int num in nums)
    {
        if(dict.ContainsKey(num))
            dict[num]++;
            else
                dict[num] = 1;
        //Console.WriteLine($"Key = {num}, Value = {dict[num]}");
    }
        
        int index = 0;        
        nums = new int[k];
        foreach (var item in dict.OrderByDescending(x => x.Value))
        {
            nums[index++] = item.Key;

            if (index == k)
               break;
        }
         return nums;   
    }
        
}
