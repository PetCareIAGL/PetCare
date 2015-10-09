namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class image : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImageModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        image = c.Binary(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.AspNetUsers", "Image_id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Image_id");
            AddForeignKey("dbo.AspNetUsers", "Image_id", "dbo.ImageModels", "id");
            DropColumn("dbo.AspNetUsers", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Image", c => c.Binary());
            DropForeignKey("dbo.AspNetUsers", "Image_id", "dbo.ImageModels");
            DropIndex("dbo.AspNetUsers", new[] { "Image_id" });
            DropColumn("dbo.AspNetUsers", "Image_id");
            DropTable("dbo.ImageModels");
        }
    }
}
