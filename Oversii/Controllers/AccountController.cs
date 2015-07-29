using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oversii.Models.ViewModel;
using Oversii.Models.Repository;
using System.Web.Security;

namespace Oversii.Controllers
{
    public class AccountController : Controller
    {
        public static int? _PropID;
        public static string _zipcode;

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult SelectProperty()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult SelectProperty(string submittype, int? propertyID)
        //{
        //    if (submittype == "Yes")
        //    {
        //        ViewBag.propertyID = _PropID;
        //        return RedirectToAction("Register");
        //    }
        //    if (submittype == "Submit")
        //    {
        //        _PropID = propertyID;
        //        UserRepository UR = new UserRepository();
        //        var ParkingGL = UR.GetParkingGL(propertyID);
        //        if (ParkingGL != null)
        //        {
        //            ViewBag.ParkingGL = ParkingGL;
        //            return View();
        //        }
        //        else
        //        {
        //            var propName = UR.PropertyList(zipcode);
        //            TempData["MyList"] = propName;
        //            ViewBag.Message = "Please Select a Property!";
        //        }

        //    }
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Index(propertyList value, string submittype, int? propertyID)
        //{
        //    UserRepository UR = new UserRepository();
        //    if (submittype == "Check ZipCode")
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            var propName = UR.PropertyList(value.zipcode);
        //            _zipcode = value.zipcode;
        //            TempData["MyList"] = propName;
        //            return View();
        //        }
        //    }
        //    if (submittype == "Submit")
        //    {
        //        if (propertyID != null)
        //        {
        //            _PropID = propertyID;
        //            return RedirectToAction("Register");
        //        }
        //        else
        //        {
        //            var propName = UR.PropertyList(_zipcode);
        //            TempData["MyList"] = propName;
        //            ViewBag.Message = "Please Select a Property!";
        //        }

        //    }
        //    return View();
        //}

       // [HttpPost]
        //public ActionResult Register(UserAccount RM)
        //{
        //        if (ModelState.IsValid)
        //        {
        //            UserRepository RMG = new UserRepository();
        //            if (!RMG.ISEmailExist(RM.Email))
        //            {
        //                RMG.AddUserAccount(RM);
        //                FormsAuthentication.SetAuthCookie(RM.Email, false);
        //                ViewBag.Message = "User Registered! please LogIn";
        //                return RedirectToAction("Address", "Account", new { id = RM.UserID });
        //        }
        //            else
        //                ModelState.AddModelError("", "Email already taken.");
        //        }
        //    return View();
        //}
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(UserLoginView ULV, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                UserRepository UM = new UserRepository();
                var CurrUSer = UM.AuthenticateUser(ULV.Email, ULV.Password);
                if ((bool)CurrUSer.IsLoginSuccess)
                {
                    FormsAuthentication.SetAuthCookie(ULV.Email, false);
                    var role = CurrUSer.Role;
                    return RedirectToAction("DashBoard", role);
                }
                else if (!(bool)CurrUSer.IsLoginSuccess)
                {
                    ModelState.AddModelError("", "The user login or password provided is incorrect.");
                    return View(ULV);
                }
                else
                    return View(ULV);


            }
            else
                return View();
    }

        [Authorize]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}