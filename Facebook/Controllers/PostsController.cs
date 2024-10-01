using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Facebook.DomainModels;
using Facebook.ServiceLayer;
using Facebook.ViewModels;

namespace Facebook.Controllers
{
    public class PostsController : ApiController
    {

        public string Post(Post p)
        {
            PostsService ps = new PostsService();
            p.PostDateAndTime = DateTime.Now;
            ps.InsertPost(p);

            return "Successfully Posted";
        }

        public List<PostViewModel> Get()
        {
            PostsService ps = new PostsService();
            List<Post> posts = ps.GetPosts();

            List<PostViewModel> postsvm = new List<PostViewModel>();
            foreach (var item in posts)
            {
                postsvm.Add(new PostViewModel() { PostID = item.PostID, PostedBy = item.PostedBy, PostMessage = item.PostMessage, PostDateAndTime = item.PostDateAndTime.Value.ToString() });
            }

            return postsvm;
        }

    }
}
