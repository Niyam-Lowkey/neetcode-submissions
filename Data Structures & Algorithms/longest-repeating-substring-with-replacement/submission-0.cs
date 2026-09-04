public class Solution {
    public int CharacterReplacement(string s, int k) {

        int[] count = new int[26];
        
        int left = 0;                
        int mostFrequentLength = 0;
        int maxLength = 0;

        for(int right = 0; right < s.Length; right++){
            
            int index = s[right] - 'A';
            count[index]++;

            mostFrequentLength = Math.Max(mostFrequentLength,count[index]);

            int windowsize = right - left + 1;
            
            int charToReplace =  windowsize - mostFrequentLength;

            while(charToReplace > k){
                count[s[left] - 'A']--;
                left++;

                windowsize = right - left + 1;
                charToReplace = windowsize - mostFrequentLength;
            }

            maxLength = Math.Max(maxLength,windowsize);
            
        }

        return maxLength;
   }
}
