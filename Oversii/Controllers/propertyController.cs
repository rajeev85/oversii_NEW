using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Oversii.Models.DB;
using System.IO;

namespace Oversii.Controllers
{
    public class propertyController : Controller
    {
        private oversiiEntities db = new oversiiEntities();

        //// GET: properties
        //public ActionResult Index()
        //{
        //    var properties = db.properties.Include(p => p.property_management);
        //    return View(properties.ToList());
        //}

        //// GET: properties/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    property property = db.properties.Find(id);
        //    if (property == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(property);
        //}

        //// GET: properties/Create
        //public ActionResult Create()
        //{
        //    ViewBag.propertyMgmtID = new SelectList(db.property_management, "propertyMgmtID", "propertyMgmtName");
        //    return View();
        //}

        //// POST: properties/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "propID,propertyName,propertyMgmtID,active,parkingGL,permit,permitPrice,permitPerUnit,permitExpiry,permitDelivery,permitPayByHOA,targetVoilations,publicPatrolTarget,propertyManagerEditing,historyTrackingType,C24hrGracePeriod,assignedParkingSpace,oversiiSendingLettersAndFines,hasPM,createUserID,createDate,lastUpdatedDate,lastUpdatedUserID")] property property, HttpPostedFileBase upload)
        //{
        //    HttpPostedFileBase hpf = Request.Files[0] as HttpPostedFileBase;

        //    if (ModelState.IsValid)
        //    {
        //        if (upload != null && upload.ContentLength > 0)
        //        {
        //            var fileName = Path.GetFileName(upload.FileName);
        //            var fullpath = Path.Combine(
        //                    Server.MapPath("~/Files/ParkingGL"),fileName);
        //            upload.SaveAs(fullpath);
        //            property.parkingGL = fileName;
        //        }
        //        db.properties.Add(property);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.propertyMgmtID = new SelectList(db.property_management, "propertyMgmtID", "propertyMgmtName", property.propertyMgmtID);
        //    return View(property);
        //}

        //// GET: properties/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    property property = db.properties.Find(id);
        //    if (property == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.propertyMgmtID = new SelectList(db.property_management, "propertyMgmtID", "propertyMgmtName", property.propertyMgmtID);
        //    return View(property);
        //}

        //// POST: properties/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "propID,propertyName,propertyMgmtID,active,parkingGL,permit,permitPrice,permitPerUnit,permitExpiry,permitDelivery,permitPayByHOA,targetVoilations,publicPatrolTarget,propertyManagerEditing,historyTrackingType,C24hrGracePeriod,assignedParkingSpace,oversiiSendingLettersAndFines,hasPM,createUserID,createDate,lastUpdatedDate,lastUpdatedUserID")] property property, HttpPostedFileBase upload)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (upload != null && upload.ContentLength > 0)
        //        {
        //            var fileName = Path.GetFileName(upload.FileName);
        //            var fullpath = Path.Combine(
        //                    Server.MapPath("~/Files/ParkingGL"), fileName);
        //            upload.SaveAs(fullpath);
        //            property.parkingGL = fileName;
        //        }
        //        db.Entry(property).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.propertyMgmtID = new SelectList(db.property_management, "propertyMgmtID", "propertyMgmtName", property.propertyMgmtID);
        //    return View(property);
        //}

        //// GET: properties/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    property property = db.properties.Find(id);
        //    if (property == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(property);
        //}

        //// POST: properties/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    property property = db.properties.Find(id);
        //    string fullPath = Request.MapPath("~/Files/ParkingGL/" + property.parkingGL);
        //    if (System.IO.File.Exists(fullPath))
        //    {
        //        System.IO.File.Delete(fullPath);
        //    }
        //    db.properties.Remove(property);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
