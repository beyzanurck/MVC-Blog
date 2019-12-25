namespace NBUY_REF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIndexPageName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "blog.Index", newName: "IndexPage");
        }
        
        public override void Down()
        {
            RenameTable(name: "blog.IndexPage", newName: "Index");
        }
    }
}
