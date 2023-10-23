using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;

namespace Net48FrameworkApp.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public AccountController()
        {
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            if (!string.IsNullOrEmpty(returnUrl))
            {
                // This produces InvalidOperationException: The supplied URL is not local. A URL with an absolute path is considered local if it does not have a host/authority part. URLs using virtual paths ('~/') are also local.
                // TODO: Will it work with subdomains in production??
                //returnUrl = "localhost:44390" + returnUrl;
            }
            return Redirect($"https://localhost:7216/Identity/Account/Login?returnUrl={returnUrl}");
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut("Identity.Application");
            return RedirectToAction("Index", "Home");
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
    }
}