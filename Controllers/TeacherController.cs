using MVC_Full_Training.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Full_Training.Controllers
{
    public class TeacherController : Controller
    {
        ConnectDB conection = new ConnectDB();
        public ActionResult GetTeachers()
        {

            List<Teacher> teachers = new List<Teacher>();
            teachers = (from obj in conection.teachers select obj).ToList();

            return View(teachers);
        }

        public ActionResult GetTeacher(int id)
        {
            Teacher teacher = new Teacher();
            teacher = (from obj in conection.teachers where obj.teacherID == id select obj).FirstOrDefault();
            return View();
        }


       [HttpGet]
        public ActionResult InsertTeacher()
        {
            //Teacher teacher = new Teacher();
            //teacher.teacherNo = 2;
            //teacher.teacherName = "Monia";


            //conection.teachers.Add(teacher);
           // conection.SaveChanges();
            return View();
        }
        [HttpPost]
        public ActionResult InsertTeacher(Teacher teacher)
        {
            conection.teachers.Add(teacher);
            conection.SaveChanges();
            return RedirectToAction("GetTeachers");
        }


        public ActionResult DeleteTeacher(int id)
        {
            Teacher teacher = new Teacher();
            teacher = (from obj in conection.teachers where obj.teacherID == id select obj).FirstOrDefault();
            conection.teachers.Remove(teacher); // supprimer course from dataset teachers
            conection.SaveChanges();  // update table teacher
            return RedirectToAction("GetTeachers"); // Affichage de la Vue teachers
        }

        public ActionResult EditTeacher(int id)
        {
            Teacher teacher = new Teacher();
            teacher = (from obj in conection.teachers where obj.teacherID == id select obj).FirstOrDefault();
            teacher.teacherNo = 2;
            teacher.teacherName = "Mounir";
            conection.SaveChanges();//update database
            return View();
        }
    }
}