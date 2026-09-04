public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        if(nums.Length == 1 || nums.Length == k){
            return nums;
        }

        Dictionary<int, int> dict= new Dictionary<int,int>();
        int[] array = new int[k];

        
    foreach (int num in nums)
    {
        if(dict.ContainsKey(num))
            dict[num]++;
            else
                dict[num] = 1;
        Console.WriteLine($"Key = {num}, Value = {dict[num]}");
    }
        
        int indexmorethenone = 0;
        int arraysizemorethanone = k;
        nums = new int[arraysizemorethanone];
        foreach(var item in dict.Where(c => c.Value > 0).OrderByDescending(x =>x.Value)){
            //Console.WriteLine($"Key = {item}, Value = {dict[item]}");
             if( arraysizemorethanone > 0){
                //Console.WriteLine($"Key = {item}, Value = {dict[item]}, k= {k}");
                nums[indexmorethenone++] = item.Key;
                arraysizemorethanone--;
            }            
        }
         return nums;   
    }
        
}
