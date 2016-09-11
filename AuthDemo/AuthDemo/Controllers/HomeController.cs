using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace AuthDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string UserName,string UserPassword)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity("AuthenticationTypeCookie");
            List<Claim> claims = new List<Claim>();
            Claim claim1 = new Claim(ClaimTypes.Name, "Hemant");
            Claim claim2 = new Claim(ClaimTypes.PostalCode, "2148");

            claims.Add(claim1);
            claims.Add(claim2);

            claimsIdentity.AddClaims(claims);

            HttpContext.GetOwinContext().Authentication.SignIn(claimsIdentity);
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.GetOwinContext().Authentication.SignOut("AuthenticationTypeCookie");
            return RedirectToAction("Index");
        }
    }
}