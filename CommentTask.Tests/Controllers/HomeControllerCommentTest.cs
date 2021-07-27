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
            result = controller.Comment(name, text) as RedirectResult;
            name = "Vadim";
            text = "Hello";
        }

        [TestMethod]
        public void CommentViewResultIsNull()
        {
            Assert.IsNull(result);
        }

        [TestMethod]
        public void CommentViewEqualCommentCshtml()
        {
            Assert.AreNotEqual("Index", result);
        }

        [TestMethod]
        public void CommentAreNotSameParams()
        {
            Assert.AreNotSame(name, text);
        }

        [TestMethod]
        public void CommentViewEqualAreEqual()
        {
            Assert.AreNotEqual(name,text);
        }

        [TestMethod]
        public void CommentViewIsTrue()
        {
            Assert.IsTrue(name!=text, "Index");
        }
    }
}
