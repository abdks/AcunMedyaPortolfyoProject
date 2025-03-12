using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortolfyoProject.Models;
namespace AcunMedyaPortolfyoProject.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Tbl_Education.ToList();
            return View(values);
        }
    }
}