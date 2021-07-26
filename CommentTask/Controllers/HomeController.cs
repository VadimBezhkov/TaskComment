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

            return View("Index");
        }

        [HttpGet]
        public ActionResult Comment([Bind(Include = "UserName,TextComment")] string userName, string comment)
        {
            if (string.IsNullOrEmpty(comment))
            {
                ModelState.AddModelError("comment", "no value entered");  
            }
            if (string.IsNullOrEmpty(userName))
            {
                ModelState.AddModelError("UserName", "no value entered");
            }

            if (ModelState.IsValid)
                {
                    AddComment addcomment = new AddComment();
                    addcomment.Set(userName, comment);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ReplAdd(int id ,string textreply)
        {
            if (!string.IsNullOrEmpty(textreply))
            {
                AddAnswer addRepl = new AddAnswer();
                addRepl.Set(textreply,id);
            }
            return RedirectToAction("Index");
        }

    }
}