using System.Web.Mvc;
using Caldera.Controllers;
using NUnit.Framework;
using ApprovalTests.Asp.Mvc;
using System;
using ApprovalTests.Asp;
using ApprovalTests.Reporters;

namespace Caldera.Tests.Views
{
    [TestFixture]
    [UseReporter(typeof(BeyondCompareReporter), typeof(FileLauncherReporter), typeof(ClipboardReporter))]
    public class HomeViewsTest
    {
        // TODO: Start Without Debugging to launch IISExpress and be able to use the MvcApprovals.
        [Test]
        public void IndexView()
        {
            PortFactory.MvcPort = 49264;
            MvcApprovals.VerifyMvcPage(new HomeController().Index);
        }

        [Test]
        public void AboutView()
        {
            PortFactory.MvcPort = 49264;
            MvcApprovals.VerifyMvcPage(new HomeController().About);
        }

        [Test]
        public void ContactView()
        {
            PortFactory.MvcPort = 49264;
            MvcApprovals.VerifyMvcPage(new HomeController().Contact);
        }
    }
}
