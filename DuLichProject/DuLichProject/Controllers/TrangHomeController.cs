using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DuLichProject.Models;

namespace DuLichProject.Controllers
{

    public class TrangHomeController : Controller
    {
        private SoTayDB db = new SoTayDB();
        public ActionResult TrangChu()
        {
            String s = "";
            var pro = (from p in db.Provinces orderby p.id ascending select p).ToList();



            for (int i = 0; i < pro.Count; i++)
            {
                s += "<hr class=\"featurette-divider\">";

                s += "<div class=\"row featurette\" style=\" width: auto ; height: auto; margin: auto\">";
                s += " <div class=\"col-md-4, products\" style=\" width: auto ; height: auto; margin: auto\">";
                s += "<img class=\"img-rounded\"" + pro[i].Picture
                   + "style=\"width: 450px; height: 360px;\">";

                s += "  <div class=\"pd-des\">";
               
                if (Session["currentUser"] != null)
                {
                    s += " <br><h3>Thông tin du lịch</h3><br>- Địa điểm của chúng tôi rât vui<br>- Vé tham quan theo chương trình + thưởng thức ca nhạc kịch";
                    s += "  <br/>CHI PHÍ TRẺ EM ÐI CÙNG:<br />";
                    s += "  - Trẻ em dưới 6 tuổi : miễn phí vé vào cổng <br />";
                    s += " - Du khách dưới 12 tuổi-giá vé: "+ pro[i].ChildrenPrice+ "<br />";
                    s += " - Du khách từ 12 tuổi trở lên-giá vé: "+ pro[i].AdultPrice+"<br />";
                    s += "  *  Mọi chi tiết xin vui lòng liên hệ: <br />";

                    s += " TRUNG TÂM ÐIỀU HÀNH DU LỊCH  ABC<br />";
                    s += " 215 Quang Trung, Quận 12, TP.Hồ Chí Minh<br />";
                    s += "  ÐT: 067.3873 123 – 7598 692       Fax: 067.3855 744<br />";
                    s += "  Email: chuamuonchet@gmail.com      Website: ABCtourist.com<br />";
                    s += "  Hotline : 0979.237.383 ( Anh Bảo )<br />";
                }
                else
                {
                    s += "<h3 style=\"color: white\"> THÔNG TIN DU LỊCH </h3>";
                    s += "<a style=\"color: white\">Vui lòng đăng nhập để biết thêm chi tiết</a><br/>";
                }
                

                s += "</div>";
                s += " </div>";
                s += " <div class=\"col-md-5\">";

                //mo ta link duong dan o day
                if (Session["currentUser"] != null)
                {
                    s += "<h2>" + "<a href=\"/Places/" + pro[i].Contact + "\">" + pro[i].Name + "</a>" + "</h2>";
                    s += "<p class=\"lead\">" + pro[i].Description + " </p>";
                }
                else
                {
                    s += "<h2>" + pro[i].Name + "</h2><br/>";
                    s += "<h4 style=\"color: red\"> Vui lòng đăng nhập để biết thêm chi tiết</h4>";
                }


                s += "</div>";
                s += " </div>";

            }




            ViewBag.View = s;
            return View();
        }


    }
}
