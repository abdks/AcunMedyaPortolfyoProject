using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortolfyoProject.Models;
namespace AcunMedyaPortolfyoProject.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories   MVC MODEL VİEW CONTROLLER
        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        
        public ActionResult Index()
        {
            //string  byte int liste 
            var values = db.Tbl_Category.ToList();        // select * from tbl_category
            return View(values);
        }

        public ActionResult DeleteCategory(int id) //3
        {
            var values = db.Tbl_Category.Find(id); //5
            db.Tbl_Category.Remove(values);  //delete 
            db.SaveChanges(); //sql deki control + s 
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Tbl_Category category)   //category id = , categoryname =test
        {
            db.Tbl_Category.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategoryy(int id)
        {
            var values = db.Tbl_Category.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCategoryy(Tbl_Category model)
        {
            var value = db.Tbl_Category.Find(model.CategoryID);
            value.CategoryName = model.CategoryName;
            db.SaveChanges();  //ctrl s veri tabanında
            return RedirectToAction("Index");
        }


    }
}