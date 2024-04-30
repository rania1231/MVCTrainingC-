using MVC_Full_Training.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace MVC_Full_Training.Controllers
{
    public class CourseController : Controller
    {
        ConnectDB conection = new ConnectDB();
        public ActionResult GetCourses() { 

            List<Course> courses= new List<Course>();
            courses= (from obj in conection.courses select obj).ToList();

            return View("Courses");
        }

        public ActionResult GetCourse(int id)
        {
            Course course = new Course();
            course= (from obj in conection.courses where obj.courseID==id select obj).FirstOrDefault() ;
            return View("DetailsCourse");
        }

        public ActionResult InsertCourse()
        {
            Course course = new Course();
            course.courseName = "Math";
            course.isAvailable = true;

            conection.courses.Add(course);
            conection.SaveChanges();
            return View("Courses");
        }

        public ActionResult DeleteCourse(int id)
        {
            Course course = new Course();
            course = (from obj in conection.courses where obj.courseID == id select obj).FirstOrDefault();
            conection.courses.Remove(course); // supprimer course from dataset courses
            conection.SaveChanges();  // update table Course
            return View("Courses"); // Affichage de la Vur Courses
        }

        public ActionResult EditCourse(int id)
        {
            Course course = new Course();
            course = (from obj in conection.courses where obj.courseID == id select obj).FirstOrDefault();
            course.isAvailable = false;
            course.courseName = "Math2";
            conection.SaveChanges();//update database
            return View("Courses");
        }
    }
}