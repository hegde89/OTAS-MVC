using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ABC.Models;

namespace ABC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(StudentTeacherRetrival studentDetails)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Usn not appropriate");
                return View(studentDetails);
            }

            Session["USN"] = studentDetails.USN;
            RNSITEntities1 db = new RNSITEntities1();
            var details = db.GetTeacherDetailsByUSNFunction(studentDetails.USN);
            return View("StudentDetailsFirstPage", details);
        }
        [HttpGet]
        public ActionResult StudentReviews()
        {
            string usn = Session["USN"].ToString();
            RNSITEntities1 db = new RNSITEntities1();

            List<GetTeacherDetailsByUSN_Result> details = db.GetTeacherDetailsByUSNFunction(usn).ToList();
            int counter = db.ValidS.Single(s => s.USN == usn).COUNTER;

            if(counter<details.Count)
            {
                RatingsModel ratingsModel = new RatingsModel();
                ratingsModel.Subcode = details.ElementAt(counter).SubCode;
                ratingsModel.SubName = details.ElementAt(counter).SubName;
                ratingsModel.TeacherName = details.ElementAt(counter).TeacherName;
                return View("Ratings", ratingsModel);
            }
            else
            {
                return RedirectToAction("ReviewCompleted", "student");
            }
        }
        [HttpPost]
        public ActionResult StudentReviews(RatingsModel Data)
        {
            string usn = Session["USN"].ToString();
            RNSITEntities1 db = new RNSITEntities1();
            List<GetTeacherDetailsByUSN_Result> details = db.GetTeacherDetailsByUSNFunction(usn).ToList();
            int counter = db.ValidS.Single(s => s.USN == usn).COUNTER;

            var RID = details.ElementAt(counter).CombId;
            RID_TABLE t = Data;
            t.RID = details.ElementAt(counter).CombId;
            db.RID_TABLE.Add(t);
            var validS = db.ValidS.Single(s => s.USN == usn);
            validS.COUNTER = ++counter;
            db.SaveChanges();

            return RedirectToAction("StudentReviews", "Student");
        }
        public ActionResult ReviewCompleted(RatingsModel Data)
        {
            return View();
        }

    }
}