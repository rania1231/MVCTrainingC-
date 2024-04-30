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
        public DbSet<ClasseRoom> classeRooms { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }

    }
}