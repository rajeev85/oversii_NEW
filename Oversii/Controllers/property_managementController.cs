using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Oversii.Models.DB;

namespace Oversii.Controllers
{
    public class property_managementController : Controller
    {
        private oversiiEntities db = new oversiiEntities();

        //// GET: property_management
        //public ActionResult Index()
        //{
        //    return View(db.property_management.ToList());
        //}

        //// GET: property_management/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    property_management property_management = db.property_management.Find(id);
        //    if (property_management == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(property_management);
        //}

        //// GET: property_management/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: property_management/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "propertyMgmtID,propertyMgmtName,Address,City,State,Zipcode,Phoneno,fax")] property_management property_management)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.property_management.Add(property_management);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(property_management);
        //}

        //// GET: property_management/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    property_management property_management = db.property_management.Find(id);
        //    if (property_management == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(property_management);
        //}

        //// POST: property_management/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "propertyMgmtID,propertyMgmtName,Address,City,State,Zipcode,Phoneno,fax")] property_management property_management)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(property_management).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(property_management);
        //}

        //// GET: property_management/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    property_management property_management = db.property_management.Find(id);
        //    if (property_management == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(property_management);
        //}

        //// POST: property_management/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    property_management property_management = db.property_management.Find(id);
        //    db.property_management.Remove(property_management);
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
