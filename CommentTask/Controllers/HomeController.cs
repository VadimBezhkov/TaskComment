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
using ServisecRepl;
using Models;

namespace CommentTask.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AllComments comment = new AllComments();
            AllRepl repl = new AllRepl();
            if (comment.AllCom() != null)
            {
                ViewBag.Comments = comment.AllCom();
            }

            if (repl.Allrep() != null)
            {
                ViewBag.Answer = repl.Allrep();
            }

            return View();
        }

        [HttpGet]
        public ActionResult Comment(string userName, string comment)
        {

                if (userName != "" && comment != "")
                {
                    AddComment addcomment = new AddComment();
                    addcomment.Set(userName, comment);
                }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ReplAdd(int id ,string text)
        {
            if (text != null)
            {
                AddAnswer addRepl = new AddAnswer();
                addRepl.Set(text);
            }
            return RedirectToAction("Index");
        }
        public ActionResult ReplPost(int Id)
        {
            GetRepl rep = new GetRepl();
            var result= rep.Search(Id);

            ViewBag.Id = result.Id;
            ViewBag.Text = result.Text;
            ViewBag.CommentId = result.CommentId;
            return PartialView(result);
        }
        [HttpPost]
        public ActionResult EditPost(Repl post)
        {

            UpdateRepl rep = new UpdateRepl();
            rep.Update(post);

            return RedirectToAction("Index");
        }

    }
}