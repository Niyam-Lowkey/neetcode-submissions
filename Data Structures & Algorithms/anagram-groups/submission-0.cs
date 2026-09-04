public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string,List<string>> dict = new Dictionary<string,List<string>>();

        foreach (string str in strs){

            int [] count = new int[26];

            foreach (char ch in str){
                //Console.WriteLine(ch);    
                //Console.WriteLine(count[ch - 'a']);    
                count[ch - 'a'] ++;
                //Console.WriteLine(count[ch - 'a'] ++);
            }

            string keys = string.Join(",",count);
            Console.WriteLine(keys);

            if(!dict.ContainsKey(keys)){
                dict[keys] = new List<string>();
            } 

            dict[keys].Add(str);
            //Console.WriteLine(dict.Values.ToList<List<string>>());

        }
            return dict.Values.ToList<List<string>>();
        
    }
}
