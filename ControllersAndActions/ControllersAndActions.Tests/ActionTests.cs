using ControllersAndActions.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace ControllersAndActions.Tests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]
        public void ViewSelectionTest()
        {
            // Arrange - create the controller
            ExampleController target = new ExampleController();

            // Act - call the action method
            ViewResult result = target.Index();

            // Assert - check the result
            Assert.AreEqual("Index", result.ViewName);
            Assert.AreEqual("Hello", result.ViewBag.Message);
        }

        [TestMethod]
        public void RedirectTest()
        {
            // Arrange - create the controller
            ExampleController target = new ExampleController();

            // Act - call the action method
            //RedirectResult result = target.Redirect();
            RedirectToRouteResult result = target.Redirect();

            // Assert - check the result
            Assert.IsFalse(result.Permanent);
            //Assert.AreEqual("/Example/Index", result.Url);
            Assert.AreEqual("Example", result.RouteValues["controller"]);
            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual("MyID", result.RouteValues["ID"]);
        }

        [TestMethod]
        public void StatusCodeResultTest()
        {
            // Arrange - create the controller
            ExampleController target = new ExampleController();

            // Act - call the action method
            HttpStatusCodeResult result = target.StatusCode();

            // Assert - check the result
            Assert.AreEqual(404, result.StatusCode);
            Assert.AreEqual("URL cannot be serviced", result.StatusDescription);
        }
    }
}
