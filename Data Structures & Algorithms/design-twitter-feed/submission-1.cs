public class Twitter {
    private Dictionary<int, List<(int time, int tweetId)>> tweets;
    private Dictionary<int, HashSet<int>> following;
    private int time;

    public Twitter() {
        tweets = new Dictionary<int, List<(int, int)>>();
        following = new Dictionary<int, HashSet<int>>();
        time = 0;
    }

    public void PostTweet(int userId, int tweetId) {
        if (!tweets.ContainsKey(userId))
            tweets[userId] = new List<(int, int)>();

        tweets[userId].Add((time++, tweetId));
    }

    public List<int> GetNewsFeed(int userId) {
        // collect tweets from self + followees
        var all = new List<(int time, int tweetId)>();

        if (tweets.ContainsKey(userId))
            all.AddRange(tweets[userId]);

        if (following.ContainsKey(userId)) {
            foreach (var followeeId in following[userId]) {
                if (followeeId == userId) continue;
                if (tweets.ContainsKey(followeeId))
                    all.AddRange(tweets[followeeId]);
            }
        }

        // sort by most recent
        return all.OrderByDescending(t => t.time)
                  .Take(10)
                  .Select(t => t.tweetId)
                  .ToList();
    }

    public void Follow(int followerId, int followeeId) {
        if (!following.ContainsKey(followerId))
            following[followerId] = new HashSet<int>();

        following[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId) {
        if (following.ContainsKey(followerId))

            following[followerId].Remove(followeeId);
    }
}

// post k-v
//  userid - (postid, posterId)
// add to users
// if unfollowed remove items with item2 == posterId
