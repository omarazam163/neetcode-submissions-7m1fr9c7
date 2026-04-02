    public class Twitter
    {

        class Tweet
        {
            public int UserId;
            public int PostId;
            public Tweet(int UserId, int PostId)
            {
                this.UserId = UserId;
                this.PostId = PostId;
            }
        }
        Dictionary<int, HashSet<int>> UserFollowes;
        PriorityQueue<Tweet, int> PostQue;
        int time;
        public Twitter()
        {
            this.UserFollowes = new();
            this.PostQue = new();
        }

        public void PostTweet(int userId, int tweetId)
        {
            if(!UserFollowes.ContainsKey(userId))
            {
                UserFollowes[userId] = new HashSet<int>() {userId};
            }
            Tweet NewTweet = new Tweet(userId,tweetId);
            PostQue.Enqueue(NewTweet,-time);
            time++;
        }

        public List<int> GetNewsFeed(int userId)
        {
            List<int> postsToReturn = new();
            if (!UserFollowes.ContainsKey(userId)) return postsToReturn;
            Tweet[] temp = new Tweet[PostQue.Count];
            int index = 0;
            while(PostQue.Count>0)
            {
                Tweet current = PostQue.Dequeue();
                if ((UserFollowes[userId].Contains(current.UserId) || userId == current.UserId) && postsToReturn.Count<10)
                {
                    postsToReturn.Add(current.PostId);
                }
                temp[index] = current;
                index++;
            }
            for(int i=0;i<temp.Length;i++)
            {
                PostQue.Enqueue(temp[i],i);
            }
            return postsToReturn;
        }

        public void Follow(int followerId, int followeeId)
        {
            if(UserFollowes.ContainsKey(followerId))
            {
                UserFollowes[followerId].Add(followeeId);
            }
            else
            {
                UserFollowes[followerId] = new HashSet<int>() { followeeId };
            }
        }

        public void Unfollow(int followerId, int followeeId)
        {
            if (UserFollowes.ContainsKey(followerId))
            {
                UserFollowes[followerId].Remove(followeeId);
            }
        }
    }
