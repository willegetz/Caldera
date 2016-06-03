using ApprovalTests.Asp;
using ApprovalTests.Asp.Mvc;
using ApprovalTests.Reporters;
using Caldera.Tests.TestableControllers;
using Caldera.Tests.Utilities;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace Caldera.Tests.Views
{
    [TestFixture]
    [UseReporter(typeof(BeyondCompareReporter), typeof(FileLauncherReporter), typeof(ClipboardReporter))]
    class AccountViewsTest
    {
        [Test]
        public void TestLogin()
        {
            PortFactory.MvcPort = 49264;
            MvcApprovals.VerifyMvcPage<TestableAccountController>(account => account.TestLogin, CustomMvcScrubbers.CopyrightScrubber);
        }
    }
}
