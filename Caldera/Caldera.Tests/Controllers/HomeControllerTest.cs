using System.Web.Mvc;
using Caldera.Controllers;
using NUnit.Framework;
using ApprovalTests.Asp.Mvc;
using System;
using ApprovalTests.Asp;
using ApprovalTests.Reporters;

namespace Caldera.Tests.Controllers
{
    [TestFixture]
    [UseReporter(typeof(BeyondCompareReporter), typeof(FileLauncherReporter), typeof(ClipboardReporter))]
    public class HomeControllerTest
    {
        // TODO: Start Without Debugging to launch IISExpress and be able to use the MvcApprovals.
        [Test]
        public void Index()
        {
            PortFactory.MvcPort = 49264;
            MvcApprovals.VerifyMvcPage(new HomeController().Index);
        }

        [Test]
        public void About()
        {
            PortFactory.MvcPort = 49264;
            MvcApprovals.VerifyMvcPage(new HomeController().About);
        }

        [Test]
        public void Contact()
        {
            PortFactory.MvcPort = 49264;
            MvcApprovals.VerifyMvcPage(new HomeController().Contact);
        }
    }
}
