using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Full_Training.Models
{
    public class ConnectDB:DbContext
    {
        public ConnectDB() :base("TestConnectionString")
        { }
        DbSet<ClasseRoom> classeRooms { get; set; }
        DbSet<Course> courses { get; set; }
        DbSet<Student> students { get; set; }
        DbSet<Teacher> teachers { get; set; }

    }
}