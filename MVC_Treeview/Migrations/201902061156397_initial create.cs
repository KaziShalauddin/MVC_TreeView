namespace MVC_Treeview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ParentID = c.Int(),
                        Name = c.String(),
                        Checked = c.Boolean(nullable: false),
                        OrderNumber = c.Int(nullable: false),
                        Population = c.Long(),
                        FlagUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.ParentID)
                .Index(t => t.ParentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locations", "ParentID", "dbo.Locations");
            DropIndex("dbo.Locations", new[] { "ParentID" });
            DropTable("dbo.Locations");
        }
    }
}
