namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class images1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "Image_id", "dbo.ImageModels");
            DropIndex("dbo.AspNetUsers", new[] { "Image_id" });
            AddColumn("dbo.AspNetUsers", "Image", c => c.Binary());
            DropColumn("dbo.AspNetUsers", "Image_id");
            DropTable("dbo.ImageModels");
        }
        
        public override void Down()
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
            DropColumn("dbo.AspNetUsers", "Image");
            CreateIndex("dbo.AspNetUsers", "Image_id");
            AddForeignKey("dbo.AspNetUsers", "Image_id", "dbo.ImageModels", "id");
        }
    }
}
