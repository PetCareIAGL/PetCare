namespace WebApplication1.BddContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PersonModels", "image_id", "dbo.ImageModels");
            DropIndex("dbo.PersonModels", new[] { "image_id" });
            DropTable("dbo.PersonModels");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.id);
            
            CreateIndex("dbo.PersonModels", "image_id");
            AddForeignKey("dbo.PersonModels", "image_id", "dbo.ImageModels", "id");
        }
    }
}
