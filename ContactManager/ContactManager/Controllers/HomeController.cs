using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactManager.Models;

namespace ContactManager.Controllers
{
    public class HomeController : Controller
    {
        private ContactManagerContext db = new ContactManagerContext();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(db.Friends.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id = 0)
        {
            Friends friends = db.Friends.Find(id);
            if (friends == null)
            {
                return HttpNotFound();
            }
            return View(friends);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Friends friends)
        {
            if (ModelState.IsValid)
            {
                db.Friends.Add(friends);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(friends);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Friends friends = db.Friends.Find(id);
            if (friends == null)
            {
                return HttpNotFound();
            }
            return View(friends);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Friends friends)
        {
            if (ModelState.IsValid)
            {
                db.Entry(friends).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(friends);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Friends friends = db.Friends.Find(id);
            if (friends == null)
            {
                return HttpNotFound();
            }
            return View(friends);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Friends friends = db.Friends.Find(id);
            db.Friends.Remove(friends);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}