using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Full_Training.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult FirstPage()
        {
            return View();
        }
    }
}