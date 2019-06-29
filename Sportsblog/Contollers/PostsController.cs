using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sportsblog.Models;
using Sportsblog.Repository;

namespace Sportsblog.Contollers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        IRepository<Posts> postsRepo;

        public PostsController(IRepository<Posts> postsRepo)
        {
            this.postsRepo = postsRepo;
        }

        //Create Review
        [HttpGet]
        public ViewResult CreateReview(int id)
        {
            ViewBag.PostId = id;
            return View();
        }

        [HttpPost]
        public ActionResult CreateReview(Posts post)
        {
            postsRepo.Create(post);
            return RedirectToAction("../Posts/SinglePost/" + post.SportId);
        }

        public object SinglePost()
        {
            throw new NotImplementedException();
        }

        //Delete Review
        [HttpGet]
        public ViewResult DeleteReview(int id)
        {
            ViewBag.postId = id;
            return View();
        }

        [HttpPost]
        public ActionResult DeleteReview(Posts post)
        {
            postsRepo.Delete(post);
            return RedirectToAction("../Posts/SinglePost/" + post.SportId);
        }

        //Edit Review
        [HttpGet]
        public ViewResult EditPost(int id)
        {
            var model = postsRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditPost(Posts post)
        {
            postsRepo.Edit(post);

            return RedirectToAction("../Posts/SinglePost/" + post.SportId);
        }
    }
}