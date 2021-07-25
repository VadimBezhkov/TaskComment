using Model;
using Repositories.Repositor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataProvider;
using Services;
using ServicesAllComment;

namespace CommentTask.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AllComments comment = new AllComments();
            if (comment.AllCom() != null)
            {
                ViewBag.Comments = comment.AllCom();
            }
            return View();
        }
        [HttpGet]
        public ActionResult Comment(string userName, string comment)
        {
            if(userName != null&& comment != null)
            {
                AddComment addcomment = new AddComment();
                addcomment.Set(userName, comment);
            }
            return RedirectToAction("Index");
        }
    }
}