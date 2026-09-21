public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        List<int> current = new List<int>();
        bool[] used = new bool[nums.Length];
        void Backtrack(){

            if(current.Count == nums.Length){
                    result.Add(new List<int>(current));
                    return;
            }

            for(int i = 0; i < nums.Length; i++){
                
                if(used[i])
                    continue;                

                used[i] = true;
                current.Add(nums[i]);

                Backtrack();


                used[i] = false;
                current.RemoveAt(current.Count - 1);

            }
        }

        Backtrack();

        return result;    
    }

    
}
