using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using foodary.Models;

namespace foodary.Controllers
{
    public class FoodEventsController : Controller
    {
        private Model1Container db = new Model1Container();

        // GET: FoodEvents
        public ActionResult Index()
        {
            return View(db.FoodEventSet.ToList());
        }

        // GET: FoodEvents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodEvent foodEvent = db.FoodEventSet.Find(id);
            if (foodEvent == null)
            {
                return HttpNotFound();
            }
            return View(foodEvent);
        }

        // GET: FoodEvents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,What,Address,Suburb,Phone,Website,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,Public_holidays,Cost,Longitude,Latitude,Geocoded_location")] FoodEvent foodEvent)
        {
            if (ModelState.IsValid)
            {
                db.FoodEventSet.Add(foodEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(foodEvent);
        }

        // GET: FoodEvents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodEvent foodEvent = db.FoodEventSet.Find(id);
            if (foodEvent == null)
            {
                return HttpNotFound();
            }
            return View(foodEvent);
        }

        // POST: FoodEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,What,Address,Suburb,Phone,Website,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,Public_holidays,Cost,Longitude,Latitude,Geocoded_location")] FoodEvent foodEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foodEvent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(foodEvent);
        }

        // GET: FoodEvents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodEvent foodEvent = db.FoodEventSet.Find(id);
            if (foodEvent == null)
            {
                return HttpNotFound();
            }
            return View(foodEvent);
        }

        // POST: FoodEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FoodEvent foodEvent = db.FoodEventSet.Find(id);
            db.FoodEventSet.Remove(foodEvent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
