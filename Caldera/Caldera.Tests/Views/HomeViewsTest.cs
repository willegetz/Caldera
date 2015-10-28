using System.Web.Mvc;
using Caldera.Controllers;
using NUnit.Framework;
using ApprovalTests.Asp.Mvc;
using System;
using ApprovalTests.Asp;
using ApprovalTests.Reporters;
using Caldera.Tests.TestableControllers;

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
            MvcApprovals.VerifyMvcPage<TestableHomeController>(home => home.TestIndex);
        }

        [Test]
        public void AboutView()
        {
            PortFactory.MvcPort = 49264;
            MvcApprovals.VerifyMvcPage<TestableHomeController>(home => home.TestAbout);
        }

        [Test]
        public void ContactView()
        {
            PortFactory.MvcPort = 49264;
            MvcApprovals.VerifyMvcPage<TestableHomeController>(home => home.TestContact);
        }
    }
}
