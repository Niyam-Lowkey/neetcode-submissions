public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
                return false;
        }
        
        Dictionary<char,int> dict = new Dictionary<char,int>();

        foreach (char ch in s)
        {
                if(dict.ContainsKey(ch))
                    dict[ch]++;
                else
                    dict[ch] = 1;
        }

        foreach (char ch in t )
        {

            if(!dict.ContainsKey(ch))
                return false;            
            else
                dict[ch]--;
        }

        foreach(var item in dict){

            if(item.Value != 0){
                return false;
            }

        }

        return true;

    }
}
