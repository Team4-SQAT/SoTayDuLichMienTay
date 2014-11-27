using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.Mvc;
using DuLichProject.Models;

namespace DuLichProject.Controllers
{
   
    public class PlacesController : Controller
    {
        private SoTayDB db = new SoTayDB();

        //
        // GET: /Places/

        public ActionResult Index()
        {
            var places = db.Places.Include(p => p.Province);
            return View(places.ToList());
        }

        //
        // GET: /Places/Details/5

        public ActionResult Details(int id = 0)
        {
            Place place = db.Places.Find(id);
            if (place == null)
            {
                return HttpNotFound();
            }
            return View(place);
        }

        //
        // GET: /Places/Create

        public ActionResult Create()
        {
            ViewBag.idProvince = new SelectList(db.Provinces, "id", "name");
            return View();
        }

        //
        // POST: /Places/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Place place)
        {
            if (ModelState.IsValid)
            {
                db.Places.Add(place);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idProvince = new SelectList(db.Provinces, "id", "name", place.idProvince);
            return View(place);
        }

        //
        // GET: /Places/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Place place = db.Places.Find(id);
            if (place == null)
            {
                return HttpNotFound();
            }
            ViewBag.idProvince = new SelectList(db.Provinces, "id", "name", place.idProvince);
            return View(place);
        }

        //
        // POST: /Places/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Place place)
        {
            if (ModelState.IsValid)
            {
                db.Entry(place).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idProvince = new SelectList(db.Provinces, "id", "name", place.idProvince);
            return View(place);
        }

        //
        // GET: /Places/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Place place = db.Places.Find(id);
            if (place == null)
            {
                return HttpNotFound();
            }
            return View(place);
        }

        //
        // POST: /Places/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Place place = db.Places.Find(id);
            db.Places.Remove(place);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //Tinh Dong Thap
        public ActionResult khuditichgothap()
        {
            return View();
        }

        public ActionResult langcuphobang()
        {
            return View();
        }

        public ActionResult langhoakieng()
        {
            return View();
        }

        public ActionResult tramchim()
        {
            return View();
        }

        //Tinh An Giang
        public ActionResult nuicam()
        {
            return View();


        }

        public ActionResult culaogieng()
        {
            return View();
        }

        public ActionResult nuisam()
        {
            return View();
        }

        public ActionResult rungtramtrasu()
        {
            return View();
        }

        //Tinh Ben Tre
        public ActionResult conoc()
        {
            return View();
        }

        public ActionResult conphung()
        {
            return View();
        }

        public ActionResult conqui()
        {
            return View();
        }

        public ActionResult sanchimvamho()
        {
            return View();
        }

        //Tinh Bac Lieu
        public ActionResult rungbienbaclieu()
        {
            return View();
        }

        public ActionResult congtubaclieu()
        {
            return View();
        }

        public ActionResult vuonchimbl()
        {
            return View();
        }

        public ActionResult vuonnhanbl()
        {
            return View();
        }

        //Tinh Ca Mau
        public ActionResult chuaquanam()
        {
            return View();
        }

        public ActionResult daohonkhoai()
        {
            return View();
        }

        public ActionResult muicamau()
        {
            return View();
        }

        public ActionResult runguminh()
        {
            return View();
        }

        //Tinh Can Tho
        public ActionResult chodemTD()
        {
            return View();
        }

        public ActionResult dulichMK()
        {
            return View();
        }

        public ActionResult nhacoBT()
        {
            return View();
        }

        public ActionResult vuoncoBL()
        {
            return View();
        }

        //Tinh Hau Giang
        public ActionResult chonoiPH()
        {
            return View();
        }

        public ActionResult denthoBH()
        {
            return View();
        }

        public ActionResult lungngochoang()
        {
            return View();
        }

        public ActionResult taydo()
        {
            return View();
        }

        //Tinh Kien Giang
        public ActionResult phuquoc()
        {
            return View();
        }

        public ActionResult hatien()
        {
            return View();
        }

        public ActionResult langchaiHN()
        {
            return View();
        }

        public ActionResult langhomac()
        {
            return View();
        }

        //Tinh Long An
        public ActionResult binhta()
        {
            return View();
        }

        public ActionResult chuatonthanh()
        {
            return View();
        }

        public ActionResult dongthap10()
        {
            return View();
        }

        public ActionResult rachnui()
        {
            return View();
        }

        //Tinh soc trang
        public ActionResult chonoinga5()
        {
            return View();
        }

        public ActionResult chuadoi()
        {
            return View();
        }

        public ActionResult chuadatset()
        {
            return View();
        }

        public ActionResult KDLbinhan()
        {
            return View();
        }

        //Tinh Tien Giang
        public ActionResult chonoiCB()
        {
            return View();
        }

        public ActionResult chuavinhtrang()
        {
            return View();
        }

        public ActionResult culaoTS()
        {
            return View();
        }

        public ActionResult trairan()
        {
            return View();
        }

        //Tinh Tra Vinh
        public ActionResult aobaom()
        {
            return View();
        }
        public ActionResult badong()
        {
            return View();
        }
        public ActionResult chuaang()
        {
            return View();
        }
        public ActionResult chuahang()
        {
            return View();
        }
        //Tinh vinh long
        public ActionResult chuatienchau()
        {
            return View();
        }
        public ActionResult culao()
        {
            return View();
        }
        public ActionResult vinhsan()
        {
            return View();
        }
        public ActionResult vanthanhmieu()
        {
            return View();
        }
        
        public ActionResult DuLichAnGiang()
        {
            string s = "";
            string chuoi = "";
            var query = (from p in db.Places
                         where p.idProvince == 2
                         select p).ToList();
            var q1 = db.Foods.Where(m => m.Provinces.Any(p => p.id == 5));
            foreach (var place in query)
            {
                s += "<div class='col-xs-6 col-sm-3 placeholder'>" + "<h2>" + place.name + "</h2>" + "<br/>";
                s += place.pictures + "<br/>";
                s += "<p>" + place.description + "</p> </div>";
                s += "<hr>";

            }
            foreach (var food in q1)
            {
                chuoi += "<div class=\"col-xs-6 col-md-3\">";
               
                chuoi += "<a href=\"#\" class=\"thumbnail\">";
                chuoi += food.description;
                chuoi += "<h3>" + food.name + "</h3>";
                chuoi += "</a>";
                chuoi += "</div>";

            }
            ViewBag.View = s;
            ViewBag.Xem = chuoi;

            return View();
        }

        public ActionResult DuLichBacLieu()
        {
            string s = "";
            string chuoi = "";
            var query = (from p in db.Places
                         where p.idProvince == 3
                         select p).ToList();
            var q1 = db.Foods.Where(m => m.Provinces.Any(p => p.id ==6 ));
            foreach (var place in query)
            {
                s += "<div class='col-xs-6 col-sm-3 placeholder'>" + "<h2>" + place.name + "</h2>" + "<br/>";
                s += place.pictures + "<br/>";
                s += "<p>" + place.description + "</p> </div>";

            }
            foreach (var food in q1)
            {
                chuoi += "<div class=\"col-xs-6 col-md-3\">";

                chuoi += "<a href=\"#\" class=\"thumbnail\">";
                chuoi += food.description;
                chuoi += "<h3>" + food.name + "</h3>";
                chuoi += "</a>";
                chuoi += "</div>";

            }
            ViewBag.View = s;
            ViewBag.Xem = chuoi;
            return View();
        }

        public ActionResult DuLichBenTre()
        {
            string s = "";
            string chuoi = "";
            var query = (from p in db.Places
                         where p.idProvince == 4
                         select p).ToList();
            var q1 = db.Foods.Where(m => m.Provinces.Any(p => p.id == 9));
            foreach (var place in query)
            {
                s += "<div class='col-xs-6 col-sm-3 placeholder'>" + "<h2>" + place.name + "</h2>" + "<br/>";
                s += place.pictures + "<br/>";
                s += "<p>" + place.description + "</p> </div>";

            }
            foreach (var food in q1)
            {
                chuoi += "<div class=\"col-xs-6 col-md-3\">";

                chuoi += "<a href=\"#\" class=\"thumbnail\">";
                chuoi += food.description;
                chuoi += "<h3>" + food.name + "</h3>";
                chuoi += "</a>";
                chuoi += "</div>";

            }
            ViewBag.View = s;
            ViewBag.Xem = chuoi;
            return View();
        }

        public ActionResult DuLichCaMau()
        {
            string s = "";
            string chuoi = "";
            var query = (from p in db.Places
                         where p.idProvince == 5
                         select p).ToList();
            var q1 = db.Foods.Where(m => m.Provinces.Any(p => p.id == 5));
            foreach (var place in query)
            {
                s += "<div class='col-xs-6 col-sm-3 placeholder'>" + "<h2>" + place.name + "</h2>" + "<br/>";
                s += place.pictures + "<br/>";
                s += "<p>" + place.description + "</p> </div>";

            }
            foreach (var food in q1)
            {
                chuoi += "<div class=\"col-xs-6 col-md-3\">";

                chuoi += "<a href=\"#\" class=\"thumbnail\">";
                chuoi += food.description;
                chuoi += "<h3>" + food.name + "</h3>";
                chuoi += "</a>";
                chuoi += "</div>";

            }
            ViewBag.View = s;
            ViewBag.Xem = chuoi;
            return View();
        }

        public ActionResult DuLichCanTho()
        {
            string s = "";
            string chuoi = "";
            var query = (from p in db.Places
                         where p.idProvince == 6
                         select p).ToList();
            var q1 = db.Foods.Where(m => m.Provinces.Any(p => p.id == 6));
            foreach (var place in query)
            {
                s += "<div class='col-xs-6 col-sm-3 placeholder'>" + "<h2>" + place.name + "</h2>" + "<br/>";
                s += place.pictures + "<br/>";
                s += "<p>" + place.description + "</p> </div>";

            }
            foreach (var food in q1)
            {
                chuoi += "<div class=\"col-xs-6 col-md-3\">";

                chuoi += "<a href=\"#\" class=\"thumbnail\">";
                chuoi += food.description;
                chuoi += "<h3>" + food.name + "</h3>";
                chuoi += "</a>";
                chuoi += "</div>";

            }
            ViewBag.View = s;
            ViewBag.Xem = chuoi;
            return View();
        }

        public ActionResult DuLichDongThap()
        {

            string s = "";
            string chuoi = "";
            var query = (from p in db.Places
                         where p.idProvince == 7
                         select p).ToList();
            var q1 = db.Foods.Where(m => m.Provinces.Any(p => p.id == 10));
            foreach (var place in query)
            {
                s += "<div class='col-xs-6 col-sm-3 placeholder'>" + "<h2>" + place.name + "</h2>" + "<br/>";
                s += place.pictures + "<br/>";
                s += "<p>" + place.description + "</p> </div>";

            }
            foreach (var food in q1)
            {
                chuoi += "<div class=\"col-xs-6 col-md-3\">";

                chuoi += "<a href=\"#\" class=\"thumbnail\">";
                chuoi += food.description;
                chuoi += "<h3>" + food.name + "</h3>";
                chuoi += "</a>";
                chuoi += "</div>";

            }
            ViewBag.View = s;
            ViewBag.Xem = chuoi;
            return View();
        }

        public ActionResult DuLichHauGiang()
        {

            string s = "";
            string chuoi = "";
            var query = (from p in db.Places
                         where p.idProvince == 8
                         select p).ToList();
            var q1 = db.Foods.Where(m => m.Provinces.Any(p => p.id == 10));
            foreach (var place in query)
            {
                s += "<div class='col-xs-6 col-sm-3 placeholder'>" + "<h2>" + place.name + "</h2>" + "<br/>";
                s += place.pictures + "<br/>";
                s += "<p>" + place.description + "</p> </div>";

            }
            foreach (var food in q1)
            {
                chuoi += "<div class=\"col-xs-6 col-md-3\">";

                chuoi += "<a href=\"#\" class=\"thumbnail\">";
                chuoi += food.description;
                chuoi += "<h3>" + food.name + "</h3>";
                chuoi += "</a>";
                chuoi += "</div>";

            }
            ViewBag.View = s;
            ViewBag.Xem = chuoi;
            return View();
        }

        public ActionResult DuLichKienGiang()
        {
            string s = "";
            string chuoi = "";
            var query = (from p in db.Places
                         where p.idProvince == 9
                         select p).ToList();
            var q1 = db.Foods.Where(m => m.Provinces.Any(p => p.id == 9));
            foreach (var place in query)
            {
                s += "<div class='col-xs-6 col-sm-3 placeholder'>" + "<h2>" + place.name + "</h2>" + "<br/>";
                s += place.pictures + "<br/>";
                s += "<p>" + place.description + "</p> </div>";

            }
            foreach (var food in q1)
            {
                chuoi += "<div class=\"col-xs-6 col-md-3\">";

                chuoi += "<a href=\"#\" class=\"thumbnail\">";
                chuoi += food.description;
                chuoi += "<h3>" + food.name + "</h3>";
                chuoi += "</a>";
                chuoi += "</div>";

            }
            ViewBag.View = s;
            ViewBag.Xem = chuoi;
            return View();
        }

        public ActionResult DuLichLongAn()
        {
            string s = "";
            string chuoi = "";
            var query = (from p in db.Places
                         where p.idProvince == 10
                         select p).ToList();
            var q1 = db.Foods.Where(m => m.Provinces.Any(p => p.id == 10));
            foreach (var place in query)
            {
                s += "<div class='col-xs-6 col-sm-3 placeholder'>" + "<h2>" + place.name + "</h2>" + "<br/>";
                s += place.pictures + "<br/>";
                s += "<p>" + place.description + "</p> </div>";

            }
            foreach (var food in q1)
            {
                chuoi += "<div class=\"col-xs-6 col-md-3\">";

                chuoi += "<a href=\"#\" class=\"thumbnail\">";
                chuoi += food.description;
                chuoi += "<h3>" + food.name + "</h3>";
                chuoi += "</a>";
                chuoi += "</div>";

            }
            ViewBag.View = s;
            ViewBag.Xem = chuoi;
            return View();
        }

        public ActionResult DuLichSocTrang()
        {
            string s = "";
            string chuoi = "";
            var query = (from p in db.Places
                         where p.idProvince == 11
                         select p).ToList();
            var q1 = db.Foods.Where(m => m.Provinces.Any(p => p.id == 11));
            foreach (var place in query)
            {
                s += "<div class='col-xs-6 col-sm-3 placeholder'>" + "<h2>" + place.name + "</h2>" + "<br/>";
                s += place.pictures + "<br/>";
                s += "<p>" + place.description + "</p> </div>";

            }
            foreach (var food in q1)
            {
                chuoi += "<div class=\"col-xs-6 col-md-3\">";

                chuoi += "<a href=\"#\" class=\"thumbnail\">";
                chuoi += food.description;
                chuoi += "<h3>" + food.name + "</h3>";
                chuoi += "</a>";
                chuoi += "</div>";

            }
            ViewBag.View = s;
            ViewBag.Xem = chuoi;
            return View();
        }
        public ActionResult DuLichTienGiang()
        {
            string s = "";
            string chuoi = "";
            var query = (from p in db.Places
                         where p.idProvince == 12
                         select p).ToList();
            var q1 = db.Foods.Where(m => m.Provinces.Any(p => p.id == 12));
            foreach (var place in query)
            {
                s += "<div class='col-xs-6 col-sm-3 placeholder'>" + "<h2>" + place.name + "</h2>" + "<br/>";
                s += place.pictures + "<br/>";
                s += "<p>" + place.description + "</p> </div>";

            }
            foreach (var food in q1)
            {
                chuoi += "<div class=\"col-xs-6 col-md-3\">";

                chuoi += "<a href=\"#\" class=\"thumbnail\">";
                chuoi += food.description;
                chuoi += "<h3>" + food.name + "</h3>";
                chuoi += "</a>";
                chuoi += "</div>";

            }
            ViewBag.View = s;
            ViewBag.Xem = chuoi;
            return View();
        }
        public ActionResult DuLichTraVinh()
        {
            string s = "";
            string chuoi = "";
            var query = (from p in db.Places
                         where p.idProvince == 13
                         select p).ToList();
            var q1 = db.Foods.Where(m => m.Provinces.Any(p => p.id == 13));
            foreach (var place in query)
            {
                s += "<div class='col-xs-6 col-sm-3 placeholder'>" + "<h2>" + place.name + "</h2>" + "<br/>";
                s += place.pictures + "<br/>";
                s += "<p>" + place.description + "</p> </div>";

            }
            foreach (var food in q1)
            {
                chuoi += "<div class=\"col-xs-6 col-md-3\">";

                chuoi += "<a href=\"#\" class=\"thumbnail\">";
                chuoi += food.description;
                chuoi += "<h3>" + food.name + "</h3>";
                chuoi += "</a>";
                chuoi += "</div>";

            }
            ViewBag.View = s;
            ViewBag.Xem = chuoi;
            return View();
        }
        public ActionResult DuLichVinhLong()
        {
            string s = "";
            string chuoi = "";
            var query = (from p in db.Places
                         where p.idProvince == 14
                         select p).ToList();
            var q1 = db.Foods.Where(m => m.Provinces.Any(p => p.id == 14));
            foreach (var place in query)
            {
                s += "<div class='col-xs-6 col-sm-3 placeholder'>" + "<h2>" + place.name + "</h2>" + "<br/>";
                s += place.pictures + "<br/>";
                s += "<p>" + place.description + "</p> </div>";

            }
            foreach (var food in q1)
            {
                chuoi += "<div class=\"col-xs-6 col-md-3\">";

                chuoi += "<a href=\"#\" class=\"thumbnail\">";
                chuoi += food.description;
                chuoi += "<h3>" + food.name + "</h3>";
                chuoi += "</a>";
                chuoi += "</div>";

            }
            ViewBag.View = s;
            ViewBag.Xem = chuoi;
            return View();
        }

    }
}