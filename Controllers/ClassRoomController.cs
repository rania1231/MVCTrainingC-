using MVC_Full_Training.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Full_Training.Controllers
{
    public class ClassRoomController : Controller
    {
        ConnectDB conection = new ConnectDB();
        public ActionResult Index()
        {

            List<ClasseRoom> classRooms = new List<ClasseRoom>();
            classRooms = (from obj in conection.classeRooms select obj).ToList();

            return View(classRooms);
        }

        public ActionResult GetClasseRoom(int id)
        {
            ClasseRoom classRoom = new ClasseRoom();
            classRoom = (from obj in conection.classeRooms where obj.classRoomID == id select obj).FirstOrDefault();
            return View();
        }

        public ActionResult InsertClasseRoom()
        {
            ClasseRoom classRoom = new ClasseRoom();
            classRoom.classRoomNO = 2;
            classRoom.classRoomName = "A";



            conection.classeRooms.Add(classRoom);
            conection.SaveChanges();
            return View();
        }

        public ActionResult DeleteClasseRoom(int id)
        {
            ClasseRoom classRoom = new ClasseRoom();
            classRoom = (from obj in conection.classeRooms where obj.classRoomID == id select obj).FirstOrDefault();
            conection.classeRooms.Remove(classRoom); // supprimer course from dataset classRooms
            conection.SaveChanges();  // update table classRoom
            return View(); // Affichage de la Vue classRooms
        }

        public ActionResult EditClasseRoom(int id)
        {
            ClasseRoom classRoom = new ClasseRoom();
            classRoom = (from obj in conection.classeRooms where obj.classRoomID == id select obj).FirstOrDefault();
            classRoom.classRoomNO = 2;
            classRoom.classRoomName = "B";
            conection.SaveChanges();//update database
            return View();
        }
    }
}