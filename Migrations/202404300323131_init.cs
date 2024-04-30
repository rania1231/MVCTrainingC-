namespace MVC_Full_Training.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClasseRooms",
                c => new
                    {
                        classRoomID = c.Int(nullable: false, identity: true),
                        classRoomNO = c.Int(nullable: false),
                        classRoomName = c.String(),
                        isAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.classRoomID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        courseID = c.Int(nullable: false, identity: true),
                        courseName = c.String(),
                        isAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.courseID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        studentID = c.Int(nullable: false, identity: true),
                        studentName = c.String(),
                        studentNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.studentID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        teacherID = c.Int(nullable: false, identity: true),
                        teacherName = c.String(),
                        teacherNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.teacherID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
            DropTable("dbo.ClasseRooms");
        }
    }
}
