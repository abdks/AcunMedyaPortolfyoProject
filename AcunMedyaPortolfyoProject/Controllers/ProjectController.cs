using AcunMedyaPortolfyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project   ----> MVC MODEL VİEW CONTROLLER
       DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();

        public ActionResult Index()
        {
            var values = db.Tbl_Project.ToList();
            return View(values);
        }
        //Ekleme güncelleme silme getirmeniz gerekiyor

    }
}