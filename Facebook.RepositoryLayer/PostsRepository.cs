using System;
using System.Collections.Generic;
using System.Linq;
using Facebook.DomainModels;

namespace Facebook.RepositoryLayer
{
    public class PostsRepository
    {

        public void InsertPost(Post p)
        {
            facebookdatabaseEntities db = new facebookdatabaseEntities();
            db.Posts.Add(p);
            db.SaveChanges();
        }

        public List<Post> GetPosts()
        {
            facebookdatabaseEntities db = new facebookdatabaseEntities();
            List<Post> posts;
            posts = db.Posts.OrderByDescending(p => p.PostDateAndTime.Value).ToList();
            return posts;
        }

    }
}
