using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuLichProject.Controllers
{
    public class FirstPageController : Controller
    {
        //
        // GET: /FirstPage/

        public ActionResult FirstLoad()
        {
            return View();
        }

    }
}
