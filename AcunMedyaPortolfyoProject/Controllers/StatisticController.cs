using AcunMedyaPortolfyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
                DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();

        public ActionResult Index()
        {
            //viewbag    
            ViewBag.CategoryCount = db.Tbl_Category.Count();
            ViewBag.TestimonialCount = db.Tbl_Testimonial.Count();
            ViewBag.ProjeSayisi = db.Tbl_Project.Count();
            ViewBag.text = "veri";
            return View();
        }
    }
}