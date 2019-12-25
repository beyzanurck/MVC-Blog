namespace NBUY_REF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIndexPage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "blog.Index",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TitleName = c.String(),
                        IndexDescription = c.String(),
                        IndexImage = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("blog.Index");
        }
    }
}
