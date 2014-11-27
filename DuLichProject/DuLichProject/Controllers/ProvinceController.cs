                                                                                                         using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DuLichProject.Models;

namespace DuLichProject.Controllers
{
    public class ProvinceController : Controller
    {
        private SoTayDB db = new SoTayDB();

        //
        // GET: /Province/

        public ActionResult Index()
        {
            return View(db.Provinces.ToList());
        }

        //
        // GET: /Province/Details/5

        public ActionResult Details(int id = 0)
        {
            Province province = db.Provinces.Find(id);
            if (province == null)
            {
                return HttpNotFound();
            }
            return View(province);
        }

        //
        // GET: /Province/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Province/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Province province)
        {
            if (ModelState.IsValid)
            {
                db.Provinces.Add(province);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(province);
        }

        //
        // GET: /Province/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Province province = db.Provinces.Find(id);
            if (province == null)
            {
                return HttpNotFound();
            }
            return View(province);
        }

        //
        // POST: /Province/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Province province)
        {
            if (ModelState.IsValid)
            {
                db.Entry(province).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(province);
        }

        //
        // GET: /Province/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Province province = db.Provinces.Find(id);
            if (province == null)
            {
                return HttpNotFound();
            }
            return View(province);
        }

        //
        // POST: /Province/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Province province = db.Provinces.Find(id);
            db.Provinces.Remove(province);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult DongThap()
        {
            return View();
        }
        public ActionResult AnGiang()
        {
            return View();
        }
        public ActionResult BacLieu()
        {
            return View();
        }
        public ActionResult BenTre()
        {
            return View();
        }
        public ActionResult CaMau()
        {
            return View();
        }

        public ActionResult CanTho()
        {
            return View();
        }
        public ActionResult HauGiang()
        {
            return View();
        }
        public ActionResult KienGiang()
        {
            return View();
        }
        public ActionResult LongAn()
        {
            return View();
        }
        public ActionResult SocTrang()
        {
            return View();
        }
        public ActionResult TienGiang()
        {
            return View();
        }
        public ActionResult TraVinh()
        {
            return View();
        }
        public ActionResult VinhLong()
        {
            return View();
        }
    }
}