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
    public class HomeControllerIndexTest
    {

        private HomeController controller;
        private ViewResult result;

        [TestInitialize]
        public void SetupContext()
        {
            controller = new HomeController();
            result = controller.Index() as ViewResult;
        }

        [TestMethod]
        public void IndexViewResultNotNull()
        {
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexViewEqualIndexCshtml()
        {
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void IndexAreNotEqualViewbag()
        {
            Assert.AreNotEqual(result.ViewBag.Answer, result.ViewBag.Comments);
        }
        [TestMethod]
        public void IndexIsNotNullViewbagAnswer()
        {
            Assert.IsNotNull(result.ViewBag.Answer);
        }
        [TestMethod]
        public void IndexIsNotNullViewbagComments()
        {
            Assert.IsNotNull(result.ViewBag.Comments);
        }
          [TestMethod]
        public void IndexAreNotSameInViewbag()
        {
            Assert.AreNotSame(result.ViewBag.Comments, result.ViewBag.Answer);
        }
    }
}
