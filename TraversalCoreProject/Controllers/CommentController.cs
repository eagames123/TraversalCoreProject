using System;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace TraversalCoreProject.Controllers
{
    public class CommentController : Controller
    {
        private CommentManager _commentManager = new CommentManager(new EfCommentDal());

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.CommentState = true;
            _commentManager.Tadd(comment);
            return RedirectToAction("Index","Destination");
        }



    }
}
