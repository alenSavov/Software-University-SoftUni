using Forum.Models;
using Forum.Models.Models;
using System;
using System.Collections.Generic;

namespace Forum.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var forumData = new ForumData();

            forumData.Users.Add(new User(1, "firtUser", "firstpass", new List<int> { 1, 2 }));
            forumData.Categories.Add(new Category(1, "Category1", new List<int> { 1 }));
            forumData.Posts.Add(new Post(1, "post1", "post 1 contrent", 1, 2, new List<int> { 1, 2, 3 }));
            forumData.Replies.Add(new Reply(1, "reply1", 1, 1));
            forumData.SaveChanges();

        }
    }
}
