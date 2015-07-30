using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Oversii.Models.DB;
using Oversii.Models.ViewModel;
using Oversii.Models.Repository;
namespace Oversii.Controllers
{
    public class residentsController : Controller
    {
        private oversiiEntities db = new oversiiEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ApplyPermit()
        {
            UserRepository UR = new UserRepository();
           
            ViewData["Vehicle.VehicleMake.VehicleMakeID"] = new SelectList(UR.VehilceMakeList(), "VehicleMakeID", "MakeName");
            ViewData["Vehicle.VehicleColor.VehicleColorID"] = new SelectList(UR.VehicleColorList(), "VehicleColorID", "ColorName");
            ViewData["Vehicle.State.StateID"] = new SelectList(UR.StateList(), "StateID", "State");

            return View();
        }
        [HttpPost]
        public ActionResult ApplyPermit(VVehiclePermit VehiclePermt)
        {
            if (ModelState.IsValid)
            {
                UserRepository UR = new UserRepository();
                UR.CreatePermit(VehiclePermt);
                return null;

            }

            return View(VehiclePermt);
        }

        }   
        }


