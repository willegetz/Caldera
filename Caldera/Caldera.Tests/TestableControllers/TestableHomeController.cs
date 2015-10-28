using ApprovalTests.Asp.Mvc;
using Caldera.Controllers;
using System.Web.Mvc;

namespace Caldera.Tests.TestableControllers
{
    public class TestableHomeController : TestableController<HomeController>
    {
        public TestableHomeController(HomeController homeController) : base(homeController) { }

        public ActionResult TestIndex()
        {
            return ControllerUnderTest.Index();
        }

        public ActionResult TestAbout()
        {
            return ControllerUnderTest.About();
        }

        public ActionResult TestContact()
        {
            return ControllerUnderTest.Contact();
        }
    }
}
