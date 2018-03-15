using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevopsNagpQ3.Controllers;
using System.Web.Mvc;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            HomeController ctr = new HomeController();
            var ar = ctr.About() as ViewResult;
            Assert.AreEqual("Nagp q3 test", ar.ViewData["Message"]);
        }
    }
}
