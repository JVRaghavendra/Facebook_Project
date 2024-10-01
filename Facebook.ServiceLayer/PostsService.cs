using System;
using System.Collections.Generic;
using System.Linq;
using Facebook.DomainModels;
using Facebook.RepositoryLayer;

namespace Facebook.ServiceLayer
{
    public class PostsService
    {

        public void InsertPost(Post p)
        {
            UsersRepository ur = new UsersRepository();
            if (ur.GetUsersByEmail(p.PostedBy).Count == 1)
            {
                PostsRepository pr = new PostsRepository();
                pr.InsertPost(p);
            }
        }

        public List<Post> GetPosts()
        {
            PostsRepository pr = new PostsRepository();
            List<Post> posts = pr.GetPosts();
            return posts;
        }

    }
}
