namespace EntityFrameworkExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMovie : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Characters", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Characters", new[] { "Movie_Id" });
            DropColumn("dbo.Characters", "Movie_Id");
            DropTable("dbo.Movies");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Genre = c.String(),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Characters", "Movie_Id", c => c.Int());
            CreateIndex("dbo.Characters", "Movie_Id");
            AddForeignKey("dbo.Characters", "Movie_Id", "dbo.Movies", "Id");
        }
    }
}
