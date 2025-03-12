using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortolfyoProject.Models;
namespace AcunMedyaPortolfyoProject.Controllers
{
    public class TestimonialController : Controller
    {
        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Tbl_Testimonial.ToList();
            return View(values);
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.Tbl_Testimonial.Find(id);
            db.Tbl_Testimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(Tbl_Testimonial testimonial)
        {
            db.Tbl_Testimonial.Add(testimonial);
            db.SaveChanges();
                        return RedirectToAction("Index");

        }
      
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = db.Tbl_Testimonial.Find(id);
            return View(values);
        }
        [HttpPost]
       public ActionResult UpdateTestimonial(Tbl_Testimonial model)   //ıd = 1 name 
        {
            var value = db.Tbl_Testimonial.Find(model.TestimonialID);
            value.TestimonialName = model.TestimonialName;
            value.Description2 = model.Description2;
            value.ImageUrl = model.ImageUrl;
            value.Title = model.Title;
            value.Description1 = model.Description1;
            db.SaveChanges();
            return RedirectToAction("Index");

            
        }
    }
}