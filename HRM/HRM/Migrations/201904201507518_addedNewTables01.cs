namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNewTables01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ShortName = c.String(),
                        DesignationName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeCode = c.String(),
                        FullName = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        NickName = c.String(),
                        DesignationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Designations", t => t.DesignationId, cascadeDelete: true)
                .Index(t => t.DesignationId);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionCode = c.String(maxLength: 10),
                        SectionName = c.String(maxLength: 150),
                        DeptId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DeptId, cascadeDelete: true)
                .Index(t => t.DeptId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sections", "DeptId", "dbo.Departments");
            DropForeignKey("dbo.Employees", "DesignationId", "dbo.Designations");
            DropIndex("dbo.Sections", new[] { "DeptId" });
            DropIndex("dbo.Employees", new[] { "DesignationId" });
            DropTable("dbo.Sections");
            DropTable("dbo.Employees");
            DropTable("dbo.Designations");
        }
    }
}
