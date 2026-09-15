public class Twitter {

    private Dictionary<int,List<Tweet>> tweets;
    private Dictionary<int,HashSet<int>> following;

    private int time;

    public Twitter() {
        tweets = new Dictionary<int,List<Tweet>>();
        following = new Dictionary<int,HashSet<int>>();
        time = 0;
        
    }
    
    public void PostTweet(int userId, int tweetId) {
        if(!tweets.ContainsKey(userId))
            tweets[userId] = new List<Tweet>();

        time++;
        tweets[userId].Add(new Tweet(tweetId, time));            
    }
    
    public List<int> GetNewsFeed(int userId) {

        List<int> users = new List<int>();
        users.Add(userId);

        if(following.ContainsKey(userId)){

            foreach(int followeeId in following[userId])
                users.Add(followeeId);
        }

        List<int> result = new List<int>();
        
        PriorityQueue<Tweet,int> maxHeap= new PriorityQueue<Tweet,int>(
                Comparer<int>.Create((a,b) => b.CompareTo(a))
        );

        foreach(int user in users){

             if(!tweets.ContainsKey(user))
                continue;

             foreach(Tweet tweet in tweets[user]){
                maxHeap.Enqueue(tweet, tweet.Time);
             }
        }

        while(maxHeap.Count > 0 && result.Count < 10){
            Tweet newFeed = maxHeap.Dequeue();

            result.Add(newFeed.Id);

        }

        return result;
        
    }
    
    public void Follow(int followerId, int followeeId) {
        if(!following.ContainsKey(followerId))
        {
            following[followerId] = new HashSet<int>(); 
        }

        following[followerId].Add(followeeId);        
    }
    
    public void Unfollow(int followerId, int followeeId) {
        
        if(following.ContainsKey(followerId)){
            following[followerId].Remove(followeeId);
        }

    }

    public class Tweet{
        public int Id;
        public int Time;

        public Tweet(int id, int time){
            Id = id;
            Time = time;
        }
    }
}
