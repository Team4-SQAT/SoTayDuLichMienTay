using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DuLichProject.Models;
using Microsoft.Ajax.Utilities;
using WebMatrix.WebData;

namespace DuLichProject.Controllers
{
    
  
    public class UserController : Controller
    {
        private SoTayDB db = new SoTayDB();
      
        public ActionResult LogIn()
        {
            return View();
        }

        //
        // POST: /LogIn/

        [HttpPost]
        public ActionResult LogIn(User user)
        {
            //Check valid user
            //
            bool isValid = false;
            foreach (var item in db.Users.ToList())
            {
                if (item.username.Trim() == user.username && item.password.Trim() == user.password)
                {
                    isValid = true;
                }
            }
            if (isValid)
            {
                Session["currentUser"] = user;
                return RedirectToAction("TrangChu", "TrangHome");
            }
            ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng - Mời nhập lại!!!");
            return View(user);
        }

        public ActionResult LogOut()
        {
            Session["currentUser"] = null;
            return RedirectToAction("TrangChu", "TrangHome");
        }
        //
        // GET: /User/

      

        //
        // GET: /User/Details/5

        public ActionResult Details(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
        //register

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                if (ModelState.IsValid)
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("TrangChu","TrangHome");
                }

                return View(user);
            }

            // If we got this far, something failed, redisplay form
            return View(user);
        }

        private string ErrorCodeToString(MembershipCreateStatus membershipCreateStatus)
        {
            throw new NotImplementedException();
        }

        //public ActionResult CreateNew(FormCollection formCollection)
        //{

        //    var name = formCollection["username"];
        //    var password = formCollection["password"];
        //    var address = formCollection["address"];
        //    var email = formCollection["email"];


        //    if (CreateStore(formCollection))
        //    {
        //        return Json(new { success = true, type = "create", msg = "Tạo đối tác thành công." }, JsonRequestBehavior.AllowGet);
        //    }
        //    return Json(new { success = false, msg = "Tạo đối tác không thành công do lỗi server." }, JsonRequestBehavior.AllowGet);

        //}
        //public ActionResult CreateEdit(FormCollection formCollection)
        //{
        //    var formMode = formCollection["FormMode"];
        //    var name = formCollection["username"];
        //    var password = formCollection["password"];
        //    var address = formCollection["address"];
        //    var email = formCollection["email"];
        //    // Validating.
        //    if (formMode.IsNullOrWhiteSpace() || name.IsNullOrWhiteSpace() ||
        //        address.IsNullOrWhiteSpace())
        //    {
        //        return Json(new { success = false, msg = "Vui lòng điền đầy đủ thông tin." }, JsonRequestBehavior.AllowGet);
        //    }



        //    // Processing.
        //    if (formMode == "Create")
        //    {
        //        if (CreateStore(formCollection))
        //        {
        //            return Json(new { success = true, type = "create", msg = "Tạo đối tác thành công." }, JsonRequestBehavior.AllowGet);
        //        }
        //        return Json(new { success = false, msg = "Tạo đối tác không thành công do lỗi server." }, JsonRequestBehavior.AllowGet);
        //    }

           

        //    return Json(new { success = false, msg = "Lệnh thực thi không phù hợp." }, JsonRequestBehavior.AllowGet);
        //}
        //private bool CreateStore(FormCollection formCollection)
        //{
        //    try
        //    {
        //        // Check and trim params.
        //        var name = formCollection["username"].Trim();
        //        var address = formCollection["address"].Trim();
        //        var email = formCollection["email"].Trim();
        //        var password = formCollection["password"].Trim();
        //        var store = new User
        //        {
        //            username = name,
        //            address = address,
        //            email = email,
        //            password = password,
                    

        //        };

              
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //    return true;

        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Register(User user, User img, HttpPostedFileBase file)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (file != null)
        //        {
        //            file.SaveAs(HttpContext.Server.MapPath("~/Images/")
        //                                                  + file.FileName);
        //            img.avatar = file.FileName;
        //        }  
        //        db.Users.Add(user);
        //        db.Users.Add(img);
        //        db.SaveChanges();
        //        return RedirectToAction("TrangChu","TrangHome");
        //    }

        //    return View(user);
        //}

        //
        // GET: /User/Create
        
        //create category
       
        //navigate create&edit
       


        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /User/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        //
        // GET: /User/Edit/5

        public ActionResult Edit(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //
        // GET: /User/Delete/5

        public ActionResult Delete(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // POST: /User/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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