namespace PersonnelSTU.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VwFaculty",
                c => new
                    {
                        iDepartment = c.Short(nullable: false, identity: true),
                        DepName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.iDepartment);
            
            CreateTable(
                "dbo.VwGroups",
                c => new
                    {
                        iFac = c.Short(nullable: false, identity: true),
                        iGroup = c.Short(nullable: false),
                        gPrefix = c.String(nullable: false),
                        gIndex = c.Short(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        iSpec = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.iFac);
            
            CreateTable(
                "dbo.VwPerson",
                c => new
                    {
                        iPerson = c.Int(nullable: false, identity: true),
                        PersonName = c.String(maxLength: 42),
                        BirthDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.iPerson);
            
            CreateTable(
                "dbo.Spec",
                c => new
                    {
                        iSpec = c.String(nullable: false, maxLength: 5),
                        iFac = c.Short(nullable: false),
                        SpecName = c.String(nullable: false, maxLength: 220),
                        SpecNumber = c.String(nullable: false, maxLength: 8),
                        EduForm = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.iSpec);
            
            CreateTable(
                "dbo.VwStudentStatesTop",
                c => new
                    {
                        iMessage = c.Int(nullable: false, identity: true),
                        iStudent = c.Int(nullable: false),
                        iState = c.Short(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        StopDateVac = c.DateTime(),
                        iGroup = c.Short(nullable: false),
                        Ayear = c.Byte(nullable: false),
                        StuGroupName = c.String(maxLength: 15),
                        TheName = c.String(nullable: false, maxLength: 42),
                        Zoo = c.String(maxLength: 11),
                        iSpec = c.String(nullable: false, maxLength: 5),
                        iFac = c.Short(nullable: false),
                        EduForm = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.iMessage);
            
            CreateTable(
                "dbo.rStuStates",
                c => new
                    {
                        iState = c.Short(nullable: false, identity: true),
                        StateName = c.String(nullable: false, maxLength: 50),
                        ActionName = c.String(nullable: false, maxLength: 100),
                        StateNick = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.iState);
            
            CreateTable(
                "dbo.PpsSite",
                c => new
                    {
                        IDD = c.Int(nullable: false, identity: true),
                        TabNo = c.Int(nullable: false),
                        Fio = c.String(maxLength: 70),
                        DepName = c.String(nullable: false, maxLength: 250),
                        PostName = c.String(nullable: false, maxLength: 250),
                        us = c.String(maxLength: 70),
                        uz = c.String(maxLength: 70),
                    })
                .PrimaryKey(t => t.IDD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PpsSite");
            DropTable("dbo.rStuStates");
            DropTable("dbo.VwStudentStatesTop");
            DropTable("dbo.Spec");
            DropTable("dbo.VwPerson");
            DropTable("dbo.VwGroups");
            DropTable("dbo.VwFaculty");
        }
    }
}
