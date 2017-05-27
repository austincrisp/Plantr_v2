using Plantr_v2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Plantr_v2.Controllers
{
    public class SoulController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Soul
        public ActionResult Index(string option, string search)
        {
            if (option == "Address")
            {
                return View(db.Souls.Where(s => s.Address == search || search == null).ToList());
            }
            else if (option == "Name")
            {
                return View(db.Souls.Where(s => s.LastName == search || search == null).ToList());
            }
            else
            {
                return View(db.Souls.ToList());
            }
        }

        // GET: Soul/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TempData["SoulId"] = id;
            Soul soul = db.Souls.Find(id);
            if (soul == null)
            {
                return HttpNotFound();
            }
            var tuple = new Tuple<Soul, Answer>(soul, new Answer());

            return View(tuple);
        }

        // GET: Soul/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Address,AptNumber,City,Zip,Phone")] Soul soul)
        {
            if (ModelState.IsValid)
            {
                db.Souls.Add(soul);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(soul);
        }

        // GET: Soul/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soul soul = db.Souls.Find(id);
            if (soul == null)
            {
                return HttpNotFound();
            }
            return View(soul);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Address,AptNumber,City,Zip,Phone")] Soul soul)
        {
            if (ModelState.IsValid)
            {
                db.Entry(soul).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", "Soul", new { id = soul.Id });
            }
            return View(soul);
        }

        // GET: Soul/Delete/5
        public ActionResult Delete(int id)
        {
            Soul soul = db.Souls.Find(id);
            db.Souls.Remove(soul);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        /*
        public ActionResult ShowMap()
        {
            return View();
        }
        */

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