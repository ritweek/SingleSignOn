using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SingleSignOn.Service;

namespace SingleSignOn.Controllers
{
    public class LoginController : Controller
    {
        Context _context = new Context();
        //
        // GET: /Login/
        public ActionResult SignIn()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(SingleSignOn.Models.UserDetails userDetails)
        {
            
            if (userDetails.UserName != null && userDetails.Password != null)
            {
                if (_context.Users.Any(x => x.UserName == userDetails.UserName && x.Password == userDetails.Password))
                {
                    FormsAuthentication.SetAuthCookie(userDetails.UserName, false);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SingleSignOn.Models.UserDetails userDetails)
        {

            _context.Users.Add(userDetails);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            var allusers = _context.Users.ToList();
            return View(allusers);
        }
	}
}