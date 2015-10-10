namespace WebApplication1.BddContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdvertisementModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        title = c.String(nullable: false),
                        description = c.String(nullable: false),
                        animal_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AnimalModels", t => t.animal_id)
                .Index(t => t.animal_id);
            
            CreateTable(
                "dbo.AnimalModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        type = c.String(),
                        race = c.String(),
                    })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.ImageModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        image = c.Binary(),
                        description = c.String(),
                        AnimalModel_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AnimalModels", t => t.AnimalModel_id)
                .Index(t => t.AnimalModel_id);
                        
            AddColumn("dbo.AspNetUsers", "Image_id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Image_id");
            AddForeignKey("dbo.AspNetUsers", "Image_id", "dbo.ImageModels", "id");
            DropColumn("dbo.AspNetUsers", "Image");
            
            CreateTable(
                "dbo.PersonModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        lastname = c.String(),
                        birthday = c.DateTime(nullable: false),
                        email = c.String(),
                        address = c.String(),
                        phone = c.String(),
                        login = c.String(),
                        password = c.String(),
                        image_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ImageModels", t => t.image_id)
                .Index(t => t.image_id);
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Image", c => c.Binary());
            DropForeignKey("dbo.AspNetUsers", "Image_id", "dbo.ImageModels");
            DropForeignKey("dbo.PersonModels", "image_id", "dbo.ImageModels");
            DropForeignKey("dbo.AdvertisementModels", "animal_id", "dbo.AnimalModels");
            DropForeignKey("dbo.ImageModels", "AnimalModel_id", "dbo.AnimalModels");
            DropIndex("dbo.AspNetUsers", new[] { "Image_id" });
            DropIndex("dbo.PersonModels", new[] { "image_id" });
            DropIndex("dbo.ImageModels", new[] { "AnimalModel_id" });
            DropIndex("dbo.AdvertisementModels", new[] { "animal_id" });
            DropColumn("dbo.AspNetUsers", "Image_id");
            DropTable("dbo.PersonModels");
            DropTable("dbo.ImageModels");
            DropTable("dbo.AnimalModels");
            DropTable("dbo.AdvertisementModels");
        }
    }
}
