using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Facebook.ServiceLayer;
using Facebook.DomainModels;

namespace Facebook.Controllers
{
    public class HomeController : Controller
    {

        // GET: /Home/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Home/MainPage
        public ActionResult MainPage(string Username)
        {
            if (Username != "" && Username != null)
            {
                Session["CurrentUsername"] = Username;
                System.Web.Security.FormsAuthentication.SetAuthCookie(Username, false);
                return RedirectToAction("MainPage2");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: /Home/MainPage2
        [Authorize]
        public ActionResult MainPage2()
        {
            return View();
        }

        // GET: /Home/InsertPost
        public ActionResult InsertPost(string PostMessage, string PostedBy)
        {
            PostsService s = new PostsService();
            Post p = new Post();
            p.PostMessage = PostMessage;
            p.PostedBy = PostedBy;
            p.PostDateAndTime = DateTime.Now;
            s.InsertPost(p);

            return Content("Successfully Posted");
        }

    }
}
