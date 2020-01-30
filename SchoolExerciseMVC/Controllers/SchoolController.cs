using SchoolExerciseMVC.Models;
using SchoolExerciseMVC.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolExerciseMVC.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public ActionResult Index()
        {
            List<SchoolList> lst;
            using (SchoolEntities db = new SchoolEntities())
            {
                lst = (from d in db.School
                       select new SchoolList
                       {
                           Id = d.id,
                           Name = d.name,
                           Year = d.year

                       }).ToList();
            }

            return View(lst);
        }
    }
       
}