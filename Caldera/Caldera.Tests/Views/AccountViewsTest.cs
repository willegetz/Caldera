using ApprovalTests.Asp;
using ApprovalTests.Asp.Mvc;
using ApprovalTests.Reporters;
using Caldera.Tests.TestableControllers;
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
            MvcApprovals.VerifyMvcPage<TestableAccountController>(account => account.TestLogin);//, MvcScrubbers.ScrubMvcVerificationToken);
        }
    }

    public class MvcScrubbers
    {

        public static string ScrubMvcVerificationToken(string input)
        {
            string AspViewState = "<input name=\"__RequestVerificationToken\" type=\"hidden\" value=\".+/>";
            return Regex.Replace(input, AspViewState, "<!-- request verification token -->");
        }
    }
}
