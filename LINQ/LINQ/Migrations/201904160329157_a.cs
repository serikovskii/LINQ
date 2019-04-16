namespace LINQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Color = c.String(),
                        Price = c.Int(nullable: false),
                        Mark_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marks", t => t.Mark_Id)
                .Index(t => t.Mark_Id);
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "Mark_Id", "dbo.Marks");
            DropIndex("dbo.Cars", new[] { "Mark_Id" });
            DropTable("dbo.Marks");
            DropTable("dbo.Cars");
        }
    }
}
