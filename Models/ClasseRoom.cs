using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MVC_Full_Training.Models
{
    public class ClasseRoom
    {
        public int classRoomID {  get; set; }
        public int classRoomNO { get; set; }
        public string classRoomName { get; set; }

        public bool isAvailable { get; set; }
    }
}