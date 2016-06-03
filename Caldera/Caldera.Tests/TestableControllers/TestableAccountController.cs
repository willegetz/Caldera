using ApprovalTests.Asp.Mvc;
using Caldera.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Caldera.Tests.TestableControllers
{
    public class TestableAccountController : TestableController<AccountController>
    {
        public TestableAccountController(AccountController accountController) : base(accountController) { }

        public ActionResult TestLogin()
        {
            var returnUrl = "HelloWorld";
            return ControllerUnderTest.Login(returnUrl);
        }
    }
}
