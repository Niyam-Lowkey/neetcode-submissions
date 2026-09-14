public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        
        PriorityQueue<int,int> maxHeap = new PriorityQueue<int,int>(
            Comparer<int>.Create((a,b) => b.CompareTo(a))
        );
        
        int[] frequency = new int[26];

        foreach(char ch in tasks){
            frequency[ch - 'A']++;
        }

        foreach(int count in frequency){

            if(count > 0){
                maxHeap.Enqueue(count,count);
            }
        }

        int time = 0;

        while(maxHeap.Count > 0){
            List<int> used = new List<int>();

            for(int i = 0; i <= n; i++){
                
                if(maxHeap.Count > 0){
                    
                    int count = maxHeap.Dequeue();
                
                    count--;

                    if(count > 0){
                        used.Add(count);
                    }

                    time++;
                }
                else{

                    if (used.Count > 0)
                    {
                        time++;
                    }
                    else
                    {
                        break;
                    }
                }

            }

            foreach(int count in used){
                maxHeap.Enqueue(count,count);
            }

        }
        
        return time;

    }
}
