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
    public class subdivisionsController : Controller
    {
        private oversiiEntities db = new oversiiEntities();

        //// GET: subdivisions
        //public ActionResult Index()
        //{
        //    var subdivisions = db.subdivisions.Include(s => s.property);
        //    return View(subdivisions.ToList());
        //}

        //// GET: subdivisions/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    subdivision subdivision = db.subdivisions.Find(id);
        //    if (subdivision == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(subdivision);
        //}

        //// GET: subdivisions/Create
        //public ActionResult Create()
        //{
        //    ViewBag.propID = new SelectList(db.properties, "propID", "propertyName");
        //    return View();
        //}

        //// POST: subdivisions/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "subDivisionID,propID,SubDivisionName,createDate,lastUpdatedDate,lastUpdatedUserID")] subdivision subdivision)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.subdivisions.Add(subdivision);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.propID = new SelectList(db.properties, "propID", "propertyName", subdivision.propID);
        //    return View(subdivision);
        //}

        //// GET: subdivisions/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    subdivision subdivision = db.subdivisions.Find(id);
        //    if (subdivision == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.propID = new SelectList(db.properties, "propID", "propertyName", subdivision.propID);
        //    return View(subdivision);
        //}

        //// POST: subdivisions/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "subDivisionID,propID,SubDivisionName,createDate,lastUpdatedDate,lastUpdatedUserID")] subdivision subdivision)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(subdivision).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.propID = new SelectList(db.properties, "propID", "propertyName", subdivision.propID);
        //    return View(subdivision);
        //}

        //// GET: subdivisions/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    subdivision subdivision = db.subdivisions.Find(id);
        //    if (subdivision == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(subdivision);
        //}

        //// POST: subdivisions/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    subdivision subdivision = db.subdivisions.Find(id);
        //    db.subdivisions.Remove(subdivision);
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
