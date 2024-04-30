using MVC_Full_Training.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Full_Training.Controllers
{
    public class StudentController : Controller
    {
        ConnectDB conection = new ConnectDB();
        public ActionResult GetStudents()
        {

            List<Student> students = new List<Student>();
            students = (from obj in conection.students select obj).ToList();

            return View();
        }

        public ActionResult GetStudent(int id)
        {
            Student student = new Student();
            student = (from obj in conection.students where obj.studentID == id select obj).FirstOrDefault();
            return View();
        }

        public ActionResult InsertStudent()
        {
            Student student = new Student();
            student.studentNo = 2;
            student.studentName = "Rania";
            

            conection.students.Add(student);
            conection.SaveChanges();
            return View();
        }

        public ActionResult DeleteStudent(int id)
        {
            Student student = new Student();
            student = (from obj in conection.students where obj.studentID == id select obj).FirstOrDefault();
            conection.students.Remove(student); // supprimer course from dataset students
            conection.SaveChanges();  // update table student
            return View(); // Affichage de la Vue students
        }

        public ActionResult EditStudent(int id)
        {
            Student student = new Student();
            student = (from obj in conection.students where obj.studentID == id select obj).FirstOrDefault();
            student.studentNo = 2;
            student.studentName = "Sirine";
            conection.SaveChanges();//update database
            return View();
        }
    }
}