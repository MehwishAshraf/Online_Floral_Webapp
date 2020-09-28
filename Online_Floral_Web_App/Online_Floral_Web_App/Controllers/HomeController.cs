using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Floral_Web_App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Category(int id)
        {
            ViewBag.cate = "";
            switch (id)
            {
                case 1: ViewBag.cate = "Birthday"; break;
                case 2: ViewBag.cate = "Father's Day"; break;
                case 3: ViewBag.cate = "Mother's Day"; break;
                case 4: ViewBag.cate = "Baby New Arrival"; break;
                case 5: ViewBag.cate = "Congratulation"; break;
                case 6: ViewBag.cate = "Anniversary"; break;

            }
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}