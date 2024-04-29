using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Full_Training.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseID {  get; set; }
        public string courseName {  get; set; } 

        public bool isAvailable { get; set; }
    }
}