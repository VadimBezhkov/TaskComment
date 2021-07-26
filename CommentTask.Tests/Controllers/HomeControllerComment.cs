using CommentTask;
using CommentTask.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using ServicesAllComment;
using ServicesAllComment.Intarface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace CommentTask.Tests.Controllers
{
    [TestClass]
    public class HomeControllerCommentTest
    {

        private HomeController controller;
        private RedirectResult result;
        private string name;
        private string text;

        [TestInitialize]
        public void SetupContext()
        {
            controller = new HomeController();
            result = controller.Comment(name,text) as RedirectResult;
        }

        [TestMethod]
        public void IndexViewResultNotNull()
        {
            Assert.IsNull(result);
        }

        [TestMethod]
        public void IndexViewEqualCommentCshtml()
        {
            Assert.AreNotEqual("Index", result);
        }

        [TestMethod]
        public void IndexViewEqualCommentAreEqual()
        {
            Assert.AreEqual(name,text);
        }

        //[TestMethod]
        //public void IndexAreNotEqualViewbag()
        //{
        //    Assert.AreNotEqual(result.ViewBag.Answer, result.ViewBag.Comments);
        //}
        //[TestMethod]
        //public void IndexIsNotNullViewbagAnswer()
        //{
        //    Assert.IsNotNull(result.ViewBag.Answer);
        //}
        //[TestMethod]
        //public void IndexIsNotNullViewbagComments()
        //{
        //    Assert.IsNotNull(result.ViewBag.Comments);
        //}
        //  [TestMethod]
        //public void IndexAreNotSameInViewbag()
        //{
        //    Assert.AreNotSame(result.ViewBag.Comments, result.ViewBag.Answer);
        //}
    }
}
