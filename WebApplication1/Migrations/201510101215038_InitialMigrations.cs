namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigrations : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.AdvertisementModels",
            //    c => new
            //        {
            //            id = c.Int(nullable: false, identity: true),
            //            date = c.DateTime(nullable: false),
            //            title = c.String(nullable: false),
            //            description = c.String(nullable: false),
            //            UserId = c.String(maxLength: 128),
            //            animal_id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.id)
            //    .ForeignKey("dbo.AnimalModels", t => t.animal_id)
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId)
            //    .Index(t => t.UserId)
            //    .Index(t => t.animal_id);
            
            //CreateTable(
            //    "dbo.AnimalModels",
            //    c => new
            //        {
            //            id = c.Int(nullable: false, identity: true),
            //            name = c.String(nullable: false),
            //            type = c.String(),
            //            race = c.String(),
            //        })
            //    .PrimaryKey(t => t.id);
            
            //AddColumn("dbo.ImageModels", "AnimalModel_id", c => c.Int());
            //CreateIndex("dbo.ImageModels", "AnimalModel_id");
            //AddForeignKey("dbo.ImageModels", "AnimalModel_id", "dbo.AnimalModels", "id");
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.AdvertisementModels", "UserId", "dbo.AspNetUsers");
            //DropForeignKey("dbo.AdvertisementModels", "animal_id", "dbo.AnimalModels");
            //DropForeignKey("dbo.ImageModels", "AnimalModel_id", "dbo.AnimalModels");
            //DropIndex("dbo.ImageModels", new[] { "AnimalModel_id" });
            //DropIndex("dbo.AdvertisementModels", new[] { "animal_id" });
            //DropIndex("dbo.AdvertisementModels", new[] { "UserId" });
            //DropColumn("dbo.ImageModels", "AnimalModel_id");
            //DropTable("dbo.AnimalModels");
            //DropTable("dbo.AdvertisementModels");
        }
    }
}
