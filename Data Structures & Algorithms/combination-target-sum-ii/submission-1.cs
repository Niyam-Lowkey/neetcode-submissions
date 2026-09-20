public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        List<int> current = new List<int>();
        List<List<int>> result = new List<List<int>>();

        Array.Sort(candidates);

        Backtrack(candidates, 0, current, result, target);

        return result;
    }

     private void Backtrack(int[] candidates, int start, List<int> current, List<List<int>> result, int target) {
   
        if(target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        if(target < 0)
            return;

        for(int i = start; i < candidates.Length; i++){

            if(i > start && candidates[i] == candidates[i-1]){
                continue;
            }

            current.Add(candidates[i]);

            Backtrack(candidates,i + 1,current,result,target - candidates[i]);

            current.RemoveAt(current.Count - 1);
        }    

                
    }
}
