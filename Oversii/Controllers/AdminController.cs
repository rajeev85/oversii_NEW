using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oversii.Security;

namespace Oversii.Controllers
{
    public class AdminController : Controller
    {
 
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [AuthorizeRoleAttribute("Admin")]
        public ActionResult DashBoard()
        {
            return View();
        }
    }
}